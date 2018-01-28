using System;

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

        public void Book()
        {

        }
    }
}
