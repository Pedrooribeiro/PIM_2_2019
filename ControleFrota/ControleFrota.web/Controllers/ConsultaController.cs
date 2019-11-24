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
        public ActionResult ConsultaMotorista(string cpfConsultado)
        {
            Entities db = new Entities();

            return View(db.motoristas.Where(x=>x.cpf.Equals(cpfConsultado) || cpfConsultado == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaMulta(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.multas.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaPeca(string nomePecaConsultada)
        {
            Entities db = new Entities();
            return View(db.estoque_peca.Where(x => x.nome.Equals(nomePecaConsultada) || nomePecaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaVeiculo(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.veiculos.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaPneu(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.pneus.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaAbastecimento(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.abastecimentos.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaAluguel(string cpfConsultado)
        {
            Entities db = new Entities();
            return View(db.aluguel_veiculos.Where(x => x.cpf.Equals(cpfConsultado) || cpfConsultado == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaEntrada(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.entradas.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaSaida(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.saidas.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaManutencao(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.manutencoes.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaQuilometragem(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.quilometragem.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaRota(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.viagens.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaSeguro(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.seguros.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

        [Authorize]
        public ActionResult ConsultaSinistro(string placaConsultada)
        {
            Entities db = new Entities();
            return View(db.sinistros.Where(x => x.placa.Equals(placaConsultada) || placaConsultada == null).ToList());
        }

    }
}