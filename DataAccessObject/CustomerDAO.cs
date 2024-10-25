using BussinessObjects;
using System.Collections.ObjectModel;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        private static ObservableCollection<Customer> customers;

        private ObservableCollection<Customer> getInstance()
        {
            if (customers == null)
            {
                Customer cus1 = new Customer(3, "William Shakespeare", "0903939393", "WilliamShakespeare@FUMiniHotel.org", Convert.ToDateTime("02/02/1990"), 1, "123@");
                Customer cus2 = new Customer(5, "Elizabeth Taylor", "0903939377", "ElizabethTaylor@FUMiniHotel.org", Convert.ToDateTime("03/03/1990"), 1, "144@");
                Customer cus3 = new Customer(8, "James Cameron", "0903946582", "JamesCameron@FUMiniHotel.org", Convert.ToDateTime("10/10/1992"), 1, "443@");
                Customer cus4 = new Customer(9, "Charles Dickens", "0903955633", "CharlesDickens@FUMiniHotel.org", Convert.ToDateTime("05/12/1991"), 1, "563@");
                Customer cus5 = new Customer(10, "George Orwell", "0913933493", "GeorgeOrwell@FUMiniHotel.org", Convert.ToDateTime("05/12/1993"), 1, "177@");
                Customer cus6 = new Customer(11, "Victoria Beckham", "0983246773", "VictoriaBeckham@FUMiniHotel.org", Convert.ToDateTime("09/09/1990"), 1, "654@");
                customers = new ObservableCollection<Customer> { cus1, cus2, cus3, cus4, cus4, cus5, cus6 };
            }
            return customers;
        }

        public CustomerDAO()
        {
            customers = getInstance();
        }

        public ObservableCollection<Customer> GetCustomers()
        {
            return customers;
        }
        public void SaveCustomer(Customer c)
        {
            c.CustomerId = customers.Count + 1;
            customers.Add(c);
        }

        public void UpdateCustomer(Customer customer)
        {
            foreach (Customer c in customers.ToList())
            {
                if (c.CustomerId == customer.CustomerId)
                {
                    c.CustomerId = customer.CustomerId;
                    c.CustomerFullName = customer.CustomerFullName;
                    c.Telephone = customer.Telephone;
                    c.EmailAddress = customer.EmailAddress;
                    c.CustomerBirthday = customer.CustomerBirthday;
                    c.CustomerStatus = customer.CustomerStatus;
                    c.Password = customer.Password;
                }
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            foreach (Customer c in customers.ToList())
            {
                if (c.CustomerId == customer.CustomerId)
                {
                    customers.Remove(c);
                    break;
                }
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            foreach (Customer c in customers.ToList())
            {
                if (c.CustomerId == customerId)
                {
                    return c;
                }
            }
            return null;
        }

        public Customer GetCustomerByEmail(string email)
        {
            foreach (Customer c in customers.ToList())
            {
                if (c.EmailAddress.Equals(email))
                {
                    return c;
                }
            }
            return null;
        }
    }
}

