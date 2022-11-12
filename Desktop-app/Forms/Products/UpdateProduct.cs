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

namespace Desktop_app.Forms.Products
{
    public partial class UpdateProduct : Form
    {
        private ProductHandler productHandler;
        private SingleProduct product;
        private Button showProducts;
        public UpdateProduct(ProductHandler productHandler, SingleProduct product, Button showProducts)
        {
            InitializeComponent();
            this.productHandler = productHandler;
            this.product = product;
            this.showProducts = showProducts;
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            cboxCatgeory.DataSource = null;
            cboxCatgeory.DataSource = Enum.GetValues(typeof(Categories));

            tbProductName.Text = product.Name;
            tbProductQuantity.Text = product.QuantityInStock.ToString();
            tbProductPrice.Text = product.Price.ToString();
            cboxCatgeory.Text = product.Category;
            tbsubCaregory.Text = product.SubCategory;
            tbProductDescription.Text = product.Description;
            tbBookIsbn.Text = product.Isbn;
            tbGamePlatform.Text = product.Platform;
            tbProductColor.Text = product.Color;
            tbSerialNumber.Text = product.SerialNumber;

            if (product.Image != null) pboxImage.Image = ConvertByteArrayToImage(product.Image);

        }
        private void cboxCatgeory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(btnUpdate.Enabled == false) return;
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

        public static Image ConvertByteArrayToImage(byte[] data)
        {
            if (data == null) return null;
            using (MemoryStream ms = new MemoryStream(data))
            using (Image image = Image.FromStream(ms, false, true))
            {
                return new Bitmap(image);
            }
            
        }

        private void UpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            fProducts.UPDATE_PRODUCT_FORM_OPEN = false;
            showProducts.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (Control co in this.Controls)
            {
                if (co is Label == false)
                {
                    if (co.Enabled == false)
                    {
                        co.Enabled = true;
                    }
                }
            }

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You sure you want to Update this Product?", "Update Product?", MessageBoxButtons.OKCancel);
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

                    if (pboxImage.Image != null) image = AddProduct.ConvertImageToByteArray(pboxImage.Image);
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



                    SingleProduct updatedProduct = new SingleProduct(name, description, quantity, price, category, subCategory, isbn, serialNumber, color, gamePlatform, image, DateTime.Now);

                    productHandler.UpdateProduct(updatedProduct, this.product);


                    MessageBox.Show("Product Updated successfully!");
                    fProducts.UPDATE_PRODUCT_FORM_OPEN = false;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }
    }
}
