using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A2_Chinook.Models
{

    // This partial class wouldn't be overwritten if the project scaffolding is run again

    public partial class Album
    {
        public int myAlbumId 
        {  
            get
            {
                return AlbumId;
            } 
        }

        public string? myAlbumTitle 
        {  
            get
            {
                return Title;
            } 
        }
    }
}
