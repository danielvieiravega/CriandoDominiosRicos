using System.Runtime.InteropServices;
using Solid.DIP;
using Solid.DIP.Contracts;
using Solid.ISP;
using Solid.LSP;
using Solid.OCP;
using Solid.SRP;
using Solid.SRP.Repository;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SRP
            //var fornecedor = new Fornecedor();
            //fornecedor.ChangeName("André");
            //var rep = new FornecedorRepository();
            //rep.Salvar(fornecedor);
            #endregion

            #region OCP
            //var p = new Pessoa("Daniel");
            //p.ChangeName("jose");
            //var pf = new PessoaFisica("Andre", "fgfdfddfsfds");
            #endregion

            #region LSP
            //var veiculo = new Carro();
            //veiculo.Acelerar();
            #endregion

            #region ISP
            var nf = new NotaFiscal();
            #endregion

            #region DIP
            //var customerService = new CustomerService(new CustomerRepository());
            #endregion
        }
    }
}
