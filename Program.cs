using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var carros = new List<Carro>();
            carros.Add(new Carro() { Nome = "A1", Preco = 2000M, Modelo = "Mercedes" });
            carros.Add(new Carro() { Nome = "458", Preco = 3500M, Modelo = "Ferrari" });
            carros.Add(new Carro() { Nome = "718 GTS", Preco = 2800M, Modelo = "Porsche" });

            Console.WriteLine("Preços dos carros\n");

            var lojas = new List<ILoja>();
            foreach (var carro in carros)
            {
                Console.WriteLine($"\t{carro.Modelo} {carro.Nome}: ${carro.Preco}");
                lojas.Add(carro);
            }

            Console.WriteLine("\nPreços dos carros com desconto de 10%\n");

            PrecoVisitor precoVisitor = new PrecoVisitor();
            foreach (var element in lojas)
                element.Visit(precoVisitor);
        }
    }
}
