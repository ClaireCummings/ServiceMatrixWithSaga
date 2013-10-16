using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LFMSubmissions.InternalMessages.LandRegistry;
using LFMSubmissions.LandRegistry;

namespace LFM.Submissions.Client.Controllers
{
    public class HomeController : Controller
    {
        public ISubmitEdrsSender SubmitEdrsSender { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {

            SubmitEdrsSender.Send(new SubmitEdrs(){ApplicationId = Guid.NewGuid().ToString()});
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
