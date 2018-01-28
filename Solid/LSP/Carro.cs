using System;

namespace Solid.LSP
{
    public class Carro : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("ligou no filho");
            base.Acelerar();
        }
    }
}
