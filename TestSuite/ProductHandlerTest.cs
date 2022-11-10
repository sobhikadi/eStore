using DataAccessLayer;
using LogicLayerEntities.Products;
using LogicLayerHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSuite
{
    [TestClass]
    public class ProductHandlerTest
    {
        [TestMethod]
        public void AddProductTest()
        {
            ProductHandler handler = new ProductHandler(createTestRepo());
            SingleProduct p1 = new SingleProduct("Phone", "Hello", 10, 200, Categories.Electronics.ToString(), "SmartPhones", null, "0012313564", "black", null, null, null);
            SingleProduct p2 = new SingleProduct("book", "Hello", 10, 200, Categories.Books.ToString(), "Ebooks", "1212315545643", null, null, null, null, null);


            bool resultP1 = handler.AddProduct(p1);
            bool resultP2 = handler.AddProduct(p2);

            Assert.IsTrue(resultP1);
            Assert.IsTrue(resultP2);


        }
        private IDBMediatorProduct createTestRepo()
        {
            //return new DBHandlerProducts();
            return new FakeDBHandlerProduct();
        }

    }
}
