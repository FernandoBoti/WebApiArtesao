using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiArtesao.Models
{

    public class CustoFixo
    {
        private string Descricao { get; set; }
        private double Valor { get; set; }

        public CustoFixo(string descricao, double valor)
        {

            Descricao = descricao;
            Valor = valor;

        }
    }
}