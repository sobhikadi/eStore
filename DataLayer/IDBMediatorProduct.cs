using LogicLayerEntities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDBMediatorProduct
    {
        public int InsertProduct(SingleProduct product);

        public List<SingleProduct> GetSingleProducts();

        public bool UpdateProduct(SingleProduct newProduct, SingleProduct currentProduct);

        public IList<Product> SearchProduct(string term, SearchTypeProduct type);

        public bool CheckIfProductModified(SingleProduct currentProduct);

        public bool DeleteProduct(SingleProduct product);

        public bool AddSpecification(SingleProduct product, string name, string value);

        public Dictionary<string, string> GetProductSpecifications(int productId);

        public bool DeleteSpecFromDB(int productId, string specName);

        public bool CheckIfProductExist(string name);
    }
}
