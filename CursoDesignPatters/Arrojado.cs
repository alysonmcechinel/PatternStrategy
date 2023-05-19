using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatters
{
    public class Arrojado : Investimentos
    {
        public double RetonoInvestido(Conta conta)
        {
            Console.WriteLine("ARROJADO");
            int percChances = new Random().Next(101);
            double retornoTotal;

            switch (percChances)
            {
                case int n when (n <= 20):
                    retornoTotal = (0.05 * conta.Valor);
                    retornoTotal = +(retornoTotal * 0.75);
                    Console.WriteLine("Retorno com 5% do valor investido: " +  retornoTotal);
                    break;

                case int n when (n <= 50):
                    retornoTotal = (0.03 * conta.Valor);
                    retornoTotal = +(retornoTotal * 0.75);
                    Console.WriteLine("Retorno com 3% do valor investido: " +  retornoTotal);
                    break;

                default:
                    retornoTotal = 0.006 * conta.Valor;
                    retornoTotal = +(retornoTotal * 0.75);
                    Console.WriteLine("Retorno com 0.6% do valor investido: " +  retornoTotal);
                    break;
            }

            return retornoTotal;
        }
    }
}
