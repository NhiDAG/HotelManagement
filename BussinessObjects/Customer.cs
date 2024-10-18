using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace BussinessObjects
{
    public partial class Customer : INotifyPropertyChanged
    {
        public int _customerId;
        public string _customerFullName;
        public string _telephone;
        public string _emailAddress;
        public DateTime _customerBirthday;
        public int _customerStatus;
        public string _password;

        public Customer(int id, string fullname,string phone, string email, DateTime birthday, int status, string password)
        {
            this.CustomerId = id;
            this.CustomerFullName = fullname;
            this.Telephone = phone;
            this.EmailAddress = email;
            this.CustomerBirthday = birthday;
            this.CustomerStatus = status;
            this.Password = password;
        }

        public Customer() { }

        public int CustomerId
        {
            get => _customerId;
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    OnPropertyChanged(nameof(CustomerId));
                }
            }
        }

        public string CustomerFullName
        {
            get => _customerFullName;
            set
            {
                if (_customerFullName != value)
                {
                    _customerFullName = value.Length <= 50 ? value : throw new ArgumentException("Full name cannot exceed 50 characters.");
                    OnPropertyChanged(nameof(CustomerFullName));
                }
            }
        }

        public string Telephone
        {
            get => _telephone;
            set
            {
                if (_telephone != value)
                {
                    _telephone = value.Length <= 12 ? value : throw new ArgumentException("Telephone cannot exceed 12 characters.");
                    OnPropertyChanged(nameof(Telephone));
                }
            }
        }

        public string EmailAddress
        {
            get => _emailAddress;
            set
            {
                if (_emailAddress != value)
                {
                    _emailAddress = value.Length <= 50 ? value : throw new ArgumentException("Email cannot exceed 50 characters.");
                    OnPropertyChanged(nameof(EmailAddress));
                }
            }
        }

        public DateTime CustomerBirthday
        {
            get => _customerBirthday;
            set
            {
                if (_customerBirthday != value)
                {
                    _customerBirthday = value;
                    OnPropertyChanged(nameof(CustomerBirthday));
                }
            }
        }

        public int CustomerStatus
        {
            get => _customerStatus;
            set
            {
                if (_customerStatus != value && (value == 1 || value == 2))
                {
                    _customerStatus = value;
                    OnPropertyChanged(nameof(CustomerStatus));
                }
                else
                {
                    throw new ArgumentException("Status must be 1 (Active) or 2 (Deleted).");
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value.Length <= 50 ? value : throw new ArgumentException("Password cannot exceed 50 characters.");
                    OnPropertyChanged(nameof(Password));
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
