using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carros.Models
{
    public class ListaDeCarros
    {
        public List<Carro> Carros{ get; set; }

        public ListaDeCarros()
        {
            this.Carros = new List<Carro>();
        }
    }
}