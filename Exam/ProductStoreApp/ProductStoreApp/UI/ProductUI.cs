using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProductStoreApp.BLL;
using ProductStoreApp.DAL.DAO;

namespace ProductStoreApp.UI
{
    public partial class ProductUI : Form
    {
        public ProductUI()
        {
            InitializeComponent();
        }
        ProductManager aProductManager = new ProductManager();
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Product aProduct =new Product();
            aProduct.ProductCode = codeTextBox.Text;
            aProduct.Description = descriptionTextBox.Text;
            aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);
            string alert = aProductManager.SaveProductToDB(aProduct);
            MessageBox.Show(alert);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            List<Product> aProductList = new List<Product>();
            aProductList = aProductManager.GetAllProduct();
            ListViewItem aListViewItem;
            productListView.Items.Clear();
            foreach (Product products in aProductList)
            {
                aListViewItem = new ListViewItem();
                aListViewItem.Text = products.ProductCode;
                aListViewItem.SubItems.Add(products.Description);
                aListViewItem.SubItems.Add(products.Quantity.ToString());
                productListView.Items.Add(aListViewItem);
            }
            totalQuantityLabel.Text = aProductManager.GetTotalQuantity();

        }
    }
}
