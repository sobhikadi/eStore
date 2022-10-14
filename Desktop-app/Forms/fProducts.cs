using LogicLayerEntities.Products;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app.Forms
{
    public partial class fProducts : Form
    {
        private ProductHandler productHandler;

        private Product? selectedProductFromList;

        public static bool ADD_PRODUCT_FORM_OPEN = false;

        public fProducts()
        {
            InitializeComponent();
            productHandler = new ProductHandler();
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                listViewProducts.Items.Clear();

                foreach (Product product in productHandler.Products)
                {
                    AddProductToListView(product);
                }
          
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listViewProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedProductFromList = (Product)e.Item.Tag;

            foreach (Specification specs in selectedProductFromList.Specifications) 
            {
                lboxProductSpecs.Items.Add(specs);
            }
            tbDescription.Text = selectedProductFromList.Description;
        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewProducts.SelectedItems.Count == 0)
            {
                selectedProductFromList = null;
                lboxProductSpecs.Items.Clear();
                tbDescription.Clear();
            }
            
        }

        private void AddProductToListView(Product product)
        {
            ListViewItem item = new ListViewItem(product.Id.ToString());
            item.Tag = product;
            item.SubItems.Add(product.Name);
            item.SubItems.Add(product.QuantityInStock.ToString());
            item.SubItems.Add(product.GetType().Name);
            item.SubItems.Add(product.Price.ToString());

            listViewProducts.Items.Add(item);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            if (ADD_PRODUCT_FORM_OPEN != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else 
            {
                fAddProduct addProductForm = new fAddProduct(productHandler);
                ADD_PRODUCT_FORM_OPEN = true;
                addProductForm.Show();
            }
        }
    }
}
