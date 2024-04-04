using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{

    // This partial class wouldn't be overwritten if the project scaffolding is run again

    public partial class Customer
    {
        public string customerFullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string? customerCountry
        {
            get
            {
                return Country;
            }
        }

        public string customerEmail
        {
            get
            {
                return Email;
            }
        }

        public string? customerLocation
        {
            get
            {
                if (!string.IsNullOrEmpty(State))
                {
                    return $"{City}, {State}";
                }
                else
                {
                    return City;
                }
            }
        }
    }
}
