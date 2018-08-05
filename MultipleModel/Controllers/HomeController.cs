using MultipleModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleModel.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            var a = db.ModelAs.SqlQuery("select *from ModelAs");
            var b = db.ModelBs.SqlQuery("select *from ModelBs");
            var viewModel = new ViewModel()
            {
                ModelAs = a,
                ModelBs = b
            };
            return View(viewModel);
        }

        public ActionResult partial()
        {
            var b = db.ModelBs.SqlQuery("select *from ModelBs");
            return View(b);
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
    }
}