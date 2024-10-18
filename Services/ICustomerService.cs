using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService
    {
        void SaveCustomer(Customer c);
        void DeleteCustomer(Customer c);
        void UpdateCustomer(Customer c);
        ObservableCollection<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        Customer GetCustomerByEmail(string email);
    }
}
