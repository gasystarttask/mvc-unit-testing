using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcUnitTesting.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            if (!(controller.Details(2) is ViewResult result)) return;
            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod]
        public void TestDetailsViewData()
        {
            var controller = new ProductController();
            if (!(controller.Details(2) is ViewResult result)) return;
            var product = (Product)result.ViewData.Model;
            Assert.AreEqual("Laptop", product.Name);
        }

        [TestMethod]
        public void TestDetailsRedirect()
        {
            var controller = new ProductController();
            var result = (RedirectToRouteResult) controller.Details(-1);
            Assert.AreEqual("Index" as object, result.RouteValues["action"]);
        }
    }
}
