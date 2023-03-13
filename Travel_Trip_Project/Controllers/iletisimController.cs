using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel_Trip_Project.Models.Sınıflar;

namespace Travel_Trip_Project.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        Context c = new Context();
        public ActionResult Index()
        {
            var iletisim = c.İletisims.ToList();
            return View(iletisim);
        }
        [HttpPost]
        public ActionResult MesajGonder(iletisim i)
        {
            c.İletisims.Add(i);
            c.SaveChanges();
            return RedirectToAction("iletisim");
        }
    }
}