using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiArtesao.Models
{
    public class Lucro
    {
        private decimal PercentualLucro { get; set; }

        public Lucro(decimal percentualLucro) {

            PercentualLucro = percentualLucro;

            
        }
    }
}