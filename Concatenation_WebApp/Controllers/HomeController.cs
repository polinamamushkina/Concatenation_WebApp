using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Concatenation_WebApp.Models;

namespace Concatenation_WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        SetStr strInput = new SetStr();

        public ActionResult Index()
        {
            return View();
        }

        /*public ActionResult Info()
        {
            ViewBag.Message = "Your info page.";

            return View();
        }*/

        [HttpGet]
        public ActionResult GetInfo()
        {
            ViewBag.Message = "Here you can input some words to concatenate them.";

            return View();
        }

        [HttpPost]
        public string GetInfo(Purchase purchase)
        {
            strInput.SetStrFromWeb(purchase.Words);
            string result = strInput.Concat().ToArray()[0] + " ";
            for (int i = 1; i < strInput.Concat().ToArray().Length; i++)
                result += (strInput.Concat().ToArray()[i] + " ");
            return result;
        }
    }
}