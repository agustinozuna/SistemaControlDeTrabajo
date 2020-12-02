using System;
using System.Collections.Generic;
using SistemaControlDeTrabajo.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaControlDeTrabajo.Controllers
{
    [Authorize]
    public class MantenimientoController : Controller
    {
        private ElectroparEntities db = new ElectroparEntities();
        // GET: Mantenimiento
        public ActionResult Index()
        {
            var listaMant = db.Mantenimiento.ToList();
            return View(listaMant);
        }

        public ActionResult Crear()
        {
            return View();
        }
    }
}