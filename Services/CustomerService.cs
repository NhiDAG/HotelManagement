using BussinessObjects;
using Reponsitory;
using Responsitory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository iCustomerRepository;
        public CustomerService()
        {
            iCustomerRepository = new CustomerRepository();
        }

        public void DeleteCustomer(Customer c)
        {
            iCustomerRepository.DeleteCustomer(c);
        }
        public void SaveCustomer(Customer c)
        {
            iCustomerRepository.SaveCustomer(c);
        }
        public void UpdateCustomer(Customer c)
        {
            iCustomerRepository.UpdateCustomer(c);
        }
        public Customer GetCustomerById(int id)
        {
            return iCustomerRepository.GetCustomerById(id);
        }
        public Customer GetCustomerByEmail(string email)
        {
            return iCustomerRepository.GetCustomerByEmail(email);
        }
        public ObservableCollection<Customer> GetCustomers()
        {
            return iCustomerRepository.GetCustomers();
        }

    }
}
