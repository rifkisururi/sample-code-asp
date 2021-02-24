using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private databaseEntities db = new databaseEntities();

        public ActionResult Index(string pencarian = "")
        {
            return View( WebApp.Models.barangModel.getData(pencarian));            
        }

        public ActionResult pembalikKata(string kata = "")
        {
            int jumlahKarakter;
            string output;
            output = "";
            jumlahKarakter = kata.Length - 1;
            for (int i = jumlahKarakter; i >= 0; i--) {
                output = System.String.Concat( output, kata.Substring(i, 1) );

            }

            

            ViewBag.kataTerbalik = output;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}