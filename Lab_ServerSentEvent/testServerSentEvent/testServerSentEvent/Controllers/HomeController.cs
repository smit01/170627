using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testServerSentEvent.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "SSE WITH ASP.NET MVC";
            return View();
        }

        public ActionResult Message() {
            var result = new System.Text.StringBuilder();
            result.AppendFormat("data: {0:HH:mm:ss}\n\n", DateTime.Now);
            return Content(result.ToString(), "text/event-stream");
        }
    }

}