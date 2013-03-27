using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carros.Models
{
    public class Carro
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string urlFoto { get; set; }
        public string urlInformacao { get; set; }
    }
}