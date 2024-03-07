﻿using System;
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

namespace PROG2500_A2_Chinook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToHome(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
        }

        private void NavigateToArtists(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/ArtistsPage.xaml", UriKind.Relative));
        }

        private void NavigateToAlbums(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/AlbumsPage.xaml", UriKind.Relative));
        }

        private void NavigateToTracks(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Pages/TracksPage.xaml", UriKind.Relative));
        }
        
    }
}
