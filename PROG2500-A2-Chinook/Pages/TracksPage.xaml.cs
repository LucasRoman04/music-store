using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PROG2500_A2_Chinook.Data;


namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for TracksPage.xaml
    /// </summary>
    public partial class TracksPage : Page
    {
        public TracksPage()
        {
            InitializeComponent();
            LoadTracks();       
        }

        private void LoadTracks()
        {
            using (var context = new ChinookContext())
            {
                // Retrieve tracks data
                var tracks = context.Tracks.ToList();

                // Set the DataContext of the ListView to the tracks data
                TracksListView.ItemsSource = tracks;
            }
        }
    }
}
