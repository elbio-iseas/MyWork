
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Marathon.Models;

namespace Marathon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Web application.";
            return View();
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

        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.Message = "Your annual marathon registration.";

            return View();
        }

        [HttpPost]
        public ActionResult Registration(Participant newParticipant)
        {
            var marathon = new List<Participant>();

            if (Session["Marathon"] != null)
            {
                marathon = (List<Participant>)Session["Marathon"];

            }

            marathon.Add(newParticipant);

            Session["Marathon"] = marathon;

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }        

        public ActionResult Participants()
        {

            var marathon = new List<Participant>();

            if (Session["Marathon"] != null)
            {
                marathon = (List<Participant>)Session["Marathon"];
            }

            return View(marathon);
        }
    }
}