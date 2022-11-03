using LogicLayerEntities.Products;
using LogicLayerHandlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace eStore.Pages
{
    public class ProductsModel : PageModel
    {
        public ProductHandler Handler { get; set; }

        public List<SingleProduct> Products { get; set; }

        public void OnGet()
        {
            Handler = new ProductHandler();
            Products = Handler.Products.ToList<SingleProduct>();
        }
    }
}
