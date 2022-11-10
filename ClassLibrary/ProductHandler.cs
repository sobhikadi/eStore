﻿using DataAccessLayer;
using LogicLayerEntities.Products;

namespace LogicLayerHandlers
{
    public class ProductHandler
    {
        private DBHandlerProducts dbHandlerProducts = new DBHandlerProducts();

        private List<Product> products;

        public ProductHandler()
        {
            products = new List<Product>();
            UpdateListOfProducts();
        }

        public IList<Product> Products { get 
            {
                //UpdateListOfProducts();
                return products.AsReadOnly(); 
            } }

        public void AddProduct(SingleProduct product)
        {
            if (CheckProductExist(product)) throw new Exception($"Product with the name {product.Name} already exist in database");
           int id = dbHandlerProducts.InsertProduct(product);
            if (id == 0) throw new Exception("Product has not been added");
            product.Id = id;
            products.Add(product);

            UpdateListOfProducts();
        }

        public void UpdateProduct(SingleProduct newProduct, SingleProduct currentProduct) 
        {
            bool success = dbHandlerProducts.UpdateProduct(newProduct, currentProduct);

            if (!success) throw new ArgumentException("");

            if (!products.Contains(currentProduct)) throw new ArgumentException("");

            currentProduct.ChangeInformation(newProduct);

           UpdateListOfProducts();
        }

        public void DeleteProduct(SingleProduct product) 
        {
            bool deleted = dbHandlerProducts.DeleteProduct(product);
            if (!deleted) throw new ArgumentException("Product has not been deleted successfully");
            products.Remove(product);
        }

        public void AddComboProduct(ComboProduct comboProduct) 
        {
            if (CheckProductExist(comboProduct)) throw new Exception($"Product with the name {comboProduct.Name} already exist in database");
            //int id = dbHandlerProducts.InsertProduct(product);
            //if (id == 0) throw new Exception("Product has not been added");
            //product.Id = id;
            products.Add(comboProduct);
        }

        public IList<Product> SearchProduct(string term, SearchTypeProduct type)
        {
            return dbHandlerProducts.SearchProduct(term, type);
        }

        private bool CheckProductExist(Product product) 
        {
            foreach (Product prod in products) 
            {
                if (prod.Name == product.Name) return true;
            }
            return false;
        }

        private void UpdateListOfProducts() 
        {
            products.Clear();
            products.AddRange(dbHandlerProducts.GetSingleProducts());
        }

        public void AddSpecificationToProduct(SingleProduct product, string name, string value) 
        {

            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Specification name cannot be empty");
            if (string.IsNullOrEmpty(value)) throw new ArgumentException("Specification value cannot be empty");

            bool added = dbHandlerProducts.AddSpecification(product, name, value);
            if (!added) throw new ArgumentException("Specification has Not successfully been added");

            if (!CheckProductExist(product)) throw new ArgumentException("The product you are trying to edit has been altered while you are working please refresh the information and try again");
            product.AddSpecifications(name, value);
        }

        public void DeleteSpecification(SingleProduct product, int productId, string specsName) 
        {
            bool deleted = dbHandlerProducts.DeleteSpecFromDB(productId, specsName);
            if (!deleted) throw new ArgumentException("Specification has not been deleted successfully");
            product.GetSpecsFromDB(dbHandlerProducts.GetProductSpecifications(productId));

        }

        

    }
}