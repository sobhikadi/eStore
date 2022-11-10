using DataAccessLayer;
using LogicLayerEntities.Products;
using LogicLayerHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStore.Pages
{
    public class ProductsModel : PageModel
    {
        private ProductHandler Handler;

        public List<SingleProduct> Products { get; set; }

        public void OnGet()
        {
            Handler = new ProductHandler();
            foreach (SingleProduct product in Handler.Products) 
            {
                Products.Add(product);
            }
        }
    }
}
