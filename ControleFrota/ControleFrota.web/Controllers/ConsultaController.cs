using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFrota.web.Controllers
{
    public class ConsultaController : Controller
    {

        [Authorize]
        public ActionResult ConsultaMotorista()
        {
            return View();
        }

        [Authorize]
        public ActionResult ConsultaMulta()
        {
            return View();
        }

        [Authorize]
        public ActionResult ConsultaPeca()
        {
            return View();
        }

        [Authorize]
        public ActionResult ConsultaVeiculo()
        {
            return View();
        }

        [Authorize]
        public ActionResult ConsultaPneu()
        {
            return View();
        }
    }
}