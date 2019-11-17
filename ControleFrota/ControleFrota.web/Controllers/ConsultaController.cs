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
        public ActionResult ConsultaMotorista()
        {
            SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-SOKKM3N\SQLEXPRESS;Initial Catalog=controle-frota;User Id=admin;Password=123");
            conexao.Open();

            string resultadoPesquisa = "SELECT * FROM db_owner.motoristas";
            SqlCommand cmdComandoSelect = new SqlCommand(resultadoPesquisa, conexao);
            SqlDataReader dados = cmdComandoSelect.ExecuteReader();




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