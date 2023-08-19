using CascadeDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadeDropDown.Controllers
{
    public class HomeController : Controller
    {
        private Context12 _context = new Context12();

        [HttpGet]
        public ActionResult CascadeList()
        {
            ViewBag.Countries = new SelectList(_context.Countries, "Id", "Name");
            return View();
        }
        public JsonResult LoadState(int countryId)
        {
            var states = _context.States.Where(s => s.CountryId == countryId).ToList();
            return Json(new SelectList(states, "Id", "Name"), JsonRequestBehavior.AllowGet);
        }

        public JsonResult LoadCity(int stateId)
        {
            var cities = _context.Cities.Where(c => c.StateId == stateId).ToList();
            return Json(new SelectList(cities, "Id", "Name"), JsonRequestBehavior.AllowGet);
        }
    }
}
