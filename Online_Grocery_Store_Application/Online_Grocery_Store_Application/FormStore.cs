using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    public partial class FormStore : Form
    {
        private List<Products> products = new List<Products>();
        private FormProductDetail detail = new FormProductDetail();
        public Users User { get; set; }

        //Singleton Design Pattern
        private static FormStore instance = null;
        public static FormStore Instance
        {
            get
            {
                if (instance is null || instance.IsDisposed)
                    instance = new FormStore();
                return instance;
            }
            set => instance = value;
        }
        private FormStore()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            MenuStrip ms = new MenuStrip();

            ToolStripMenuItem GroceryMenu = new ToolStripMenuItem("Grocery26");
            ToolStripMenuItem HelpMenu = new ToolStripMenuItem("Help");

            ToolStripMenuItem LogOut = new ToolStripMenuItem("Log Out", null, new EventHandler(LogOut_Click));
            GroceryMenu.DropDownItems.Add(LogOut);
            ToolStripMenuItem Settings = new ToolStripMenuItem("Settings", null, new EventHandler(Settings_Click));
            GroceryMenu.DropDownItems.Add(Settings);
            ToolStripMenuItem Exit = new ToolStripMenuItem("Exit", null, new EventHandler(Exit_Click));
            GroceryMenu.DropDownItems.Add(Exit);

            ToolStripMenuItem BookINSupport = new ToolStripMenuItem("Did you find an error?", null, new EventHandler(GrocerySupport_Click));
            HelpMenu.DropDownItems.Add(BookINSupport);
            ToolStripMenuItem AboutBookIN = new ToolStripMenuItem("About Grocery26", null, new EventHandler(AboutGrocery_Click));
            HelpMenu.DropDownItems.Add(AboutBookIN);

            ((ToolStripDropDownMenu)(GroceryMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(GroceryMenu.DropDown)).ShowCheckMargin = false;

            ((ToolStripDropDownMenu)(HelpMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(HelpMenu.DropDown)).ShowCheckMargin = false;

            ms.MdiWindowListItem = GroceryMenu;
            ms.MdiWindowListItem = HelpMenu;
            ms.Items.Add(GroceryMenu);
            ms.Items.Add(HelpMenu);
            ms.Dock = DockStyle.Top;
            this.MainMenuStrip = ms;
            this.Controls.Add(ms);
        }
        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void LogOut_Click(object sender, EventArgs e)
        {
            FormLogin.Instance.Show();
            this.Dispose();
        }

        void Settings_Click(object sender, EventArgs e)
        {
            UserProfile.Instance.User = this.User;
            UserProfile.Instance.Show();
        }

        void GrocerySupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You need to restart Grocery26 Application.", "Warning");
        }

        void AboutGrocery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developed by 4 students" + Environment.NewLine +
                Environment.NewLine + "Ömer Faruk ÖZTÜRK - 152120171018" +
                Environment.NewLine + "Yahya Bekir CANEVİ - 152120181030" +
                Environment.NewLine + "Fatih HEVESLİ - 152120181037" +
                Environment.NewLine + "Ceyhun ÖZKAN - 151820173028");
        }

        private void FormStore_Load(object sender, EventArgs e)
        {
            listViewProducts.Items.Clear();
            ReadProductsFromDatabase();
            panelCart.Controls.Clear();
            panelCart.AutoScroll = true;
            ReadCartItemsFromDatabase();
            labelUsername.Text = User.userName;
        }

        /// <summary>
        /// Store
        /// </summary>

        string imageFolder = @".\Images\";

        void ReadProductsFromDatabase()
        {
            Database.Instance.ProductList();
            Database.Instance.GetProductsList.ForEach((x) => {
                ListViewItem row = new ListViewItem();
                imageList1.Images.Add($"{x.name}{x.imageExt}",
                        Image.FromFile($"{imageFolder}{x.name}{x.imageExt}"));
                row.ImageKey = $"{x.name}{x.imageExt}";
                row.SubItems.Add(x.name);           //name
                row.SubItems.Add(x.price);          //price
                row.SubItems.Add(x.description);    //description
                row.SubItems.Add(x.info);           //information
                listViewProducts.Items.Add(row);
                if(!products.Contains(x))
                    products.Add(x);
            });
            
            imageList1.ImageSize = new Size(64, 64);
            listViewProducts.View = View.Details;
            listViewProducts.LargeImageList = imageList1;
        }

        private void listViewProducts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Products productToSend = new Products();
            Image img = null;
            foreach (ListViewItem seciliKayitBilgisi in listViewProducts.SelectedItems)
            {
                productToSend = products[seciliKayitBilgisi.Index];
                Database.Instance.GetProductsList.ForEach((x) => { 
                    if(x.name == productToSend.name)
                    {
                        img = Image.FromFile($"{imageFolder}{x.name}{x.imageExt}");
                        //return;
                    }
                });
            }
            if (detail.IsDisposed)
                detail = new FormProductDetail();
            detail.Set(img, productToSend);
            detail.item.Username = User.userName;
            detail.Show();
        }

        /// <summary>
        /// Card
        /// </summary>

        void UpdateCartToDatabase(CartItem i)
        {
            Database.Instance.CartItemList(imageFolder);
            Database.Instance.GetCartItemsList.ForEach((x) => {
                if (x.Product.name == i.Product.name && x.Username == User.userName)
                    Database.Instance.UpdateCartItem(i);
            });
            ReadCartItemsFromDatabase();
        }

        void DeleteCartFromDatabase(CartItem i)
        {
            Database.Instance.CartItemList(imageFolder);
            Database.Instance.GetCartItemsList.ForEach((x) => {
                if (x.Product.name == i.Product.name && x.Username == User.userName)
                    Database.Instance.DeleteCartItem(x);
            });
            ReadCartItemsFromDatabase();
        }

        public void DeleteCartBelongsToUserFromDatabase(Users user)
        {
            Database.Instance.CartItemList(imageFolder);
            Database.Instance.GetCartItemsList.ForEach((x) => {
                if (x.Username == user.userName)
                    Database.Instance.DeleteCartItem(x);
            });
            ReadCartItemsFromDatabase();
        }

        private void ReadCartItemsFromDatabase()
        {
            panelCart.Controls.Clear();
            int i = 0;
            Database.Instance.CartItemList(imageFolder);
            Database.Instance.GetCartItemsList.ForEach((x) => {
                if (x.Username == User.userName)
                {
                    i++;
                    CartItem cartItem = new CartItem();
                    cartItem.Set(Image.FromFile($"{imageFolder}{x.Product.name}{x.Product.imageExt}")
                        , x.Product, x.Count);
                    cartItem.Location = new Point(0, (i - 1) * 245);
                    panelCart.Controls.Add(cartItem);
                }
            });
        }

        public void AddToCart(CartItem item)
        {
            if (!Database.Instance.GetCartItemsList.Contains(item))
            {
                item.Username = User.userName;
                Database.Instance.AddCartItem(item);
                ReadCartItemsFromDatabase();
            }
        }

        public void UpdateCart(CartItem item)
        {
            if (Database.Instance.GetCartItemsList.Contains(item))
            {
                UpdateCartToDatabase(item);
            }
        }

        public void RemoveFromCart(CartItem item)
        {
            if (Database.Instance.GetCartItemsList.Contains(item))
            {
                DeleteCartFromDatabase(item);
            }
            else
            {
                MessageBox.Show("This Item is not on your Cart.");
                return;
            }
        }

        private void FormStore_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FormStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
