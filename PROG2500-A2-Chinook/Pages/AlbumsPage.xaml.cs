﻿using System;
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
using PROG2500_A2_Chinook.Data;

namespace PROG2500_A2_Chinook.Pages
{
    /// <summary>
    /// Interaction logic for AlbumsPage.xaml
    /// </summary>
    public partial class AlbumsPage : Page
    {
        public AlbumsPage()
        {
            InitializeComponent();
            LoadAlbums();
        }

        private void LoadAlbums()
        {
            using (var context = new ChinookContext())
            {
                // Retrieve albums data
                var albums = context.Albums.ToList();

                // Set the ItemsSource of the ListView to the albums data
                AlbumsListView.ItemsSource = albums;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the search text from the TextBox
            string searchText = SearchTextBox.Text.ToLower();

            using (var context = new ChinookContext())
            {
                // Query the database to find matching albums
                var searchedAlbums = context.Albums
                    .Where(album => album.Title.ToLower().Contains(searchText))
                    .ToList();

                // Update the ItemsSource of the ListView with the albums
                AlbumsListView.ItemsSource = searchedAlbums;
            }
        }
    }
}
