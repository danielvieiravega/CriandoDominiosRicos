using System;

namespace Solid.SRP.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Salvar(Fornecedor fornecedor)
        {
            Console.WriteLine("Salvei");
        }
    }
}
