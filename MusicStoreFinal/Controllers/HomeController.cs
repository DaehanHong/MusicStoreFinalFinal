using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    [RequireHttps]
    [Route("home/{action=index}")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Welcome Our Music Store Web site!";
            ViewBag.Message = "We are a world renowned Music Store with latest Music";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "This is our Contact Page.";
            ViewBag.Message = "If you have any problem, don't hesitate. Please contact us. ";

            return View();
        }
    }
}