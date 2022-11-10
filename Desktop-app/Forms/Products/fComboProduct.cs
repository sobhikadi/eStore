using LogicLayerEntities.Products;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop_app.Forms.Products
{
    public partial class fComboProduct : Form
    {
        private ProductHandler productHandler;
        private SingleProduct selectedProductFromSingleProduct;
        private SingleProduct selectedProductFromSingleInCombo;
        private ComboProduct selectedProductFromComboProduct;



        public fComboProduct(ProductHandler productHandler)
        {
            InitializeComponent();
            this.productHandler = productHandler;
        }

        private void ComboProduct_Load(object sender, EventArgs e)
        {
            try 
            {
                foreach (Product item in productHandler.Products)
                {
                    if (item is SingleProduct)
                    {
                        SingleProduct product = (SingleProduct)item;
                        int rowIndex = dataGridViewSingleProducts.Rows.Add();
                        dataGridViewSingleProducts.Rows[rowIndex].Cells["SingleName"].Value = product.Name;
                        dataGridViewSingleProducts.Rows[rowIndex].Cells["SinglePrice"].Value = product.GetPrice();
                        dataGridViewSingleProducts.Rows[rowIndex].Cells["SingleQuantity"].Value = product.GetQuantity();
                        dataGridViewSingleProducts.Rows[rowIndex].Tag = product;
                    }
                }
                DataGridComboProducts();
                dataGridViewSingleProducts.ClearSelection();
                dataGridViewComboProducts.ClearSelection();
                dataGridViewSingleInCombo.ClearSelection();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to add this Product?", "Add Product?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string name;
                double discount;
                List<SingleProduct> productList = new List<SingleProduct>();

                try
                {
                    name = tbName.Text;
                    discount = Convert.ToDouble(tbDiscount.Text);
                    foreach (DataGridViewRow row in dataGridViewSingleInCombo.Rows)
                    {
                        
                        int index = row.Index;
                        productList.Add((SingleProduct)dataGridViewSingleInCombo.Rows[index].Tag);
                    }

                    ComboProduct product = new ComboProduct(name, productList, discount, null);

                    productHandler.AddComboProduct(product);


                    MessageBox.Show("Product added successfully!");
                    dataGridViewComboProducts.Rows.Clear();
                    DataGridComboProducts();
                    dataGridViewSingleInCombo.Rows.Clear();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductFromSingleProduct == null) throw new ArgumentException("Please select a product first");
                foreach (DataGridViewRow row in dataGridViewSingleInCombo.Rows) 
                {
                    int index = row.Index;
                    if (selectedProductFromSingleProduct == (SingleProduct)dataGridViewSingleInCombo.Rows[index].Tag)
                        throw new ArgumentException("product is already in list");
                }
                int rowIndex = dataGridViewSingleInCombo.Rows.Add();
                dataGridViewSingleInCombo.Rows[rowIndex].Cells["SinCName"].Value = selectedProductFromSingleProduct.Name;
                dataGridViewSingleInCombo.Rows[rowIndex].Cells["SinCPrice"].Value = selectedProductFromSingleProduct.GetPrice();
                dataGridViewSingleInCombo.Rows[rowIndex].Cells["SinCQuantity"].Value = selectedProductFromSingleProduct.GetQuantity();
                dataGridViewSingleInCombo.Rows[rowIndex].Tag = selectedProductFromSingleProduct;
                dataGridViewSingleInCombo.ClearSelection();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductFromSingleInCombo == null) throw new ArgumentException("Please select a product first");
                foreach (DataGridViewRow row in dataGridViewSingleInCombo.Rows)
                {
                    int index = row.Index;
                    if (selectedProductFromSingleInCombo == (SingleProduct)dataGridViewSingleInCombo.Rows[index].Tag)
                        dataGridViewSingleInCombo.Rows.RemoveAt(index);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridViewSingleProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSingleProducts.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewSingleProducts.CurrentCell.RowIndex;
                selectedProductFromSingleProduct = (SingleProduct)dataGridViewSingleProducts.Rows[rowIndex].Tag;
            }
        }

        private void dataGridViewSingleInCombo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSingleInCombo.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewSingleInCombo.CurrentCell.RowIndex;
                selectedProductFromSingleInCombo = (SingleProduct)dataGridViewSingleInCombo.Rows[rowIndex].Tag;
            }
        }

        private void dataGridViewComboProducts_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridViewComboProducts.SelectedRows.Count > 0)
            {
                int index = dataGridViewComboProducts.CurrentCell.RowIndex;
                selectedProductFromComboProduct = (ComboProduct)dataGridViewComboProducts.Rows[index].Tag;
            }
            else selectedProductFromComboProduct = null;
            dataGridViewSingleInCombo.Rows.Clear();
            if (selectedProductFromComboProduct == null)
            {
                dataGridViewSingleInCombo.Rows.Clear();
                return;
            }
            foreach (SingleProduct product in selectedProductFromComboProduct.Products)
            {
                int rowIndex = dataGridViewSingleInCombo.Rows.Add();
                dataGridViewSingleInCombo.Rows[rowIndex].Cells["SinCName"].Value = product.Name;
                dataGridViewSingleInCombo.Rows[rowIndex].Cells["SinCPrice"].Value = product.GetPrice();
                dataGridViewSingleInCombo.Rows[rowIndex].Cells["SinCQuantity"].Value = product.GetQuantity();
                dataGridViewSingleInCombo.Rows[rowIndex].Tag = product;
                dataGridViewSingleInCombo.ClearSelection();
            }
        }

        private void dataGridViewComboProducts_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView.HitTestInfo hitTest = dataGridViewComboProducts.HitTest(e.X, e.Y);

                if (hitTest.Type != DataGridViewHitTestType.Cell)
                {
                    dataGridViewComboProducts.ClearSelection();
                    selectedProductFromComboProduct = null;
                }
                int index = dataGridViewComboProducts.CurrentCell.RowIndex;
                selectedProductFromComboProduct = (ComboProduct)dataGridViewComboProducts.Rows[index].Tag;

            }
            catch (Exception)
            {
                MessageBox.Show("Some exception");
            }
        }

        private void DataGridComboProducts() 
        {
            
            foreach (Product item in productHandler.Products)
            {
                if (item is ComboProduct)
                {
                    ComboProduct product = (ComboProduct)item;
                    int rowIndex = dataGridViewComboProducts.Rows.Add();
                    dataGridViewComboProducts.Rows[rowIndex].Cells["ComboName"].Value = product.Name;
                    dataGridViewComboProducts.Rows[rowIndex].Cells["ComboPrice"].Value = product.GetPrice().ToString("0.00");
                    dataGridViewComboProducts.Rows[rowIndex].Cells["ComboQuantity"].Value = product.GetQuantity();
                    dataGridViewComboProducts.Rows[rowIndex].Cells["ComboDiscount"].Value = product.Discount;
                    dataGridViewComboProducts.Rows[rowIndex].Cells["ComboNrProducts"].Value = product.Products.Count;
                    dataGridViewComboProducts.Rows[rowIndex].Tag = product;
                }
            }
        }

        private void ComboProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            fProducts.COMBO_PRODUCT_FORM_OPEN = false;
        }
    }
}
