using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    public partial class FormProduct : Form
    {
        private static FormProduct instance = null;
        public static FormProduct Instance
        {
            get
            {
                if (instance is null || instance.IsDisposed) instance = new FormProduct();
                return instance;
            }
        }
        public Users User { get; set; }
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            ClearTextControl();
            listViewProducts.Items.Clear();
            ReadProductFromDatabase();
        }
        string imageFolder = @".\Images\";

        private void pictureBoxProductImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyası |*.jpg;*.png| Tüm Dosyalar |*.*";
            openFileDialog.Title = "Grocery Store";
            DialogResult res = openFileDialog.ShowDialog();
            pictureBoxProductImage.ImageLocation = res == DialogResult.OK ? openFileDialog.FileName : null;
        }
        void UpdateProductToDatabase(Products p, string name)
        {
            Database.Instance.ProductList();
            Database.Instance.GetProductsList.ForEach((x) =>
            {
                if (x.name == name)
                    Database.Instance.UpdateProduct(p);
            });
        }
        void DeleteProductFromDatabase(string name)
        {
            Database.Instance.ProductList();
            Database.Instance.GetProductsList.ForEach((x) =>
            {
                if (x.name == name)
                {
                    Database.Instance.DeleteProduct(x);
                    File.Delete(imageFolder + x.name + x.imageExt);
                }
            });
        }
        void ReadProductFromDatabase()
        {
            Database.Instance.ProductList();
            Database.Instance.GetProductsList.ForEach((x) =>
            {
                ListViewItem row = new ListViewItem();
                imageList1.Images.Add($"{x.name}{x.imageExt}",
                        Image.FromFile($"{imageFolder}{x.name}{x.imageExt}"));
                row.ImageKey = $"{x.name}{x.imageExt}";   //imageDest
                row.SubItems.Add(x.name);                 //name
                row.SubItems.Add(x.price);                //price
                row.SubItems.Add(x.description);          //description
                row.SubItems.Add(x.info);                 //information
               
                if(!listViewProducts.Items.Contains(row)) 
                    listViewProducts.Items.Add(row);
            });

            imageList1.ImageSize = new Size(64, 64);
            listViewProducts.View = View.Details;
            listViewProducts.LargeImageList = imageList1;
        }

        void ClearTextControl()
        {
            txtBoxProductName.Text = "";
            txtBoxProductPrice.Text = "";
            txtBoxProductDescription.Text = "";
            txtBoxProductInformation.Text = "";
            pictureBoxProductImage.ImageLocation = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pictureBoxProductImage.ImageLocation is null)
            {
                Console.WriteLine($"Image Location:'{pictureBoxProductImage.ImageLocation}' is empty!");
                return;
            }
            string ext = Path.GetExtension(pictureBoxProductImage.ImageLocation);
            string name = txtBoxProductName.Text + ext;
            Products product = new Products();
            product.name = txtBoxProductName.Text;
            product.price = txtBoxProductPrice.Text;
            product.description = txtBoxProductDescription.Text;
            product.info = txtBoxProductInformation.Text;
            product.imageExt = ext;
            FormLogin.WritePicture(imageFolder,pictureBoxProductImage.ImageLocation, name);
            Database.Instance.AddProduct(product);
            ClearTextControl();
            ReadProductFromDatabase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str="";
            foreach (ListViewItem seciliKayitBilgisi in listViewProducts.SelectedItems) //dizinin eleman sayısı kadar dönme
            {
                str = seciliKayitBilgisi.SubItems[1].Text;
                seciliKayitBilgisi.Remove();
            }
            DeleteProductFromDatabase(str);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (pictureBoxProductImage.ImageLocation is null)
            {
                Console.WriteLine($"Image Location:'{pictureBoxProductImage.ImageLocation}' is empty!");
                return;
            }
            string ext = Path.GetExtension(pictureBoxProductImage.ImageLocation);
            string name = txtBoxProductName.Text + ext;
            Products product = new Products();
            product.name = txtBoxProductName.Text;
            product.price = txtBoxProductPrice.Text;
            product.description = txtBoxProductDescription.Text;
            product.info = txtBoxProductInformation.Text;
            product.imageExt = ext;
            UpdateProductToDatabase(product, txtBoxProductName.Text);
            FormLogin.WritePicture(imageFolder, pictureBoxProductImage.ImageLocation, name);
            ClearTextControl();
            ReadProductFromDatabase();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            bool arananKayitKontrolu = false;
            for (int i = 0; i < listViewProducts.Items.Count; i++)
            {
                if (listViewProducts.Items[i].SubItems[1].Text == txtBoxProductName.Text)
                {
                    arananKayitKontrolu = true;
                    txtBoxProductPrice.Text = listViewProducts.Items[i].SubItems[2].Text;
                    txtBoxProductDescription.Text = listViewProducts.Items[i].SubItems[3].Text;
                    txtBoxProductInformation.Text = listViewProducts.Items[i].SubItems[4].Text;
                    pictureBoxProductImage.ImageLocation = null;
                }
            }
            if (!arananKayitKontrolu)
            {
                MessageBox.Show("The requested name was not found!");
            }
        }
        private void txtBoxProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.Instance.Show();
            this.Dispose();
        }
    }
}
