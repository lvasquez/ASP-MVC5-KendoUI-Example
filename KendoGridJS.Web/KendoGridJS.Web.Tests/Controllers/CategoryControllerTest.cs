using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KendoGridJS.Web.Controllers;
using System.Web.Mvc;
using KendoGridJS.Web.Models;
using System.Linq;

namespace KendoGridJS.Web.Tests.Controllers
{
    /// <summary>
    /// Summary description for CategoryControllerTest
    /// </summary>
    [TestClass]
    public class CategoryControllerTest
    {

        [TestMethod]
        public void Index_Return_NotNull()
        {
            var controller = new CategoryController();

            var result = controller.Index();
            var rresult = (ActionResult)result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(rresult, typeof(ActionResult));
        }


        [TestMethod]
        public void Read_Return_NotNull()
        {
            var controller = new CategoryController();

            var result = controller.Read();
            var rresult = (JsonResult)result;
            var listResult = (IEnumerable<CategoryViewModel>)rresult.Data;

            Assert.IsInstanceOfType(rresult.Data, typeof(IList<CategoryViewModel>));
            Assert.IsNotNull(result);
            Assert.AreEqual(listResult.Count(), 2);
        }


        [TestMethod]
        public void Create_Return_NotNull()
        {
            var controller = new CategoryController();

            IList<CategoryViewModel> list = new List<CategoryViewModel>();

            var result = controller.Create(list);
            var rresult = (JsonResult)result;
            var listResult = (IEnumerable<CategoryViewModel>)rresult.Data;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(rresult.Data, typeof(List<CategoryViewModel>));
            Assert.AreEqual(listResult.Count(), 2);
        }

        [TestMethod]
        public void Update_Return_NotNull()
        {
            var controller = new CategoryController();

            IList<CategoryViewModel> list = new List<CategoryViewModel>();

            var result = controller.Update(list);
            var rresult = (JsonResult)result;

            Assert.IsNull(rresult.Data);
            Assert.IsNotInstanceOfType(rresult.Data, typeof(List<CategoryViewModel>));

        }


        [TestMethod]
        public void Delete_Return_NotNull()
        {
            var controller = new CategoryController();

            IList<CategoryViewModel> list = new List<CategoryViewModel>();

            var result = controller.Delete(list);
            var rresult = (JsonResult)result;

            Assert.IsNull(rresult.Data);
            Assert.IsNotInstanceOfType(rresult.Data, typeof(List<CategoryViewModel>));

        }
    }
}
