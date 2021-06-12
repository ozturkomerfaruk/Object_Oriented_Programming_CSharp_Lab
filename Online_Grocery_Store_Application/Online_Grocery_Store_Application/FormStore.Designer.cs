
namespace Online_Grocery_Store_Application
{
    partial class FormStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStore));
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnHeaderImage = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderName = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeaderPrice = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.panelCart = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabStore.SuspendLayout();
            this.tabCart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderImage,
            this.ColumnHeaderName,
            this.ColumnHeaderPrice});
            this.listViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewProducts.LargeImageList = this.imageList1;
            this.listViewProducts.Location = new System.Drawing.Point(3, 3);
            this.listViewProducts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(1016, 530);
            this.listViewProducts.SmallImageList = this.imageList1;
            this.listViewProducts.TabIndex = 5;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewProducts_MouseDoubleClick);
            // 
            // columnHeaderImage
            // 
            this.columnHeaderImage.Text = "Image";
            this.columnHeaderImage.Width = 120;
            // 
            // ColumnHeaderName
            // 
            this.ColumnHeaderName.Text = "Name";
            this.ColumnHeaderName.Width = 200;
            // 
            // ColumnHeaderPrice
            // 
            this.ColumnHeaderPrice.Text = "Price";
            this.ColumnHeaderPrice.Width = 200;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Acı Sos.jpg");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStore);
            this.tabControl1.Controls.Add(this.tabCart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 101);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 574);
            this.tabControl1.TabIndex = 6;
            // 
            // tabStore
            // 
            this.tabStore.Controls.Add(this.listViewProducts);
            this.tabStore.Location = new System.Drawing.Point(4, 34);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(3);
            this.tabStore.Size = new System.Drawing.Size(1022, 536);
            this.tabStore.TabIndex = 0;
            this.tabStore.Text = "Store";
            this.tabStore.UseVisualStyleBackColor = true;
            // 
            // tabCart
            // 
            this.tabCart.Controls.Add(this.panelCart);
            this.tabCart.Location = new System.Drawing.Point(4, 34);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(1022, 536);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // panelCart
            // 
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCart.Location = new System.Drawing.Point(3, 3);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(1016, 530);
            this.panelCart.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 109);
            this.panel1.TabIndex = 7;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(879, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(151, 60);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "label1";
            // 
            // FormStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1030, 675);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStore";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStore_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStore_FormClosed);
            this.Load += new System.EventHandler(this.FormStore_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStore.ResumeLayout(false);
            this.tabCart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnHeaderImage;
        private System.Windows.Forms.ColumnHeader ColumnHeaderName;
        private System.Windows.Forms.ColumnHeader ColumnHeaderPrice;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStore;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsername;
    }
}