using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    public class Users
    {
        public int priorityKey; //0 Customer 1 Admin
        public string userName { get; set; }
        public string password { get; set; }
        public Image ProfileImage { get; set; }
        public string ProfileImageExt { get; set; }
        public Form Access
        {
            get
            {
                Form form = null;
                if (priorityKey == 0)
                {
                    FormStore.Instance.User = this;
                    form = FormStore.Instance;
                }
                else
                {
                    FormProduct.Instance.User = this;
                    form = FormProduct.Instance;
                }
                return form;
            }
        }

        public Users(int _key = 0)
        {
            priorityKey = _key;
        }
    }
}
