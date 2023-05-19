namespace CursoDesignPatters
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Qual seu valor investido?");
			double valorInvestido = Convert.ToDouble(Console.ReadLine());
			Conta conta = new Conta(valorInvestido);

            Investimentos conservador = new Conservador();
            Investimentos moderado = new Moderado();
            Investimentos arrojado = new Arrojado();

            RealizadorDeInvestimentos investimento = new RealizadorDeInvestimentos();

            investimento.CalcInvestimento(conta, conservador);
            Console.WriteLine("----------------");
            investimento.CalcInvestimento(conta, moderado);
            Console.WriteLine("----------------");
            investimento.CalcInvestimento(conta, arrojado);
            

            Console.ReadKey();
		}
	}
}