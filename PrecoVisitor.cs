using System;

namespace VisitorPattern
{
    // Concrete Visitor
    public class PrecoVisitor : IVisitor
    {
        private const int DescontoCarro = 10;

        public void Accept(Carro carro)
        {
            decimal precoCarroComDesconto = carro.Preco - ((carro.Preco / 100) * DescontoCarro);

            Console.WriteLine($"\t{carro.Modelo} {carro.Nome}: ${precoCarroComDesconto} ");
        }
    }
}
