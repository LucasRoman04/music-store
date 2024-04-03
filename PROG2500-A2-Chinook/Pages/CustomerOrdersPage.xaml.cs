using PROG2500_A2_Chinook.Data;
using PROG2500_A2_Chinook.Models;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for CustomerOrdersPage.xaml
    /// </summary>
    public partial class CustomerOrdersPage : Page
    {
        ChinookContext context = new ChinookContext();

        public CustomerOrdersPage()
        {
            InitializeComponent();
            LoadCustomerOrders();
        }

        private void LoadCustomerOrders()
        {
            var customers = context.Customers.ToList();
            context.Invoices.ToList();
            context.InvoiceLines.ToList();

            // Set the ItemsSource of the ListView to the artists data
            CustomerOrdersListView.ItemsSource = customers;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
           var query =
               context.Customers.Where(customer => customer.LastName.Contains(SearchTextBox.Text)).ToList();

            foreach(var customer in query)
            {
                // Sort the invoices for each customer by OrderDate in descending order
                customer.Invoices = customer.Invoices
                    .OrderByDescending(invoice => invoice.InvoiceDate.Year)
                    //.ThenByDescending(invoice => invoice.InvoiceDate.Month)
                    //.ThenByDescending(invoice => invoice.InvoiceDate.Day)
                    .ToList();
            }

            CustomerOrdersListView.ItemsSource = query;
        }        
    }
}
