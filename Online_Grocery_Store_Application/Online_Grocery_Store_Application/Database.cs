using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Online_Grocery_Store_Application
{
    class Database
    {
        //Singleton
        private static Database instance;
        public static Database Instance
        {
            get
            {
                if (instance is null) instance = new Database();
                return instance;
            }
            set => instance = value;
        }
        public string profilePicturesFolder = @".\ProfilePictures\";

        public Database() { }

        //---------------------------------------------------------------------------

        private DatabaseConnection connection = new DatabaseConnection();

        //---------------------------------------------------------------------------

        private DataTable UsersTable = new DataTable();
        private Users user;
        private List<Users> users = new List<Users>();
        public List<Users> GetUsersList { get => users; }

        private DataTable ProductsTable = new DataTable();
        private Products product;
        private List<Products> products = new List<Products>();
        public List<Products> GetProductsList { get => products; }

        private DataTable CartItemTable = new DataTable();
        private CartItem cartItem;
        private List<CartItem> cartItems = new List<CartItem>();
        public List<CartItem> GetCartItemsList { get => cartItems; }

        //---------------------------------------------------------------------------

        public void AddUsers(Users user)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into UsersTbl(UsersUsername,UsersPassword,UsersPriorityKey,UsersExt)values (@Username,@Password,@PriorityKey,@Ext)", connection.Connect);
                command.Parameters.AddWithValue("@Username", user.userName);
                command.Parameters.AddWithValue("@Password", user.password);
                command.Parameters.AddWithValue("@PriorityKey", user.priorityKey);
                command.Parameters.AddWithValue("@Ext", user.ProfileImageExt);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration has been successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateUsers(Users user)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update UsersTbl set UsersPassword=@Password,UsersPriorityKey=@PriorityKey,UsersExt=@Ext where UsersUsername=@Username", connection.Connect);
                command.Parameters.AddWithValue("@Username", user.userName);
                command.Parameters.AddWithValue("@Password", user.password);
                command.Parameters.AddWithValue("@PriorityKey", user.priorityKey);
                command.Parameters.AddWithValue("@Ext", user.ProfileImageExt);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The registration has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteUsers(Users user)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from UsersTbl where UsersUsername=@Username", connection.Connect);
                command.Parameters.AddWithValue("@Username", user.userName);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The customer has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UsersList()
        {
            try
            {
                UsersTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * From UsersTbl", connection.Connect);
                dataBase.Fill(UsersTable);
                connection.Close();
                for (int i = 0; i < UsersTable.Rows.Count; i++)
                {
                    user = new Users(int.Parse(UsersTable.Rows[i]["UsersPriorityKey"].ToString()));
                    user.userName = UsersTable.Rows[i]["UsersUsername"].ToString();
                    user.password = UsersTable.Rows[i]["UsersPassword"].ToString();
                    user.ProfileImageExt = UsersTable.Rows[i]["UsersExt"].ToString();
                    user.ProfileImage = Image.FromFile(profilePicturesFolder + user.userName + user.ProfileImageExt);
                    users.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //---------------------------------------------------------------------------

        public void AddProduct(Products product)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into ProductTbl(ProductName,ProductPrice,ProductDescription,ProductInformation,ProductImageExt) values(@Name,@Price,@Description,@Information,@ImageExt)", connection.Connect);
                command.Parameters.AddWithValue("@Name", product.name);
                command.Parameters.AddWithValue("@Price", product.price);
                command.Parameters.AddWithValue("@Description", product.description);
                command.Parameters.AddWithValue("@Information", product.info);
                command.Parameters.AddWithValue("@ImageExt", product.imageExt);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The product has been successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateProduct(Products product)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update ProductTbl set ProductPrice=@Price,ProductDescription=@Description,ProductInformation=@Information,ProductImageExt=@ImageExt where ProductName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", product.name);
                command.Parameters.AddWithValue("@Price", product.price);
                command.Parameters.AddWithValue("@Description", product.description);
                command.Parameters.AddWithValue("@Information", product.info);
                command.Parameters.AddWithValue("@ImageExt", product.imageExt);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The product has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteProduct(Products product)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from ProductTbl where ProductName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", product.name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The product has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ProductList()
        {
            try
            {
                ProductsTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * from ProductTbl", connection.Connect);
                dataBase.Fill(ProductsTable);
                connection.Close();
                for (int i = 0; i < ProductsTable.Rows.Count; i++)
                {
                    product = new Products(
                        ProductsTable.Rows[i]["ProductName"].ToString(),
                        ProductsTable.Rows[i]["ProductPrice"].ToString(),
                        ProductsTable.Rows[i]["ProductDescription"].ToString(),
                        ProductsTable.Rows[i]["ProductInformation"].ToString(),
                        ProductsTable.Rows[i]["ProductImageExt"].ToString());
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //------------------------------

        public void AddCartItem(CartItem cartItem)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into ShoppingCartTbl(ShoppingCartName,ShoppingCartPrice,ShoppingCartDescription,ShoppingCartInformation,ShoppingCartCount,ShoppingCartImageExt,ShoppingCartUsername) values(@Name,@Price,@Description,@Information,@Count,@ImageExt,@Username)", connection.Connect);
                command.Parameters.AddWithValue("@Name", cartItem.Product.name);
                command.Parameters.AddWithValue("@Price", cartItem.Product.price);
                command.Parameters.AddWithValue("@Description", cartItem.Product.description);
                command.Parameters.AddWithValue("@Information", cartItem.Product.info);
                command.Parameters.AddWithValue("@Count", cartItem.Count);
                command.Parameters.AddWithValue("@ImageExt", cartItem.Product.imageExt);
                command.Parameters.AddWithValue("@Username", cartItem.Username);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The product has been successfully added in Shopping Cart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update ShoppingCartTbl set ShoppingCartPrice=@Price,ShoppingCartDescription=@Description,ShoppingCartInformation=@Information,ShoppingCartCount=@Count,ShoppingCartImageExt=@ImageExt,ShoppingCartUsername=@Username where ShoppingCartName=@Name and ShoppingCartUsername=@Username", connection.Connect);
                command.Parameters.AddWithValue("@Name", cartItem.Product.name);
                command.Parameters.AddWithValue("@Price", cartItem.Product.price);
                command.Parameters.AddWithValue("@Description", cartItem.Product.description);
                command.Parameters.AddWithValue("@Information", cartItem.Product.info);
                command.Parameters.AddWithValue("@Count", cartItem.Count);
                command.Parameters.AddWithValue("@ImageExt", cartItem.Product.imageExt);
                command.Parameters.AddWithValue("@Username", cartItem.Username);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The product has been successfully updated in Shopping Cart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteCartItem(CartItem cartItem)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from ShoppingCartTbl where ShoppingCartName=@Name and ShoppingCartUsername=@Username", connection.Connect);
                command.Parameters.AddWithValue("@Name", cartItem.Product.name);
                command.Parameters.AddWithValue("@Username", cartItem.Username);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The product has been deleted successfully in Shopping Cart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CartItemList(string imageFolder)
        {
            try
            {
                CartItemTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * from ShoppingCartTbl", connection.Connect);
                dataBase.Fill(CartItemTable);
                connection.Close();
                for (int i = 0; i < CartItemTable.Rows.Count; i++)
                {
                    cartItem = new CartItem();
                    Products p = new Products();
                    p.name = CartItemTable.Rows[i]["ShoppingCartName"].ToString();
                    p.price = CartItemTable.Rows[i]["ShoppingCartPrice"].ToString();
                    p.description = CartItemTable.Rows[i]["ShoppingCartDescription"].ToString();
                    p.info = CartItemTable.Rows[i]["ShoppingCartInformation"].ToString();
                    p.imageExt = CartItemTable.Rows[i]["ShoppingCartImageExt"].ToString();
                    cartItem.Username = CartItemTable.Rows[i]["ShoppingCartUsername"].ToString();
                    cartItem.Set(Image.FromFile($"{imageFolder}{p.name}{p.imageExt}"), p, int.Parse(CartItemTable.Rows[i]["ShoppingCartCount"].ToString()));
                    cartItems.Add(cartItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
