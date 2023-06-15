using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emprestimo_de_Livro.Controller
{
    internal class Livro
    {
      
        public Livro() { }

        private decimal num;

        public decimal CalcularDesc(string desc, decimal valor)
        {
            switch (desc)
            {
                case "10%":
                    this.num = valor - (valor * 0.1m);
                    break;
                case "20%":
                    this.num = valor - (valor * 0.2m);
                    break;
                case "30%":
                    this.num = valor - (valor * 0.3m);
                    break;
            }
            return num;
        }

       
    }
}
