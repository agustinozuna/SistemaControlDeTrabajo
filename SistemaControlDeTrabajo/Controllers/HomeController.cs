using System;
using SistemaControlDeTrabajo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaControlDeTrabajo.Controllers
{
    public class HomeController : Controller
    {
        private ElectroparEntities db = new ElectroparEntities();
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        [HttpPost]
        public ActionResult Index(Contactos contacto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contacto).State = System.Data.Entity.EntityState.Modified;
                contacto.fechaEnvio = DateTime.Now;
                db.Contactos.Add(contacto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }


    }
}