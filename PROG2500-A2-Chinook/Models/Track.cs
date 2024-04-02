using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{

    // This partial class wouldn't be overwritten if the project scaffolding is run again

    public partial class Track
    {
        public string myTrackName
        {
            get
            {
                return string.Format(Name);
            }
        }

        public string myComposer
        {
            get
            {
                return string.Format("Composer: {0:N0}", Composer);
            }
        }

        public string myMilliseconds
        {
            get
            {
                return string.Format("Length: {0:N0} ms", Milliseconds);
            }
        }

        public string myBytes
        {
            get
            {
                return string.Format("Size: {0:N0} bytes", Bytes);
            }
        }

        public string myUnitPrice
        {
            get
            {
                return string.Format("Price: {0:C2}", UnitPrice);
            }
        }


    }
}
