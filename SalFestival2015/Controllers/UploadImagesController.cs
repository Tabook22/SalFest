﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalFestival2015.ViewModels;

namespace SalFestival2015.Controllers
{

    public class UploadImagesController : Controller
    {
        // GET: Admin/UploadImages
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            //foreach (string item in Request.Files)
            //{
            //    HttpPostedFileBase file = Request.Files[item] as HttpPostedFileBase;
            //    if (file.ContentLength == 0)
            //        continue;
            //    if (file.ContentLength > 0)
            //    {
            //        // width + height will force size, care for distortion
            //        //Exmaple: ImageUpload imageUpload = new ImageUpload { Width = 800, Height = 700 };

            //        // height will increase the width proportionally
            //        //Example: ImageUpload imageUpload = new ImageUpload { Height= 600 };

            //        // width will increase the height proportionally
            //        ImageUpload imageUpload = new ImageUpload { Width = 600 };

            //        // rename, resize, and upload
            //        //return object that contains {bool Success,string ErrorMessage,string ImageName}
            //        ImageResult imageResult = imageUpload.RenameUploadFile(file);
            //        if (imageResult.Success)
            //        {
            //            //TODO: write the filename to the db
            //            Console.WriteLine(imageResult.ImageName);
            //        }
            //        else
            //        {
            //            // use imageResult.ErrorMessage to show the error
            //            ViewBag.Error = imageResult.ErrorMessage;
            //        }
            //    }
            //}

            return View();
        }
    }
}