
namespace Online_Grocery_Store_Application
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonCreateANewAccount = new System.Windows.Forms.Button();
            this.labelNewAccount = new System.Windows.Forms.Label();
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonProfilePicture = new System.Windows.Forms.Button();
            this.textBoxRegisterRePassword = new System.Windows.Forms.TextBox();
            this.labelRegisterRePassword = new System.Windows.Forms.Label();
            this.buttonRegisterCancel = new System.Windows.Forms.Button();
            this.buttonRegisterSignUp = new System.Windows.Forms.Button();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.textBoxRegisterAccountName = new System.Windows.Forms.TextBox();
            this.labelRegisterAccount = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogIn.SuspendLayout();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateANewAccount
            // 
            this.buttonCreateANewAccount.Location = new System.Drawing.Point(324, 196);
            this.buttonCreateANewAccount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateANewAccount.Name = "buttonCreateANewAccount";
            this.buttonCreateANewAccount.Size = new System.Drawing.Size(350, 36);
            this.buttonCreateANewAccount.TabIndex = 12;
            this.buttonCreateANewAccount.Text = "CREATE A NEW ACCOUNT...";
            this.buttonCreateANewAccount.UseVisualStyleBackColor = true;
            this.buttonCreateANewAccount.Click += new System.EventHandler(this.buttonCreateANewAccount_Click);
            // 
            // labelNewAccount
            // 
            this.labelNewAccount.AutoSize = true;
            this.labelNewAccount.Location = new System.Drawing.Point(11, 201);
            this.labelNewAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewAccount.Name = "labelNewAccount";
            this.labelNewAccount.Size = new System.Drawing.Size(294, 25);
            this.labelNewAccount.TabIndex = 13;
            this.labelNewAccount.Text = "Don\'t have a Grocery Store Account";
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.labelNewAccount);
            this.panelLogIn.Controls.Add(this.buttonCreateANewAccount);
            this.panelLogIn.Controls.Add(this.buttonCancel);
            this.panelLogIn.Controls.Add(this.buttonLogIn);
            this.panelLogIn.Controls.Add(this.textBoxPassword);
            this.panelLogIn.Controls.Add(this.labelPassword);
            this.panelLogIn.Controls.Add(this.textBoxAccountName);
            this.panelLogIn.Controls.Add(this.labelAccountName);
            this.panelLogIn.Location = new System.Drawing.Point(14, 150);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(768, 266);
            this.panelLogIn.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(426, 140);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(248, 36);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(174, 140);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(248, 36);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "LOGIN";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(174, 84);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(498, 31);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(54, 84);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(87, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(174, 24);
            this.textBoxAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(498, 31);
            this.textBoxAccountName.TabIndex = 1;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(11, 26);
            this.labelAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(126, 25);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "Account name";
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.pictureBoxProfile);
            this.panelRegister.Controls.Add(this.buttonProfilePicture);
            this.panelRegister.Controls.Add(this.textBoxRegisterRePassword);
            this.panelRegister.Controls.Add(this.labelRegisterRePassword);
            this.panelRegister.Controls.Add(this.buttonRegisterCancel);
            this.panelRegister.Controls.Add(this.buttonRegisterSignUp);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.labelRegisterPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterAccountName);
            this.panelRegister.Controls.Add(this.labelRegisterAccount);
            this.panelRegister.Location = new System.Drawing.Point(14, 150);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(766, 266);
            this.panelRegister.TabIndex = 14;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxProfile.Location = new System.Drawing.Point(602, 8);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(164, 109);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 9;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonProfilePicture
            // 
            this.buttonProfilePicture.Location = new System.Drawing.Point(603, 135);
            this.buttonProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProfilePicture.Name = "buttonProfilePicture";
            this.buttonProfilePicture.Size = new System.Drawing.Size(163, 102);
            this.buttonProfilePicture.TabIndex = 4;
            this.buttonProfilePicture.Text = "Pick a Profile Picture";
            this.buttonProfilePicture.UseVisualStyleBackColor = true;
            this.buttonProfilePicture.Click += new System.EventHandler(this.buttonProfilePicture_Click);
            // 
            // textBoxRegisterRePassword
            // 
            this.textBoxRegisterRePassword.Location = new System.Drawing.Point(167, 138);
            this.textBoxRegisterRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegisterRePassword.Name = "textBoxRegisterRePassword";
            this.textBoxRegisterRePassword.Size = new System.Drawing.Size(428, 31);
            this.textBoxRegisterRePassword.TabIndex = 3;
            // 
            // labelRegisterRePassword
            // 
            this.labelRegisterRePassword.AutoSize = true;
            this.labelRegisterRePassword.Location = new System.Drawing.Point(44, 141);
            this.labelRegisterRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterRePassword.Name = "labelRegisterRePassword";
            this.labelRegisterRePassword.Size = new System.Drawing.Size(113, 25);
            this.labelRegisterRePassword.TabIndex = 6;
            this.labelRegisterRePassword.Text = "Re-Password";
            // 
            // buttonRegisterCancel
            // 
            this.buttonRegisterCancel.Location = new System.Drawing.Point(385, 201);
            this.buttonRegisterCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegisterCancel.Name = "buttonRegisterCancel";
            this.buttonRegisterCancel.Size = new System.Drawing.Size(210, 36);
            this.buttonRegisterCancel.TabIndex = 6;
            this.buttonRegisterCancel.Text = "CANCEL";
            this.buttonRegisterCancel.UseVisualStyleBackColor = true;
            this.buttonRegisterCancel.Click += new System.EventHandler(this.buttonRegisterCancel_Click);
            // 
            // buttonRegisterSignUp
            // 
            this.buttonRegisterSignUp.Location = new System.Drawing.Point(167, 201);
            this.buttonRegisterSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegisterSignUp.Name = "buttonRegisterSignUp";
            this.buttonRegisterSignUp.Size = new System.Drawing.Size(210, 36);
            this.buttonRegisterSignUp.TabIndex = 5;
            this.buttonRegisterSignUp.Text = "SIGN UP";
            this.buttonRegisterSignUp.UseVisualStyleBackColor = true;
            this.buttonRegisterSignUp.Click += new System.EventHandler(this.buttonRegisterSignUp_Click);
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(167, 86);
            this.textBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(428, 31);
            this.textBoxRegisterPassword.TabIndex = 2;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(72, 86);
            this.labelRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(87, 25);
            this.labelRegisterPassword.TabIndex = 2;
            this.labelRegisterPassword.Text = "Password";
            // 
            // textBoxRegisterAccountName
            // 
            this.textBoxRegisterAccountName.Location = new System.Drawing.Point(167, 26);
            this.textBoxRegisterAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegisterAccountName.Name = "textBoxRegisterAccountName";
            this.textBoxRegisterAccountName.Size = new System.Drawing.Size(428, 31);
            this.textBoxRegisterAccountName.TabIndex = 1;
            // 
            // labelRegisterAccount
            // 
            this.labelRegisterAccount.AutoSize = true;
            this.labelRegisterAccount.Location = new System.Drawing.Point(30, 26);
            this.labelRegisterAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterAccount.Name = "labelRegisterAccount";
            this.labelRegisterAccount.Size = new System.Drawing.Size(126, 25);
            this.labelRegisterAccount.TabIndex = 0;
            this.labelRegisterAccount.Text = "Account name";
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 31F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogo.Location = new System.Drawing.Point(244, 20);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(362, 126);
            this.labelLogo.TabIndex = 10;
            this.labelLogo.Text = "Grocery 26";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(14, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(191, 126);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(798, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogIn);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelRegister);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateANewAccount;
        private System.Windows.Forms.Label labelNewAccount;
        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.TextBox textBoxRegisterRePassword;
        private System.Windows.Forms.Label labelRegisterRePassword;
        private System.Windows.Forms.Button buttonRegisterCancel;
        private System.Windows.Forms.Button buttonRegisterSignUp;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterAccountName;
        private System.Windows.Forms.Label labelRegisterAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonProfilePicture;
    }
}