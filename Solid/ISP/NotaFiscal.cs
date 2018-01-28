using System;
using Solid.ISP.Contracts;

namespace Solid.ISP
{
    public class NotaFiscal : IPedido, IEnderecoComercial
    {
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }

        public void RealizarPedido()
        {
            throw new NotImplementedException();
        }

    }
}
