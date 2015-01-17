using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreApp.DAL.DAO
{
    public class Product
    {
        public int Id { set; get; }
        public string ProductCode { set; get; }
        public string Description { set; get; }
        public int Quantity { set; get; }
    }
}
