using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    public partial class CartItem : UserControl
    {
        public string Username { get; set; }
        public int Count { get; set;  }
        public Products Product { get; set; }

        public Image Img { get; set; }

        public CartItem()
        {
            InitializeComponent();
            Count = 0;
        }
        public void Set(Image img, Products product, int count)
        {
            pictureBoxProductImage.Image = img;
            lblProductName.Text = product.name;
            lblProductPrice.Text = (int.Parse(product.price)*count).ToString();
            lblProductDescription.Text = product.description;
            lblProductInfo.Text = product.info;
            lblCount.Text = count.ToString();
            Count = count;
            Img = img;
            Product = product;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Count++;
            lblCount.Text = Count.ToString();
            FormStore.Instance.UpdateCart(this);
            lblProductPrice.Text = (int.Parse(Product.price) * Count).ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Count = Count == 0 ? Count : Count - 1;
            lblCount.Text = Count.ToString();
            FormStore.Instance.UpdateCart(this);
            lblProductPrice.Text = (int.Parse(Product.price) * Count).ToString();
        }

        private void btnRemoveFromCard_Click(object sender, EventArgs e)
        {
            FormStore.Instance.RemoveFromCart(this);
        }


    }
}
