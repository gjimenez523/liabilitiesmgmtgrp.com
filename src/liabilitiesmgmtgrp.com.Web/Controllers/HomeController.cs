using Microsoft.AspNetCore.Mvc;

namespace liabilitiesmgmtgrp.com.Web.Controllers
{
    public class HomeController : comControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}