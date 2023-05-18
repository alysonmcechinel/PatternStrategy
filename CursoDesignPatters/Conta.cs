using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatters
{
	public class Conta
	{
        public Conta(double valor)
        {
            this.Valor = valor;
        }

        public double Valor { get; set; }
    }
}
