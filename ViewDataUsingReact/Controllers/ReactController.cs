using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDataUsingReact.Controllers
{
    public class ReactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployeeData()
        {
            using ( databaseModel dc = new databaseModel())
            {
                var data = dc.Employees.OrderBy(a => a.FirstName).ToList();
                return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }


    }
}