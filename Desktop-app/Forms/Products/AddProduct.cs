using LogicLayerEntities.Products;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    public partial class AddProduct : Form
    {
        private ProductHandler productHandler;

        public AddProduct(ProductHandler productHandler)
        {
            InitializeComponent();
            this.productHandler = productHandler;

            cboxCatgeory.DataSource = null;
            cboxCatgeory.DataSource = Enum.GetValues(typeof(Categories));
        }

        private void cboxCatgeory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxCatgeory.Text == Categories.Households.ToString())
            {
                tbProductColor.Enabled = true;
                tbSerialNumber.Enabled = false;
                tbGamePlatform.Enabled = false;
                tbBookIsbn.Enabled = false;
            }
            if (cboxCatgeory.Text == Categories.Electronics.ToString())
            {
                tbProductColor.Enabled = true;
                tbSerialNumber.Enabled = true;
                tbGamePlatform.Enabled = false;
                tbBookIsbn.Enabled = false;
            }
            if (cboxCatgeory.Text == Categories.Books.ToString())
            {
                tbProductColor.Enabled = false;
                tbSerialNumber.Enabled = false;
                tbGamePlatform.Enabled = false;
                tbBookIsbn.Enabled = true;
            }
            if (cboxCatgeory.Text == Categories.VedioGames.ToString())
            {
                tbProductColor.Enabled = false;
                tbSerialNumber.Enabled = false;
                tbGamePlatform.Enabled = true;
                tbBookIsbn.Enabled = false;
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name, category, subCategory, description;
            string? isbn, gamePlatform, serialNumber, color;
            int quantity;
            double price;

            try
            {
 
                if (string.IsNullOrEmpty(tbProductQuantity.Text)) { throw new ArgumentException("Please enter the quantity"); }
                if (string.IsNullOrEmpty(tbProductPrice.Text)) { throw new ArgumentException("Please enter a price"); }

                if (tbBookIsbn.Enabled && string.IsNullOrEmpty(tbBookIsbn.Text)) { throw new ArgumentException("Book Isbn msut be entered"); }
                if (tbGamePlatform.Enabled && string.IsNullOrEmpty(tbGamePlatform.Text)) { throw new ArgumentException("game platform msut be entered"); }
                if (tbProductColor.Enabled && string.IsNullOrEmpty(tbProductColor.Text)) { throw new ArgumentException("Color msut be entered"); }
                if (tbSerialNumber.Enabled && string.IsNullOrEmpty(tbSerialNumber.Text)) { throw new ArgumentException("serial number msut be entered"); }

                name = tbProductName.Text;
                quantity = Convert.ToInt32(tbProductQuantity.Text);
                price = Convert.ToDouble(tbProductPrice.Text);
                category = cboxCatgeory.Text;
                subCategory = tbsubCaregory.Text;
                description = tbProductDescription.Text;
                isbn = tbBookIsbn.Text;
                gamePlatform = tbGamePlatform.Text;
                color = tbProductColor.Text;
                serialNumber = tbSerialNumber.Text;

                

                Product product = new Product(name, description, quantity, price, category, subCategory, isbn, serialNumber, color, gamePlatform);
            
                productHandler.AddProduct(product);

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
