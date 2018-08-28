using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductsDal
    {
        SqlConnection _connection =
            new SqlConnection(@"server=(localdb)\mssqllocaldb;Initial Catalog=ETrade;Integrated Security=true");


        public DataTable GetAll()
        {


            ControlConnection();
            SqlCommand command = new SqlCommand("select * from Product", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            _connection.Close();
            return dt;
        }

        private void ControlConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<Product> GetList()
        {
            SqlConnection connection =
                new SqlConnection(@"server=(localdb)\mssqllocaldb;Initial Catalog=ETrade;Integrated Security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("select * from Product", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt64(reader["StokAmount"])
                };
                products.Add(product);
            }
            reader.Close();
            connection.Close();
            return products;
        }

        public void Add(Product product)
        {
            ControlConnection();
            SqlCommand command = new SqlCommand("Insert into Product values(@name,@uniteprice,@stockamount)",
                _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@uniteprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockamount", product.StockAmount);
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void Update(Product product)
        {
            ControlConnection();
            SqlCommand command =
                new SqlCommand(
                    "UPDATE PRODUCT SET  name=@name,UnitPrice =@uniteprice,StokAmount=@stockamount where Id=@Id",
                    _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@uniteprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockamount", product.StockAmount);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(Product product)
        {
            ControlConnection();
            SqlCommand command = new SqlCommand("DELETE Product where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();

        }
    }

}
