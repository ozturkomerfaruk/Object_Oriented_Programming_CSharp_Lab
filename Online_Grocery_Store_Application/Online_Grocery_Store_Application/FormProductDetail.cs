using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    public partial class FormProductDetail : Form
    {
        public CartItem item = new CartItem();
        public FormProductDetail()
        {
            InitializeComponent();
        }

        public void Set(Image img, Products product)
        {
            pictureBoxProductImage.Image = img;
            lblProductName.Text = product.name;
            lblProductPrice.Text = product.price;
            lblProductDescription.Text = product.description;
            lblProductInfo.Text = product.info;
            item.Count = int.Parse(lblPDetailCount.Text);
            item.Product = product;
        }

        private void btnAddToCard_Click(object sender, EventArgs e)
        {
            item.Count = int.Parse(lblPDetailCount.Text);
            FormStore.Instance.AddToCart(item);
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {

        }

        int ProductCounter = 1;

        private void buttonPDetailPlus_Click(object sender, EventArgs e)
        {
            ProductCounter++;
            lblPDetailCount.Text = ProductCounter.ToString();
        }

        private void buttonPDetailMinus_Click(object sender, EventArgs e)
        {
            ProductCounter = ProductCounter == 0 ? ProductCounter : ProductCounter - 1;
            lblPDetailCount.Text = ProductCounter.ToString();
        }
    }
}
