using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatters
{
    public class Moderado : Investimentos
    {

        public double RetonoInvestido(Conta conta)
        {
            Console.WriteLine("MODERADO");
            bool escolhido = new Random().Next(101) > 50;
            double retornoTotal;

            if (escolhido)
            {
                retornoTotal = (conta.Valor * 0.025);
                retornoTotal =+ (retornoTotal * 0.75);
                Console.WriteLine("Retorno com 2.5% do valor investido: " + retornoTotal);
                return retornoTotal;
            }
            else {
                retornoTotal = (conta.Valor * 0.007);
                retornoTotal = +(retornoTotal * 0.75);
                Console.WriteLine("Retorno com 0.07% do valor investido: " + retornoTotal);
                return retornoTotal;
            }
        }
    }
}
