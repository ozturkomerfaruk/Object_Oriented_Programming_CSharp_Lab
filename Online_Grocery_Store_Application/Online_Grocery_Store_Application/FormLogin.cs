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
    public partial class FormLogin : Form
    {
        private static FormLogin instance = null;
        public static FormLogin Instance
        {
            get
            {
                if (instance is null || instance.IsDisposed) instance = new FormLogin();
                return instance;
            }
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        string profilePicturesFolder = @".\ProfilePictures\";
        Database db = Database.Instance;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ReadUsersFromDatabase();
            panelRegister.Visible = false;
        }

        private void buttonRegisterSignUp_Click(object sender, EventArgs e)
        {
            Register(0);
            //ReadUsers();
            ReadUsersFromDatabase();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            foreach (Users item in db.GetUsersList)
            {
                if (item.userName == textBoxAccountName.Text && item.password == textBoxPassword.Text)
                {
                    item.Access.Show();
                    this.Hide();
                    break;
                }
            }
        }

        private void buttonCreateANewAccount_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            panelLogIn.Visible = false;
        }

        private void buttonRegisterCancel_Click(object sender, EventArgs e)
        {
            DialogResult resultRegisterDialog = MessageBox.Show("Want to Exit the Registration Screen?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultRegisterDialog == DialogResult.Yes)
            {
                panelRegister.Visible = false;
                panelLogIn.Visible = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Do You Want to Exit the Program?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultDialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        void Register(int _key)
        {
            bool usernameControl = true;

            db.UsersList();

            foreach (Users _user in db.GetUsersList)
            {
                if (_user.userName == textBoxRegisterAccountName.Text)
                {
                    usernameControl = false;
                }
            }

            if (textBoxRegisterAccountName.Text == "" && textBoxRegisterRePassword.Text == "")
            {
                DialogResult result = MessageBox.Show("Password and username must be filled.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    panelLogIn.Visible = false;
                    panelRegister.Visible = true;
                }
            }
            else if (textBoxRegisterAccountName.Text == "" && textBoxRegisterRePassword.Text != "")
            {
                DialogResult result = MessageBox.Show("Username must be filled.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    panelLogIn.Visible = false;
                    panelRegister.Visible = true;
                }
            }
            else if (textBoxRegisterAccountName.Text != "" && textBoxRegisterRePassword.Text == "")
            {
                DialogResult result = MessageBox.Show("Password must be filled.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    panelLogIn.Visible = false;
                    panelRegister.Visible = true;
                }
            }
            else
            {
                if (textBoxRegisterPassword.Text == textBoxRegisterRePassword.Text)
                {
                    if (usernameControl)
                    {
                        string ext = Path.GetExtension(pictureBoxProfile.ImageLocation);
                        Users user = new Users(_key);
                        user.userName = textBoxRegisterAccountName.Text;
                        user.password = textBoxRegisterPassword.Text;
                        user.ProfileImage = pictureBoxProfile.Image;
                        user.ProfileImageExt = ext;
                        panelLogIn.Visible = true;
                        panelRegister.Visible = false;
                        db.AddUsers(user);
                        FormLogin.WritePicture(profilePicturesFolder, pictureBoxProfile.ImageLocation, user.userName + ext);
                    }
                    else
                    {
                        MessageBox.Show("Username is already taken. Change your username for signing.");
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Passwords do not match.!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        panelLogIn.Visible = false;
                        panelRegister.Visible = true;
                    }
                }
            }
        }

        public static void WritePicture(string folder, string imageSource, string imageName)
        {
            string destination = $"{folder}{imageName}";

            //if (File.Exists(destination))
            //    File.Delete(destination);
            File.Copy(imageSource, destination, true);
        }

        void ReadUsersFromDatabase()
        {
            db.UsersList();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonProfilePicture_Click(object sender, EventArgs e)
        {
            SelectProfilePicture(ref this.pictureBoxProfile);
        }
        public static void SelectProfilePicture(ref PictureBox pb)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyası |*.jpg;*.png| Tüm Dosyalar |*.*";
            openFileDialog.Title = "Grocery Store Profile Picture";
            DialogResult res = openFileDialog.ShowDialog();
            pb.ImageLocation = res == DialogResult.OK ? openFileDialog.FileName : null;
        }
    }
}
