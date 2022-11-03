using DataAccessLayer;
using LogicLayerEntities.Products;

namespace LogicLayerHandlers
{
    public class ProductHandler
    {
        private DBHandlerProducts dbHandlerProducts = new DBHandlerProducts();

        private List<ComboProduct> comboProducts;

        public ProductHandler()
        {
            comboProducts = new List<ComboProduct>();
        }
        public IList<SingleProduct> Products { get { return dbHandlerProducts.GetAllProducts().AsReadOnly(); } }
        public IList<ComboProduct> ComboProducts { get { return comboProducts.AsReadOnly(); } }

        public void AddProduct(SingleProduct product)
        {
           dbHandlerProducts.InsertProduct(product); 
        }

        public void AddComboProduct(ComboProduct comboProduct) 
        {
            this.comboProducts.Add(comboProduct);
        }

    }
}