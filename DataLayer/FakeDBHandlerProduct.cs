using LogicLayerEntities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class FakeDBHandlerProduct : IDBMediatorProduct
    {

        private List<Product> products = new List<Product>();
        public bool AddSpecification(SingleProduct product, string name, string value)
        {
            return true;
        }

        public bool CheckIfProductModified(SingleProduct currentProduct)
        {
            return true;
        }

        public bool DeleteProduct(SingleProduct product)
        {
            return true;
        }

        public bool DeleteSpecFromDB(int productId, string specName)
        {
            return true;
        }

        public Dictionary<string, string> GetProductSpecifications(int productId)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            return result;
        }

        public List<SingleProduct> GetSingleProducts()
        {
            List<SingleProduct> products = new List<SingleProduct>();
            return products;
        }

        public int InsertProduct(SingleProduct product)
        {
            if (CheckIfProductExist(product.Name)) return 0;
            products.Add(product);
            return 1;
        }

        public List<SingleProduct> SearchProduct(string term, SearchTypeProduct type)
        {
            List<SingleProduct> products = new List<SingleProduct>();

            return products;
        }

        public bool UpdateProduct(SingleProduct newProduct, SingleProduct currentProduct)
        {
            return true;
        }

        public bool CheckIfProductExist(string name)
        {
            foreach (Product product in products) 
            {
                if (product.Name == name) return true;
            }
            return false;
        }

        public int InsertComboProduct(ComboProduct comboProduct)
        {
            if (CheckIfProductExist(comboProduct.Name)) return 0;
            products.Add(comboProduct);
            return 1;
        }

        public List<ComboProduct> GetComboProducts()
        {
            List<ComboProduct> products = new List<ComboProduct>();
            return products;
        }

        
    }
}
