using LogicLayerEntities.Products;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_app.Forms.Products
{
    public partial class ProductSpecifications : Form
    {
        ProductHandler ProductHandler;
        SingleProduct product;
        Button refreshData;

        public ProductSpecifications(ProductHandler productHandler ,SingleProduct product, Button refreshButton)
        {
            InitializeComponent();
            this.ProductHandler = productHandler;
            this.product = product;
            this.refreshData = refreshButton;
        }

        private void ProductSpecifications_Load(object sender, EventArgs e)
        {
            dataGridViewSpecifications.Rows.Clear();
            foreach (KeyValuePair<string, string> kvp in product.Specifications) 
            {
                dataGridViewSpecifications.Rows.Add(kvp.Key, kvp.Value);
            }

        }

        private void ProductSpecifications_FormClosing(object sender, FormClosingEventArgs e)
        {
            fProducts.PRODUCT_SPECIFICATIONS_FORM_OPEN = false;
            refreshData.PerformClick();
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            string name, value;
            try
            {
                name = tbSpecsName.Text;
                value = tbSpecsValue.Text;

                ProductHandler.AddSpecificationToProduct(product, name, value);
                MessageBox.Show("Specifications has successfully been added");
                tbSpecsName.Clear();
                tbSpecsValue.Clear();
                dataGridViewSpecifications.Rows.Clear();
                foreach (KeyValuePair<string, string> kvp in product.Specifications)
                {
                    dataGridViewSpecifications.Rows.Add(kvp.Key, kvp.Value);
                }

            }
            catch (SqlException) { MessageBox.Show("Something went wrong with database connection"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnDeleteSpec_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to delete this specification?", "delete specification?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                try
                {
                    if (dataGridViewSpecifications.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Please select an item first");
                        return;
                    }
                    string name;
                    name = (string)dataGridViewSpecifications.SelectedCells[0].Value;

                    ProductHandler.DeleteSpecification(product, name);

                    dataGridViewSpecifications.Rows.Clear();
                    foreach (KeyValuePair<string, string> kvp in product.Specifications)
                    {
                        dataGridViewSpecifications.Rows.Add(kvp.Key, kvp.Value);
                    }
                    MessageBox.Show("Specification has successfully been deleted");
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else return;
        }
    }
}
