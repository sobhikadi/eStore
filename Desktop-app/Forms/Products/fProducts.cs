using Desktop_app.Forms.Products;
using LogicLayerEntities.Products;
using LogicLayerHandlers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private SingleProduct? selectedProductFromList;

        public static bool ADD_PRODUCT_FORM_OPEN = false;
        public static bool UPDATE_PRODUCT_FORM_OPEN = false;
        public static bool PRODUCT_SPECIFICATIONS_FORM_OPEN = false;
        public static bool COMBO_PRODUCT_FORM_OPEN = false;




        public fProducts()
        {
            InitializeComponent();
            
        }
        private void fProducts_Load(object sender, EventArgs e)
        {
            try
            {
                productHandler = new ProductHandler();
            }
            catch (SqlException) { MessageBox.Show("Unable to communicate with database"); }
            cboxSearchCriteria.DataSource = null;
            cboxSearchCriteria.DataSource = Enum.GetValues(typeof(SearchTypeProduct));
            cboxSearchTerm.DataSource = null;
            cboxSearchTerm.DataSource = Enum.GetValues(typeof(Categories));
        }

        private void btnShowAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                listViewProducts.Items.Clear();

                foreach (Product product in productHandler.Products)
                {
                    if (product is SingleProduct)  AddProductToListView((SingleProduct)product);
                }
                selectedProductFromList = null;
          
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listViewProducts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedProductFromList = (SingleProduct)e.Item.Tag;

        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewProducts.SelectedItems.Count == 0)
            {
                selectedProductFromList = null;
            }
            
        }

        private void AddProductToListView(SingleProduct product)
        {
            ListViewItem item = new ListViewItem(product.Id.ToString());
            item.Tag = product;
            item.SubItems.Add(product.Name);
            item.SubItems.Add(product.QuantityInStock.ToString());
            item.SubItems.Add(product.Category);
            item.SubItems.Add(product.SubCategory);
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
                AddProduct addProductForm = new AddProduct(productHandler, btnShowAllProducts);
                ADD_PRODUCT_FORM_OPEN = true;
                addProductForm.Show();
            }
        }

        private void btnComboProducts_Click(object sender, EventArgs e)
        {
            if (COMBO_PRODUCT_FORM_OPEN != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                Forms.Products.fComboProduct comboProduct = new Forms.Products.fComboProduct(productHandler);
                COMBO_PRODUCT_FORM_OPEN = true;
                comboProduct.Text = "eStore - Combo Products";
                comboProduct.Show();
            }
        }

        private void cboxSearchCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxSearchCriteria.Text == "Category")
            {
                cboxSearchTerm.Visible = true;
                tbSearchTerm.Visible = false;
            }
            else 
            {
                cboxSearchTerm.Visible = false;
                tbSearchTerm.Visible = true;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            listViewProducts.Items.Clear();
            string serchTerm = null;
            try
            {
                if (tbSearchTerm.Visible == true)
                {
                    if (string.IsNullOrEmpty(tbSearchTerm.Text)) throw new Exception("Please enter a search term");
                    serchTerm = tbSearchTerm.Text;
                }
                if (cboxSearchTerm.Visible == true)
                {
                    serchTerm = cboxSearchTerm.Text;
                }


                List<Product> products = new List<Product>();
                products.AddRange(productHandler.SearchProduct(serchTerm, (SearchTypeProduct)cboxSearchCriteria.SelectedValue));

                
                foreach (Product product in products)
                {
                    if(product is SingleProduct) AddProductToListView((SingleProduct)product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenUpdateProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductFromList == null)
            { 
                MessageBox.Show("Please select a product from the list first"); 
                return; 
            }
            if (UPDATE_PRODUCT_FORM_OPEN != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                UpdateProduct updateProductForm = new UpdateProduct(productHandler, selectedProductFromList, btnShowAllProducts);
                UPDATE_PRODUCT_FORM_OPEN = true;
                updateProductForm.Show();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (selectedProductFromList == null)
            {
                MessageBox.Show("Please select a product first"); 
                return;
            }
            DialogResult dr = MessageBox.Show($"Are You sure you want to Delete this Product ({selectedProductFromList.Name}) ?", "Delete Product?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    productHandler.DeleteProduct(selectedProductFromList);
                    MessageBox.Show("Product has successfully been deleted");
                    btnShowAllProducts.PerformClick();
                }
                catch (SqlException) { MessageBox.Show("Something went wrong with database connection"); }
                catch (Exception ex ) { MessageBox.Show(ex.Message); }

            }
            else return;
        }

        private void btnSpecifications_Click(object sender, EventArgs e)
        {
            if (selectedProductFromList == null)
            {
                MessageBox.Show("Please select a product first");
                return;
            }
            if (PRODUCT_SPECIFICATIONS_FORM_OPEN != false)
            {
                MessageBox.Show("There is already a window open");
                return;
            }
            else
            {
                ProductSpecifications productSpecifications = new ProductSpecifications(productHandler, selectedProductFromList, btnShowAllProducts);
                PRODUCT_SPECIFICATIONS_FORM_OPEN = true;
                productSpecifications.Text = $"Specifications of ({selectedProductFromList.Name})";
                productSpecifications.Show();
            }
        }
    }
}
