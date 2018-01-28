using System;

namespace Solid.ISP.Contracts
{
    public interface IPedido
    {
        DateTime Data { get; set; }
        void RealizarPedido();
    }
}
