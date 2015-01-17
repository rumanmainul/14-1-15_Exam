using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfirmationApp.DAL.DBGateway;
using ProductStoreApp.DAL.DAO;

namespace ProductStoreApp.DAL.DBGateway
{
    class ProductDbGateWay
    {
        SqlConnectionManager aConnectionManager = new SqlConnectionManager();
        private SqlCommand aCommand;
        internal string SaveProductToDb(DAO.Product aProduct)
        {
            string saveQuery = "INSERT INTO t_product values('" + aProduct.ProductCode + "', '" + aProduct.Description +
                               "', '" + aProduct.Quantity + "')";
            aCommand = new SqlCommand(saveQuery, aConnectionManager.GetConnection());
            int rowEffected = aCommand.ExecuteNonQuery();
            aConnectionManager.CloseConnection();
            if (rowEffected > 0)
            {
                return "Add New Product";
            }
            else
            {
                return "Not Save";
            }
        }

        public bool HasProductCode(string productCode)
        {
            string searchCodeQuery = "SELECT * FROM t_product WHERE product_code = '" + productCode + "'";
            aCommand = new SqlCommand(searchCodeQuery, aConnectionManager.GetConnection());
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool hasData = aReader.HasRows;
            aConnectionManager.CloseConnection();
            if (hasData)
            {
                return true;
               
            }
            else
            {
                return false;
            }
        }

        internal string UpdateProductQuantity(string productCode, int quantity)
        {
            string updateQuery = "UPDATE t_product SET quantity+= '" + quantity + "' WHERE product_code = '" + productCode +"'";
            aCommand = new SqlCommand(updateQuery, aConnectionManager.GetConnection());
            int rowEffected = aCommand.ExecuteNonQuery();
            aConnectionManager.CloseConnection();
            if (rowEffected > 0)
            {
                return "Product Qunatity Updated";
            }
            else
            {
                return "Not Update";
            }
        }

        internal List<Product> GetAllProduct()
        {
            List<Product> aProductList = new List<Product>();
            
            string allProductQuery = "SELECT * FROM t_product";
            aCommand = new SqlCommand(allProductQuery, aConnectionManager.GetConnection());
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                Product aProduct = new Product();
                aProduct.ProductCode = aReader["product_code"].ToString();
                aProduct.Description = aReader["description"].ToString();
                aProduct.Quantity = Convert.ToInt32(aReader["quantity"]);
                aProductList.Add(aProduct);
            }
            aConnectionManager.CloseConnection();
            return aProductList;
        }

        internal string GetTotalQuantity()
        {
            string allProductQuery = "SELECT SUM(quantity) AS total FROM t_product";
            aCommand = new SqlCommand(allProductQuery, aConnectionManager.GetConnection());
            SqlDataReader aReader = aCommand.ExecuteReader();
            aReader.Read();
            string total = aReader["total"].ToString();
            aConnectionManager.CloseConnection();
            return total;
        }
    }
}
