using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiArtesao.Models;

namespace WebApiArtesao.Controllers
{
    public class SalarioController : Controller
    {
        // GET: CadastraSalario
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetCadastraSalario(decimal salarioDesejado, int qtdDiasTrabalhoSemana, int qtdHorasTrabalhoDia)

        {

            var salario = new Salario(salarioDesejado, qtdDiasTrabalhoSemana, qtdHorasTrabalhoDia);

            salario.CalculaValorDiaTrabalho();
            salario.CalculaValorHoraTrabalho();
            salario.SalvaSalario();

            return Json(new { mensagem = "Ok" }, JsonRequestBehavior.AllowGet);
        }

    }
}