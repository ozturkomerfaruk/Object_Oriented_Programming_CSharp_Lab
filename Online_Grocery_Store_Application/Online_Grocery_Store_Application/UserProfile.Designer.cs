
namespace Online_Grocery_Store_Application
{
    partial class UserProfile
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
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.textBoxRegisterRePassword = new System.Windows.Forms.TextBox();
            this.labelRegisterRePassword = new System.Windows.Forms.Label();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonProfilePicture = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxRegisterAccountName = new System.Windows.Forms.TextBox();
            this.labelRegisterAccount = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.buttonDeleteProfile);
            this.panelRegister.Controls.Add(this.textBoxRegisterRePassword);
            this.panelRegister.Controls.Add(this.labelRegisterRePassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.labelRegisterPassword);
            this.panelRegister.Controls.Add(this.labelProfile);
            this.panelRegister.Controls.Add(this.pictureBoxProfile);
            this.panelRegister.Controls.Add(this.buttonProfilePicture);
            this.panelRegister.Controls.Add(this.buttonCancel);
            this.panelRegister.Controls.Add(this.buttonSave);
            this.panelRegister.Controls.Add(this.textBoxRegisterAccountName);
            this.panelRegister.Controls.Add(this.labelRegisterAccount);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(800, 319);
            this.panelRegister.TabIndex = 15;
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteProfile.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteProfile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDeleteProfile.Location = new System.Drawing.Point(577, 222);
            this.buttonDeleteProfile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(210, 36);
            this.buttonDeleteProfile.TabIndex = 15;
            this.buttonDeleteProfile.Text = "DELETE PROFILE";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            this.buttonDeleteProfile.MouseLeave += new System.EventHandler(this.buttonDeleteProfile_MouseLeave);
            this.buttonDeleteProfile.MouseHover += new System.EventHandler(this.buttonDeleteProfile_MouseHover);
            // 
            // textBoxRegisterRePassword
            // 
            this.textBoxRegisterRePassword.Location = new System.Drawing.Point(359, 175);
            this.textBoxRegisterRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegisterRePassword.Name = "textBoxRegisterRePassword";
            this.textBoxRegisterRePassword.Size = new System.Drawing.Size(428, 31);
            this.textBoxRegisterRePassword.TabIndex = 13;
            // 
            // labelRegisterRePassword
            // 
            this.labelRegisterRePassword.AutoSize = true;
            this.labelRegisterRePassword.Location = new System.Drawing.Point(236, 178);
            this.labelRegisterRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterRePassword.Name = "labelRegisterRePassword";
            this.labelRegisterRePassword.Size = new System.Drawing.Size(113, 25);
            this.labelRegisterRePassword.TabIndex = 14;
            this.labelRegisterRePassword.Text = "Re-Password";
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(359, 123);
            this.textBoxRegisterPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(428, 31);
            this.textBoxRegisterPassword.TabIndex = 11;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(264, 123);
            this.labelRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(87, 25);
            this.labelRegisterPassword.TabIndex = 12;
            this.labelRegisterPassword.Text = "Password";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProfile.Location = new System.Drawing.Point(483, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(136, 54);
            this.labelProfile.TabIndex = 10;
            this.labelProfile.Text = "Profile";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(215, 215);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 9;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonProfilePicture
            // 
            this.buttonProfilePicture.Location = new System.Drawing.Point(0, 222);
            this.buttonProfilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProfilePicture.Name = "buttonProfilePicture";
            this.buttonProfilePicture.Size = new System.Drawing.Size(215, 84);
            this.buttonProfilePicture.TabIndex = 4;
            this.buttonProfilePicture.Text = "Pick a Profile Picture";
            this.buttonProfilePicture.UseVisualStyleBackColor = true;
            this.buttonProfilePicture.Click += new System.EventHandler(this.buttonProfilePicture_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(577, 270);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(210, 36);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(359, 270);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(210, 36);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxRegisterAccountName
            // 
            this.textBoxRegisterAccountName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxRegisterAccountName.Location = new System.Drawing.Point(359, 67);
            this.textBoxRegisterAccountName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRegisterAccountName.Name = "textBoxRegisterAccountName";
            this.textBoxRegisterAccountName.ReadOnly = true;
            this.textBoxRegisterAccountName.Size = new System.Drawing.Size(428, 31);
            this.textBoxRegisterAccountName.TabIndex = 1;
            // 
            // labelRegisterAccount
            // 
            this.labelRegisterAccount.AutoSize = true;
            this.labelRegisterAccount.Location = new System.Drawing.Point(222, 67);
            this.labelRegisterAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegisterAccount.Name = "labelRegisterAccount";
            this.labelRegisterAccount.Size = new System.Drawing.Size(126, 25);
            this.labelRegisterAccount.TabIndex = 0;
            this.labelRegisterAccount.Text = "Account name";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.panelRegister);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserProfile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonProfilePicture;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxRegisterAccountName;
        private System.Windows.Forms.Label labelRegisterAccount;
        private System.Windows.Forms.TextBox textBoxRegisterRePassword;
        private System.Windows.Forms.Label labelRegisterRePassword;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Button buttonDeleteProfile;
    }
}