using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatters
{
    public class Conservador : Investimentos
    {
        public double RetonoInvestido(Conta conta)
        {
            Console.WriteLine("CONSERVADOR");
            double retornoTotal = (conta.Valor * 0.008);
            retornoTotal = +(retornoTotal * 0.75);
            Console.WriteLine("Retorno com 0.8% do valor investido: " + retornoTotal);
            return retornoTotal;
        }
    }
}
