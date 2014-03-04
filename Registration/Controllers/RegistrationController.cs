using Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration
        RS_Unit unit = new RS_Unit();
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegistrationModel Model)
        {
            if (ModelState.IsValid)
            {
                unit.Registrations.Add(Model);
                unit.SaveChanges();
                return RedirectToAction("Success");
            }
            return View();
        }


        public ActionResult Success()
        {

            return View();
        }


    }
}
