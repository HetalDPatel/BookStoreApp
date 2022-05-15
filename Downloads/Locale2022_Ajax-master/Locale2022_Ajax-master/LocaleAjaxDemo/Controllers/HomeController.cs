using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using LocaleAjaxDemo.Models;

namespace LocaleAjaxDemo.Controllers
{
    public class HomeController : SharedController
    {
        public ActionResult Index()
        {
            int lang = Helper.Helper.Lang;
            EmployeeModel model = new EmployeeModel();

            model.FName = "Nikunj";
            model.LName = "Adhaduk";
            model.EmployeeId = 1;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        public JsonResult Delete(int id)
        {
            //todo delete that employee from database
            return Json("All good!");
        }

    }
}