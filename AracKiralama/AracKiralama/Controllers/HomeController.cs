using AracKiralama.Models.Veritabani;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AracKiralama.Controllers
{
    public class HomeController : Controller
    {
        

        AracKiralamaEntities db = new AracKiralamaEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UyeOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeOl(müşteri m)
        {
            db.müşteri.Add(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BireyselGiris()
        {
            return View();
        }

        public ActionResult KurumsalGiris()
        {
            return View();
        }

        public ActionResult Rezervasyon()
        {
            return View();
        }
    }
}



