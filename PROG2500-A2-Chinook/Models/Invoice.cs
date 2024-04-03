using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{

    // This partial class wouldn't be overwritten if the project scaffolding is run again

    public partial class Invoice
    {
        public string customerInvoiceDate
        {
            get
            {
                return "Order Date: " + InvoiceDate.ToString("yyyy-MM-dd");
            }
        }

        public string customerInvoiceTotal
        {
            get
            {
                return string.Format(" Total: ${0:N2}", Total);
            }
        }

        public string customerInvoiceQuantity
        {

            get
            {
                int quantity = InvoiceLines.Count;
                return " Quantity: " + quantity;
            }
        }
    }
}
