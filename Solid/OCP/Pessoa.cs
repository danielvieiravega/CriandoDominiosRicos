using System;

namespace Solid.OCP
{
    public class Pessoa
    {
        public Pessoa(string name)
        {
            if (name.Length < 3)
                throw new Exception("nome invalido");

            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

        public void ChangeName(string name)
        {
            Name = name;
        }
    }
}
