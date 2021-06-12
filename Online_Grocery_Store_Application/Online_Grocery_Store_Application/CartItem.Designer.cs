
namespace Online_Grocery_Store_Application
{
    partial class CartItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.btnRemoveFromCard = new System.Windows.Forms.Button();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveFromCard
            // 
            this.btnRemoveFromCard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveFromCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCard.BackgroundImage")));
            this.btnRemoveFromCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFromCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveFromCard.Location = new System.Drawing.Point(530, 87);
            this.btnRemoveFromCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFromCard.Name = "btnRemoveFromCard";
            this.btnRemoveFromCard.Size = new System.Drawing.Size(174, 54);
            this.btnRemoveFromCard.TabIndex = 37;
            this.btnRemoveFromCard.UseVisualStyleBackColor = false;
            this.btnRemoveFromCard.Click += new System.EventHandler(this.btnRemoveFromCard_Click);
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductInfo.Location = new System.Drawing.Point(198, 87);
            this.lblProductInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(37, 21);
            this.lblProductInfo.TabIndex = 32;
            this.lblProductInfo.Text = "Info";
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoSize = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductDescription.Location = new System.Drawing.Point(198, 58);
            this.lblProductDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(89, 21);
            this.lblProductDescription.TabIndex = 31;
            this.lblProductDescription.Text = "Description";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductPrice.Location = new System.Drawing.Point(610, 20);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(23, 21);
            this.lblProductPrice.TabIndex = 30;
            this.lblProductPrice.Text = "0 ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(198, 10);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(64, 25);
            this.lblProductName.TabIndex = 29;
            this.lblProductName.Text = "Name";
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProductImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(169, 140);
            this.pictureBoxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProductImage.TabIndex = 28;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlus.BackgroundImage")));
            this.buttonPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlus.Location = new System.Drawing.Point(661, 55);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(44, 34);
            this.buttonPlus.TabIndex = 38;
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinus.BackgroundImage")));
            this.buttonMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinus.Location = new System.Drawing.Point(530, 55);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(44, 34);
            this.buttonMinus.TabIndex = 39;
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(610, 59);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(23, 28);
            this.lblCount.TabIndex = 40;
            this.lblCount.Text = "0";
          
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat.Location = new System.Drawing.Point(530, 20);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(43, 21);
            this.lblFiyat.TabIndex = 41;
            this.lblFiyat.Text = "Fiyat";
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.btnRemoveFromCard);
            this.Controls.Add(this.lblProductInfo);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pictureBoxProductImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(711, 146);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveFromCard;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.Label lblProductDescription;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox pictureBoxProductImage;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFiyat;
    }
}
