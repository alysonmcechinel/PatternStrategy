using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatters
{
	public class RealizadorDeInvestimentos
	{
		public double CalcInvestimento(Conta conta, Investimentos investimentos)
		{
            double valor = investimentos.RetonoInvestido(conta);
			Console.WriteLine("Valor total de sua conta: " + (valor + conta.Valor));
			return valor;
		}
	}
}
