using System;
using System.Collections.Generic;
using RoomBooking.Domain.Enums;

namespace RoomBooking.Domain.Entities
{
    public class Book
    {
        public Book(Room room, DateTime startTime, DateTime endDate)
        {

            Id = Guid.NewGuid();
            Room = room;
            Status = EBookStatus.InProgress;
            StartTime = startTime;
            EndTime = endDate;
        }

        public Guid Id { get; private set; }
        public Room Room { get; private set; }
        public EBookStatus Status { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public void Confirm(IList<DateTime> holidays, IList<DateTime> booksForThisPeriod)
        {
            //Verificar se data inicio está na lista de feriados
            //verificar se data inicio esta na lista de reservas

            if (Status != EBookStatus.InProgress)
                throw new Exception("Error");

            Status = EBookStatus.Reserved;
        }

        public void MarkAsInProgress()
        {
            Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            if ((StartTime - DateTime.Now).Hours < 2)
                throw new Exception("Error");

            Status = EBookStatus.Canceled;
        }

        public void MarkAsCompleted()
        {
            Status = EBookStatus.Completed;
        }
    }
}
