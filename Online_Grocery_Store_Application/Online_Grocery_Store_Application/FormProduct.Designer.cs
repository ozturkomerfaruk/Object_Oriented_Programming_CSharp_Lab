
namespace Online_Grocery_Store_Application
{
    partial class FormProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeaderImage = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderInfo = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxProductDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxProductInformation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(142, 695);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 38);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 738);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImage,
            this.ColumnHeaderName,
            this.ColumnHeaderPrice,
            this.ColumnHeaderDescription,
            this.ColumnHeaderInfo});
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewProducts.Location = new System.Drawing.Point(316, 18);
            this.listViewProducts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(808, 779);
            this.listViewProducts.SmallImageList = this.imageList1;
            this.listViewProducts.TabIndex = 4;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderImage
            // 
            this.columnHeaderImage.Text = "Image";
            this.columnHeaderImage.Width = 120;
            // 
            // ColumnHeaderName
            // 
            this.ColumnHeaderName.Text = "Name";
            this.ColumnHeaderName.Width = 160;
            // 
            // ColumnHeaderPrice
            // 
            this.ColumnHeaderPrice.Text = "Price";
            this.ColumnHeaderPrice.Width = 120;
            // 
            // ColumnHeaderDescription
            // 
            this.ColumnHeaderDescription.Text = "Description";
            this.ColumnHeaderDescription.Width = 120;
            // 
            // ColumnHeaderInfo
            // 
            this.ColumnHeaderInfo.Text = "Information";
            this.ColumnHeaderInfo.Width = 120;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Acı Sos.jpg");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 695);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(15, 34);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(126, 25);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxProductName.Location = new System.Drawing.Point(18, 61);
            this.txtBoxProductName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(242, 31);
            this.txtBoxProductName.TabIndex = 7;
            // 
            // txtBoxProductPrice
            // 
            this.txtBoxProductPrice.Location = new System.Drawing.Point(18, 135);
            this.txtBoxProductPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxProductPrice.Name = "txtBoxProductPrice";
            this.txtBoxProductPrice.Size = new System.Drawing.Size(242, 31);
            this.txtBoxProductPrice.TabIndex = 11;
            this.txtBoxProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxProductPrice_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product Price";
            // 
            // txtBoxProductDescription
            // 
            this.txtBoxProductDescription.Location = new System.Drawing.Point(18, 215);
            this.txtBoxProductDescription.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxProductDescription.Name = "txtBoxProductDescription";
            this.txtBoxProductDescription.Size = new System.Drawing.Size(242, 31);
            this.txtBoxProductDescription.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product  Description";
            // 
            // txtBoxProductInformation
            // 
            this.txtBoxProductInformation.Location = new System.Drawing.Point(18, 305);
            this.txtBoxProductInformation.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBoxProductInformation.Name = "txtBoxProductInformation";
            this.txtBoxProductInformation.Size = new System.Drawing.Size(242, 31);
            this.txtBoxProductInformation.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product  Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Product Image";
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(19, 395);
            this.pictureBoxProductImage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(241, 232);
            this.pictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductImage.TabIndex = 17;
            this.pictureBoxProductImage.TabStop = false;
            this.pictureBoxProductImage.Click += new System.EventHandler(this.pictureBoxProductImage_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(142, 738);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(118, 38);
            this.btnSelect.TabIndex = 19;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1152, 822);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.pictureBoxProductImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxProductInformation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxProductDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxProductPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProduct_FormClosed);
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader ColumnHeaderName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader image;
        private System.Windows.Forms.ColumnHeader rastgele;
        private System.Windows.Forms.ColumnHeader ColumnHeaderPrice;
        private System.Windows.Forms.ColumnHeader ColumnHeaderDescription;
        private System.Windows.Forms.ColumnHeader ColumnHeaderInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.TextBox txtBoxProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxProductDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxProductInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ImageList imageList1;
    }
}

