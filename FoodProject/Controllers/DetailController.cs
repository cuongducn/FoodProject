using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodProject.Models;
namespace FoodProject.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        DOAN3Entities2 db = new DOAN3Entities2();
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Contact()
        {
            return View();
        }
    }
}
