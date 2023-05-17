﻿namespace CursoDesignPatters
{
    class Program
    {
        static void Main(string[] args)
        {

            Imposto iss = new ISS();
			Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500.0);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizarCalculo(orcamento, icms);
			calculador.RealizarCalculo(orcamento, iss);

            Console.ReadKey();
		}        
    }
}