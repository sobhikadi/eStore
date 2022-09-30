using LogicClassLibrary.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Desktop_app.Forms
{
    public partial class fAddProduct : Form
    {
        private ProductHandler productHandler;

        public fAddProduct(ProductHandler productHandler)
        {
            InitializeComponent();
            this.productHandler = productHandler;
        }

        private void cboxCatgeory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCatgeory.Text == Categories.Households.ToString())
            {
                tbProductColor.Enabled = true;
                tbSeriaNumber.Enabled = false;
                tbGamePlatform.Enabled = false;
                tbBookIsbn.Enabled = false;
            }
            if (cboxCatgeory.Text == Categories.Electronics.ToString())
            {
                tbProductColor.Enabled = true;
                tbSeriaNumber.Enabled = true;
                tbGamePlatform.Enabled = false;
                tbBookIsbn.Enabled = false;
            }
            if (cboxCatgeory.Text == Categories.Books.ToString())
            {
                tbProductColor.Enabled = false;
                tbSeriaNumber.Enabled = false;
                tbGamePlatform.Enabled = false;
                tbBookIsbn.Enabled = true;
            }
            if (cboxCatgeory.Text == Categories.VedioGames.ToString())
            {
                tbProductColor.Enabled = false;
                tbSeriaNumber.Enabled = false;
                tbGamePlatform.Enabled = true;
                tbBookIsbn.Enabled = false;
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name, category, subCategory, description, isbn, gamePlatform, serialNumber, color;
            int quantity;
            double price;

            try
            {
                

                if (string.IsNullOrEmpty(tbProductName.Text)) { MessageBox.Show("Please enter a name"); return; }
                if (string.IsNullOrEmpty(tbProductQuantity.Text)) { MessageBox.Show("Please enter the quantity"); return; }
                if (string.IsNullOrEmpty(tbProductPrice.Text)) { MessageBox.Show("Please enter a price"); return; }
                if (string.IsNullOrEmpty(cboxCatgeory.Text)) { MessageBox.Show("Please select a category"); return; }
                if (string.IsNullOrEmpty(tbsubCaregory.Text)) { MessageBox.Show("Please enter a subcategory"); return; }
                if (string.IsNullOrEmpty(tbProductDescription.Text)) { MessageBox.Show("Please enter product description"); return; }
                if (tbBookIsbn.Enabled == true && string.IsNullOrEmpty(tbBookIsbn.Text)) { MessageBox.Show("Please enter book's ISBN"); return; }
                if (tbGamePlatform.Enabled == true && string.IsNullOrEmpty(tbGamePlatform.Text)) { MessageBox.Show("Please enter game's platform"); return; }
                if (tbProductColor.Enabled == true && string.IsNullOrEmpty(tbProductColor.Text)) { MessageBox.Show("Please enter the color"); return; }
                if (tbSeriaNumber.Enabled == true && string.IsNullOrEmpty(tbSeriaNumber.Text)) { MessageBox.Show("Please enter the serial number"); return; }

                name = tbProductName.Text;
                quantity = Convert.ToInt32(tbProductQuantity.Text);
                price = Convert.ToDouble(tbProductPrice.Text);
                category = cboxCatgeory.Text;
                subCategory = tbsubCaregory.Text;
                description = tbProductDescription.Text;
                isbn = tbBookIsbn.Text;
                gamePlatform = tbGamePlatform.Text;
                color = tbProductColor.Text;
                serialNumber = tbSeriaNumber.Text;



                productHandler.AddProduct(name, quantity, price, category, subCategory, description, isbn, gamePlatform, serialNumber, color);

                foreach (Control co in this.Controls)
                {
                    if (co is TextBox || co is ComboBox)
                    {
                        co.ResetText();
                    }
                }
                MessageBox.Show("Product added successfully!");
                fProducts.ADD_PRODUCT_FORM_OPEN = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void fAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            fProducts.ADD_PRODUCT_FORM_OPEN = false;
        }
    }
}
