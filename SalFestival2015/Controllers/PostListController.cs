using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalFestival2015.Models;
using System.Linq.Dynamic;
using SalFestival2015.ViewModels;
namespace SalFestival2015.Controllers
{

    public class PostListController : Controller
    {
        private salalahDBEntities db = new salalahDBEntities();
        // GET: Admin/PostList
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult GetPostData(int page = 1, string sort = "post_title", string sortdir = "DESC")
        {
            PostDataModel cdm = new PostDataModel();
            cdm.PageSize = 4;
            using (salalahDBEntities dc = new salalahDBEntities())
            {
                cdm.TotalRecord = dc.tbl_posts.Count();
                cdm.NoOfPages = (cdm.TotalRecord / cdm.PageSize) + ((cdm.TotalRecord % cdm.PageSize) > 0 ? 1 : 0);
                cdm.mPost = dc.tbl_posts.OrderBy(sort + " " + sortdir).Skip((page - 1) * cdm.PageSize).Take(cdm.PageSize).ToList();
            }
            return PartialView("_dataList", cdm);
            //return PartialView("_dataList");
        }


    }
}

