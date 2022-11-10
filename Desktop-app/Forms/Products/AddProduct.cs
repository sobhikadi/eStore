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
        private Button showProducts;

        public AddProduct(ProductHandler productHandler, Button showProducts)
        {
            InitializeComponent();
            this.productHandler = productHandler;
            this.showProducts = showProducts;

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
            DialogResult dr = MessageBox.Show("Are You sure you want to add this Product?", "Add Product?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                string name, category, subCategory, description;
                string? isbn, gamePlatform, serialNumber, color;
                int quantity;
                double price;
                byte[]? image;


                try
                {

                    if (string.IsNullOrEmpty(tbProductQuantity.Text)) { throw new ArgumentException("Please enter the quantity"); }
                    if (string.IsNullOrEmpty(tbProductPrice.Text)) { throw new ArgumentException("Please enter a price"); }

                    if (tbBookIsbn.Enabled && string.IsNullOrEmpty(tbBookIsbn.Text)) { throw new ArgumentException("Book Isbn msut be entered"); }
                    if (tbGamePlatform.Enabled && string.IsNullOrEmpty(tbGamePlatform.Text)) { throw new ArgumentException("game platform msut be entered"); }
                    if (tbProductColor.Enabled && string.IsNullOrEmpty(tbProductColor.Text)) { throw new ArgumentException("Color msut be entered"); }
                    if (tbSerialNumber.Enabled && string.IsNullOrEmpty(tbSerialNumber.Text)) { throw new ArgumentException("serial number msut be entered"); }
                    if (pboxImage.Image != null) image = ConvertImageToByteArray(pboxImage.Image);
                    else image = null;

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



                    SingleProduct product = new SingleProduct(name, description, quantity, price, category, subCategory, isbn, serialNumber, color, gamePlatform, image, null);

                    productHandler.AddProduct(product);


                    MessageBox.Show("Product added successfully!");
                    fProducts.ADD_PRODUCT_FORM_OPEN = false;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
            
        }
        private void fAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            fProducts.ADD_PRODUCT_FORM_OPEN = false;
            showProducts.PerformClick();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            ofdImage.ShowDialog();
            ofdImage.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            Image? img = null;
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                img = new Bitmap(ofdImage.FileName);
                pboxImage.Image = img.GetThumbnailImage(340, 165, null, new IntPtr());
            }
            else return;
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            pboxImage.Image = null;
        }

        public static byte[] ConvertImageToByteArray(Image img) 
        {
            using (MemoryStream ms = new MemoryStream()) 
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

       
    }
}
