using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Online_Grocery_Store_Application
{
    class DatabaseConnection
    {
        public SqlConnection Connect { get; set; }  
        public void Connection()
        {
            var connectionASPString = @"Data Source=SQL5063.site4now.net;Initial Catalog=db_a759a5_mehmetleap;User Id=db_a759a5_mehmetleap_admin;Password=database98";
            Connect = new SqlConnection(connectionASPString);
        }
        
        public void Open()
        {
            Connect.Open();
        }
        
        public void Close()
        {
            Connect.Close();
        }
    }
}
