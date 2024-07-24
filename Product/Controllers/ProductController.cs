using Microsoft.AspNetCore.Mvc;
using Product.Models;

namespace Product.Controllers
{
    public class ProductController : Controller
    {

        private static List<Products>? _products = new List<Products>()
			{
				new Products(){Id=1, Name="Product1", Quantity=1, Price=1,},
				new Products(){Id=2, Name="Product2", Quantity=2, Price=2,},
				new Products(){Id=3, Name="Product3", Quantity=3, Price=3,},
				new Products(){Id=4, Name="Product4", Quantity=4, Price=4,},
				new Products(){Id=5, Name="Product5", Quantity=5, Price=5,},
				new Products(){Id=6, Name="Product6", Quantity=6, Price=6,},
				new Products(){Id=7, Name="Product7", Quantity=7, Price=7,},
				new Products(){Id=8, Name="Product8", Quantity=8, Price=8,},
				new Products(){Id=9, Name="Product9", Quantity=9, Price=9,},
				new Products(){Id=10, Name="Product10", Quantity=10, Price=10,}
			};
	

	

        public IActionResult GetProductById(int id)

        {  
            var pr= _products!.Find(x => x.Id == id);
            if (pr != null)
            {

                return View(pr);
            }
            return View("404");
        }


        public IActionResult GetAllProduct()
        {

            return View(_products);
        }
        public IActionResult DeleteProductById(int id)
        {
            var pr = _products!.Find(x => x.Id == id);
            if (pr != null)
            {
                _products.Remove(pr);
                return View("GetAllProduct", _products);
            }
            return View("404");
        }



    }
}
