using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagingandSortingUsingJQuery.Models;

namespace PagingandSortingUsingJQuery.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            DBModel dBModel = new DBModel();
            var countryList = dBModel.countries.ToList<country>();
            return Json(new { data = countryList }, JsonRequestBehavior.AllowGet);
        }
    }
}