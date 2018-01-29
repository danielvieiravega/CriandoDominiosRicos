using System;

namespace RoomBooking.Domain.Contracts.Services
{
    public interface IBookService : IDisposable
    {
        /// <summary>
        /// Orquestra a reserva de uma sala
        /// </summary>
        /// <remarks>
        /// Recupera o usuário
        /// Recupera a sala
        /// Tenta efeturar a reserva
        /// Notifica o usuário
        /// </remarks>
        void PlaceBook(DateTime startDate, DateTime endDate, Guid room);
    }
}
