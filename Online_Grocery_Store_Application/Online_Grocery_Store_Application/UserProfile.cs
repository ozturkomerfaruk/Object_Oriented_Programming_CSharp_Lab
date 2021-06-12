using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    public partial class UserProfile : Form
    {
        private static UserProfile instance = null;
        public static UserProfile Instance
        {
            get
            {
                if (instance is null || instance.IsDisposed) instance = new UserProfile();
                return instance;
            }
        }
        public Users User { get; set; }
        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            pictureBoxProfile.Image = User.ProfileImage;
            textBoxRegisterAccountName.Text = User.userName;
            textBoxRegisterPassword.Text = User.password;
        }

        private void buttonProfilePicture_Click(object sender, EventArgs e)
        {
            FormLogin.SelectProfilePicture(ref this.pictureBoxProfile);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxRegisterPassword.Text == textBoxRegisterRePassword.Text)
            {
                User.ProfileImage = pictureBoxProfile.Image;
                User.password = textBoxRegisterPassword.Text;
                Database.Instance.UpdateUsers(User);
                FormStore.Instance.User = User;
                MessageBox.Show("Successfully Saved", "Warning");
                Thread.Sleep(3000);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("There are some issues. Check them please.", "Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonDeleteProfile_MouseHover(object sender, EventArgs e)
        {
            buttonDeleteProfile.BackColor = Color.Green;
        }

        private void buttonDeleteProfile_MouseLeave(object sender, EventArgs e)
        {
            buttonDeleteProfile.BackColor = Color.Firebrick;
        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Continue Delete Your Account?", "Warning", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                //if(File.Exists(Database.Instance.profilePicturesFolder + User.userName + User.ProfileImageExt))
                //    File.Delete(Database.Instance.profilePicturesFolder + User.userName + User.ProfileImageExt);
                FormStore.Instance.DeleteCartBelongsToUserFromDatabase(User);
                Database.Instance.DeleteUsers(User);
                Thread.Sleep(3000);
                FormLogin.Instance.Show();
                FormStore.Instance.Dispose();
                this.Dispose();
            }
        }
    }
}
