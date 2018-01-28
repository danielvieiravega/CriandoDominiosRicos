using System;

namespace Solid.LSP
{
    public abstract class Veiculo
    {
        public virtual void LigarMotor()
        {
            Console.WriteLine("Ligou o motor (pai)");
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("acelerou (pai)");
        }
    }
}
