using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> names = new List<string>();
            names.Add("Art Deco Furniture");
            names.Add("Sectional Sofa");
            names.Add("Appliance Garage");
            names.Add("Glass-front Cabinet");
            names.Add("Kitchen Island");
            names.Add("Room divider/screen");
            names.Add("Window treatments (curtains, blinds)");
            names.Add("Decorative pillows");
            ViewBag.data = names;
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Testimonial()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
    }
}



