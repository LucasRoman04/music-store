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
using PROG2500_A2_Chinook.Data;

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for ArtistsPage.xaml
    /// </summary>
    public partial class ArtistsPage : Page
    {
        public ArtistsPage()
        {
            InitializeComponent();
            LoadArtists();
        }

        private void LoadArtists()
        {
            using (var context = new ChinookContext())
            {
                // Retrieve artist data
                var artists = context.Artists.ToList();

                // Set the ItemsSource of the ListView to the artists data
                ArtistsListView.ItemsSource = artists;
            }
        }
    }
}
