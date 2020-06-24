using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiArtesao.Models
{
    public class Orcamento: IPrecificador
    {
        public double ValorTotalMateriais { get; set; }
        
        public Orcamento(List<Material> ListaMateriais) { 
            
         
            
        }

        public void CalculaPreco() { 
            

        }
    }
}