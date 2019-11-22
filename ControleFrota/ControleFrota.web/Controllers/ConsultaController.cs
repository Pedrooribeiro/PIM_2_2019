using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControleFrota.web.Models;
namespace ControleFrota.web.Controllers
{
    public class ConsultaController : Controller
    {

        [Authorize]
        public ActionResult ConsultaMotorista(string searching)
        {
            //SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-SOKKM3N\SQLEXPRESS;Initial Catalog=controle-frota;User Id=admin;Password=123");
            //conexao.Open();

            //string resultadoPesquisa = "SELECT * FROM motoristas";
            //SqlCommand cmdComandoSelect = new SqlCommand(resultadoPesquisa, conexao);
            // SqlDataReader dados = cmdComandoSelect.ExecuteReader();

            //ViewBag.Id = 6;
            //ViewBag.Nome = "Pedro";
            //ViewBag.Rg = 646465464;
            //ViewBag.Cpf = 4986575967;
            //ViewBag.Cnh = 65465465;
            //ViewBag.Vencimento = "23 / 10 / 2025";
            //ViewBag.Empresa = "Indra";

            Entities db = new Entities();

            return View(db.motoristas.Where(x=>x.cpf.Contains(searching) || searching == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaMulta()
        {
            ViewBag.Id = 6;
            ViewBag.Nome = "Pedro";
            ViewBag.Rg = 646465464;
            ViewBag.Cpf = 4986575967;
            ViewBag.Cnh = 65465465;
            ViewBag.Vencimento = "23 / 10 / 2025";
            ViewBag.Empresa = "Indra";
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