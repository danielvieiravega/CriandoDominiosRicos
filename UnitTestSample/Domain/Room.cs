using System;
using System.Collections.Generic;

namespace UnitTestSample.Domain
{
    public class Room
    {
        public Room(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new Exception("Nome invalido");
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateTime Book(DateTime starDateTime, DateTime endDateTime, List<DateTime> books)
        {
            if (books.Contains(StartTime))
            {
                throw  new Exception("Sala já reserada nesse horário");
            }

            return starDateTime;
        }
    }
}
