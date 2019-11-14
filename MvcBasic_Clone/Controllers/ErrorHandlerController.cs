﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class ErrorHandlerController : Controller
    {
        // GET: ErrorHandler
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ErrorMessage()
        {
            if (!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult();  // 等同return null
            }

            TempData.Keep(); // 指示系統保留TempData資料，不要清除
            //TempData.Keep("ErrorMessage"); 若要保留特定Key的資料時

            return View();
        }
    }
}