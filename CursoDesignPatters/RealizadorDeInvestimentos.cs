using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatters
{
	public class RealizadorDeInvestimentos
	{
		public double Investir(Conta conta, Investimentos investimentos)
		{
			double valor = investimentos.CalcInvestimento(conta);
		}
	}
}
