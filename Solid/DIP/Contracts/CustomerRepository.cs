using System;

namespace Solid.DIP.Contracts
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Save(string name)
        {
            Console.WriteLine(name);
        }
    }
}
