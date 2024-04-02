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

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the search text from the TextBox
            string searchText = SearchTextBox.Text.ToLower();

            using (var context = new ChinookContext())
            {
                // Query the database to find matching tracks
                var searchedTracks = context.Tracks
                    .Where(track => track.Name.ToLower().Contains(searchText))
                    .ToList();

                // Update the ItemsSource of the ListView with the tracks
                TracksListView.ItemsSource = searchedTracks;
            }
        }
    }
}
