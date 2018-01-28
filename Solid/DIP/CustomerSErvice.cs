using Solid.DIP.Contracts;

namespace Solid.DIP
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void Register(string name)
        {
            _repository.Save(name);
        }
    }
}
