using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStoreApp.DAL.DAO;
using ProductStoreApp.DAL.DBGateway;

namespace ProductStoreApp.BLL
{
    class ProductManager
    {
        ProductDbGateWay aProductDbGateWay = new ProductDbGateWay();

        internal string SaveProductToDB(Product aProduct)
        {
            if (aProduct.ProductCode.Length >= 3)
            {
                if (aProduct.Quantity > 0)
                {
                    if (HasProductCode(aProduct.ProductCode))
                    {
                        string updateAlert = aProductDbGateWay.UpdateProductQuantity(aProduct.ProductCode,
                            aProduct.Quantity);
                        return updateAlert;
                    }
                    else
                    {
                        string alert = aProductDbGateWay.SaveProductToDb(aProduct);
                        return alert;
                    }
                }
                else
                {
                    return "Product Quantity Less Than 0";
                }
            }
            else
            {
                return "Product Lenth is Less Than 3";
            }
        }


        private bool HasProductCode(string productCode)
        {
            bool hasCode = aProductDbGateWay.HasProductCode(productCode);
            if (hasCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal List<Product> GetAllProduct()
        {
            return aProductDbGateWay.GetAllProduct();
        }

        internal string GetTotalQuantity()
        {
            return aProductDbGateWay.GetTotalQuantity();
        }
    }
}
