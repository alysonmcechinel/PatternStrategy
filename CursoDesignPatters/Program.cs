namespace CursoDesignPatters
{
    /*class Program
    {
        static void Main(string[] args)
        {

            Imposto iss = new ISS();
			Imposto icms = new ICMS();
			//Imposto iccc = new ICCC();
			//calculador.RealizarCalculo(orcamento, iccc);

			Console.WriteLine("escreva o valor total do orçamento");
			double total = Convert.ToDouble(Console.ReadLine());

			Orcamento orcamento = new Orcamento(total);
			CalculadorDeImpostos calculador = new CalculadorDeImpostos();

			calculador.RealizarCalculo(orcamento, icms);
			calculador.RealizarCalculo(orcamento, iss);

			Console.ReadKey();
		}
	}*/

	

	class Exec1
	{
		static void Main(String[] args)
		{
			Orcamento reforma = new Orcamento(500);
			//Orcamento reforma = new Orcamento(1500);
			//Orcamento reforma = new Orcamento(4000);

			Imposto novoImposto = new ICCC();
			Console.WriteLine(novoImposto.Calcula(reforma));
		}
	}
}