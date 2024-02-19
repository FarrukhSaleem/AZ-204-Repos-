using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement;
using SQLApplication.Models;
using SQLApplication.Services;

namespace SQLApplication.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        private readonly IProductService _productservice;
        private readonly IFeatureManager _featuremanager;
        public bool IsBeta;

        public IndexModel(IProductService productService,IFeatureManager featureManager) 
        {
            _productservice = productService;
            _featuremanager = featureManager;
        }

        

        public void OnGet()
        {
            // ProductService productsService = new ProductService();
            //Products=productservice.GetProducts();

            IsBeta = _productservice.IsBeta().Result; //result added as it is an async method
            Products = _productservice.GetProducts();
        }
    }
}
