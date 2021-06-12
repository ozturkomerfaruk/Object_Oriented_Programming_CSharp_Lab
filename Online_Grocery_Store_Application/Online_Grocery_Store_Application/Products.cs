using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Grocery_Store_Application
{
    public class Products
    {
        public string name;
        public string price;
        public string description;
        public string info;
        public string imageExt;

        public Products(string _name = "", string _price = "", string _description = "", string _info = "", string _imageExt = "")
        {
            name = _name;
            price = _price;
            description = _description;
            info = _info;
            imageExt = _imageExt;
        }
    }
}
