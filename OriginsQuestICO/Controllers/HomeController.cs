using OriginsQuestICO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OriginsQuestICO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var vm = new HomeIndexViewModel()
            {
                ContactForm = new ContactFormViewModel(),
                Subscribe = new SubscribeViewModel(),
            };

            return View(vm);
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
    }
}