using DataAccessLayer;
using LogicLayerEntities.Products;
using LogicLayerHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;

namespace eStore.Pages
{
    public class ProductsModel : PageModel
    {
        private ProductHandler Handler;

        public List<SingleProduct> Products { get; set; } = new List<SingleProduct>();

        public void OnGet(string name)
        {
            Products.Clear();
            Handler = new ProductHandler();
            foreach (Product product in Handler.Products) 
            {

                if (product is SingleProduct)
                {
                    SingleProduct product2 = (SingleProduct)product;
                    if (product2.Category == name) 
                    { 
                        Products.Add((SingleProduct)product);
                    
                    }
                    else if (name == null) Products.Add((SingleProduct)product);
                }
            }
        }

        
    }
}
