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


      


            var listaContrato = db.Contrato.ToList();
          //  ViewData["contratos"] = listaContrato.AsEnumerable();

            var selectListContrato = new SelectList(listaContrato, "CodContrato", "NroContrato", 2);
            ViewData["contratos2"] = selectListContrato;


            var listaEmpleados = db.Personal.ToList();
            //ViewData["empleados"] = listaEmpleados.AsEnumerable();


            var selectListPersonal = new SelectList(listaEmpleados, "CodPersonal", "NombreApellido", 2);
            ViewData["empleados2"] = selectListPersonal;

            return View();
        }

        [HttpPost]
        public ActionResult Crear(Mantenimiento mant)
        {
            if (ModelState.IsValid)
            {
                mant.FechaRealizacion = DateTime.Now;
                db.Mantenimiento.Add(mant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mant);
        }
    }
}