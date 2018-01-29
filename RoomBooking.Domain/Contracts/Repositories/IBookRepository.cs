using System;
using System.Collections.Generic;
using RoomBooking.Domain.Entities;

namespace RoomBooking.Domain.Contracts.Repositories
{
    public interface IBookRepository : IDisposable
    {
        IList<Book> GetBooksByDateRange(DateTime startDate, DateTime endDate);
    }
}
