using BussinessObjects;
using Microsoft.Extensions.Configuration;
using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DangYenNhi_SE18B02_A01
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly ICustomerService iCustomerService;
        public LoginWindow()
        {
            InitializeComponent();
            iCustomerService = new CustomerService();
        }
        
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public Customer GetAdminAccount()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            var customer = new Customer()
            {
                EmailAddress = config["AdminAccount:Email"],
                Password = config["AdminAccount:Password"]
            };
            return customer;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var adminAccount = GetAdminAccount();

            if (txtEmail.Text.Equals(adminAccount.EmailAddress, StringComparison.OrdinalIgnoreCase) &&
                txtPass.Password.Equals(adminAccount.Password))
            {
                this.Hide();
                MainWindow adminWindow = new MainWindow();
                adminWindow.Show();
                adminWindow.Closing += (s, e) => this.Close();
            }
            else
            {
                Customer customer = iCustomerService.GetCustomerByEmail(txtEmail.Text);

                if (customer != null && customer.Password.Equals(txtPass.Password) && customer.CustomerStatus == 1)
                {
                    this.Hide();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    mainWindow.Closing += (s, e) => this.Close();
                }
                else
                {
                    MessageBox.Show("You are not permission !");
                }
            }
        }
    }
}
