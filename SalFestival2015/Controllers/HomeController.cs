using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalFestival2015.Models;
using SalFestival2015.ViewModels;
using System.Web.Security;
using System.IO;
namespace SalFestival2015.Controllers
{
    public class HomeController : Controller
    {
        salalahDBEntities db = new salalahDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index_old()
        {
            return View();
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

        public ActionResult DArticles()
        {
            var darticles = (from dart in db.tbl_articles
                             where dart.a_loc == "2"
                             orderby dart.a_order
                             select dart);

            return View("_mainarticles", darticles);
        }

        // here we are selecting the top 14 image from the articles to be displayed in the first image
        public ActionResult getImgGal()
        {
            var imgticles = (from dart in db.tbl_articles
                             where dart.a_loc == "1"
                             orderby dart.a_order ascending
                             select dart).Take(9);

            return View(imgticles);
        }


        public ActionResult getMainArt()
        {
            var maArt = (from dart in db.tbl_articles
                         where dart.a_loc == "4"
                         orderby dart.a_order ascending
                         select dart);
            return View("_mainart", maArt);
        }
        public ActionResult getSideAdv()
        {
            var maArt = (from dart in db.tbl_articles
                         where dart.a_loc == "6"
                         orderby dart.a_order ascending
                         select dart);
            return View(maArt);
        }


        public ActionResult gettopAdv()
        {
            var maTopAdv = (from dart in db.tbl_articles
                            where dart.a_loc == "7"
                            orderby dart.a_order ascending
                            select dart).Take(1);
            return View(maTopAdv);
        }

        public ActionResult dailyevents()
        {
            var dEvents = (from dart in db.tbl_articles
                           where dart.a_loc == "8"
                           orderby dart.Id descending , dart.a_order ascending
                           select dart);
            foreach (var item in dEvents)
            {
                ViewBag.AdvId = item.Id;
            }

            ViewBag.DownloadFile = Server.MapPath("~/uploads/festival2015.pdf");
            return View(dEvents);
        }

        // getting the adv details

        public ActionResult GetPostData(int id)
        {
            var maArt = (from dart in db.tbl_articles
                         where dart.Id == id && dart.a_loc == "6"
                         orderby dart.a_order ascending
                         select dart);

            return PartialView("_sideadv", maArt);
            //return PartialView("_dataList");
        }


        // News Carousel

        public ActionResult newCarouse()
        {
            return View();
        }

      //shooting contest application
      public ActionResult contestApp()
        {
            return View();
        }

        
    }
}