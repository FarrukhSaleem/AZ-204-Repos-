using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLApplication.Models;
using SQLApplication.Services;

namespace SQLApplication.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        private readonly IProductService _productservice;

        public IndexModel(IProductService productService) 
        {
            _productservice = productService;
        }

        public void OnGet()
        {
            // ProductService productsService = new ProductService();
            //Products=productservice.GetProducts();
            Products = _productservice.GetProducts();
        }
    }
}
