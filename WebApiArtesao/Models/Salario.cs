using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiArtesao.Models
{


    public class Salario
    {

        private decimal SalarioDesejado { get; set; }

        private int QtdDiasTrabalhoMes { get; set; }

        private int QtdDiasTrabalhoSemana { get; set; }

        private int QtdHorasTrabalhoDia { get; set; }

        private decimal ValorDiaTrabalho { get; set; }

        private decimal ValorHoraTrabalho { get; set; }

        public Salario(decimal salarioDesejado, int qtdDiasTrabalhoSemana, int qtdHorasTrabalhoDia)
        {

            SalarioDesejado = salarioDesejado;
            QtdDiasTrabalhoSemana = qtdDiasTrabalhoSemana;
            QtdHorasTrabalhoDia = qtdHorasTrabalhoDia;
            QtdDiasTrabalhoMes = qtdDiasTrabalhoSemana * 4;

        }



        public void CalculaValorDiaTrabalho() {

            ValorDiaTrabalho = SalarioDesejado / QtdDiasTrabalhoMes;


        }

        public void CalculaValorHoraTrabalho() {

            ValorHoraTrabalho = ValorDiaTrabalho / QtdHorasTrabalhoDia;
        }

        public void SalvaSalario() {


        }

        public void BuscaSalario() {

        }

        public void AtualizaSalario() { 
        
        }

        public void DeletaSalario() { 
        
        }





    }
}