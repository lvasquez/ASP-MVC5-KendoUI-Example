using KendoGridJS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoGridJS.Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Read()
        {

            IList<CategoryViewModel> list = new List<CategoryViewModel>()
            {
                new CategoryViewModel() { CategoryID = 1, CategoryName = "Fruits", Description = "Only Fruits" },
                new CategoryViewModel() { CategoryID = 2, CategoryName = "No Fruits", Description = "Only No Fruits" }
            };

            return Json(list.ToList());
        }

        [HttpPost]
        public ActionResult Create(IEnumerable<CategoryViewModel> categories)
        {
            IList<CategoryViewModel> list = new List<CategoryViewModel>()
            {
                new CategoryViewModel() { CategoryID = 1, CategoryName = "Fruits", Description = "Only Fruits" },
                new CategoryViewModel() { CategoryID = 2, CategoryName = "No Fruits", Description = "Only No Fruits" }
            };


            return Json(list.ToList());
        }


        [HttpPost]
        public ActionResult Update(IEnumerable<CategoryViewModel> categories)
        {

            return Json(null);
        }


        [HttpPost]
        public ActionResult Delete(IEnumerable<CategoryViewModel> categories)
        {

            return Json(null);
        }
    }
}