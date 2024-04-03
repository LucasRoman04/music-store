using Microsoft.EntityFrameworkCore;
using PROG2500_A2_Chinook.Data;
using PROG2500_A2_Chinook.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MusicCatalogPage.xaml
    /// </summary>
    public partial class MusicCatalogPage : Page
    {
        ChinookContext context = new ChinookContext();

        public MusicCatalogPage()
        {
            InitializeComponent();
            LoadMusicCatalog();
        }

        private void LoadMusicCatalog()
        {
            var artists = context.Artists.ToList();
            context.Albums.ToList();
            context.Tracks.ToList();

            // Set the ItemsSource of the ListView to the artists data
            MusicCatalogListView.ItemsSource = artists;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var query =
                from artist in context.Artists
                where artist.Name.Contains(SearchTextBox.Text)
                group artist by artist.Name.ToUpper().Substring(0, 1) into newGroup
                select new
                {
                    Index = newGroup.Key,
                    ArtistCount = newGroup.Count().ToString(),
                    artist = newGroup.ToList<Artist>()
                };

            // Update the ItemsSource of the ListView
            MusicCatalogListView.ItemsSource = query.ToList();

            // Change the visibility of the ListView to Visible
            MusicCatalogListView.Visibility = Visibility.Visible;
        }        
    }
}
