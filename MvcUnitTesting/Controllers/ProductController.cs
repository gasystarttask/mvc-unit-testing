using System;
using System.Web.Mvc;

namespace MvcUnitTesting.Controllers
{
    public class ProductController : Controller
    {
        // GET
        public ActionResult Index()
        {
            // Add action logic here
            throw new NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            if (id < 1)
                return RedirectToAction("Index");
            var product = new Product(id,"Laptop");
            return 
            View("Details", product);
        }
    }
}