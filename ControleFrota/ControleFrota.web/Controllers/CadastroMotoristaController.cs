using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFrota.web.Controllers
{
    public class CadastroMotoristaController : Controller
    {
        // GET: CadastroMotorista
        [Authorize]
        public ActionResult CadastroMotorista()
        {
            return View();
        }

        [Authorize]
        public ActionResult ExcluiMotorista()
        {
            return View();
        }

        [Authorize]
        public ActionResult ConsultaMotorista()
        {
            return View();
        }
    }
}