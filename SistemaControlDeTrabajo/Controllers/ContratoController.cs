using System;
using System.Collections.Generic;
using SistemaControlDeTrabajo.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaControlDeTrabajo.Controllers
{
    [Authorize]
    public class ContratoController : Controller
    {
        private ElectroparEntities db = new ElectroparEntities();
        // GET: Contrato
        public ActionResult Index()
        {
            var listaContrato = db.Contrato.ToList();
            return View(listaContrato);
        }
    }
}