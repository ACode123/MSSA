using Assignment12._1.Models;
using Microsoft.AspNetCore.Mvc;


namespace Assignment12._1.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _tempProduct;
        public ProductController(IProductRepository tempProduct)
        {
            _tempProduct = tempProduct;
        }
        
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products = _tempProduct.InitializeProducts();
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            var model = _tempProduct.GetProduct(id);
            if (model == null)
            {
                return NotFound();
            }
             return View(model);
        }
       
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _tempProduct.AddProduct(obj);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int? id)
        {
           Product obj= _tempProduct.GetProduct(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempProduct.UpdateProduct(obj);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
           
                _tempProduct.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
