using BussinessObjects;
using DataAccessObject;
using Reponsitory;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsitory
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerDAO customerDAO;

        public CustomerRepository()
        {
            customerDAO = getInstance();
        }

        private CustomerDAO getInstance()
        {
            if (customerDAO == null)
            {
                customerDAO = new CustomerDAO();
            }
            return customerDAO;
        }

        public void DeleteCustomer(Customer c) => customerDAO.DeleteCustomer(c);
        public void SaveCustomer(Customer c) => customerDAO.SaveCustomer(c);
        public void UpdateCustomer(Customer c) => customerDAO.UpdateCustomer(c);
        public ObservableCollection<Customer> GetCustomers() => customerDAO.GetCustomers();
        public Customer GetCustomerById(int id) => customerDAO.GetCustomerById(id);
        public Customer GetCustomerByEmail(string email) => customerDAO.GetCustomerByEmail(email);
    }
}
