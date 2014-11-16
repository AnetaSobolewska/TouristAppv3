using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using TouristAppv2.Model;
using TouristAppv2.ViewModel;

namespace TouristAppv2.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainViewModel.SelectedCategory = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedCategory = (string)((Button)sender).Content;
            this.Frame.Navigate(typeof(GenericPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedCategory = (string)((Button)sender).Content;

            this.Frame.Navigate(typeof(GenericPage));
        }

        private void Hotel_Comwell_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedCategory = (string)((Button)sender).Content;

            this.Frame.Navigate(typeof(GenericPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainViewModel.SelectedCategory = (string)((Button)sender).Content;

            this.Frame.Navigate(typeof(GenericPage));
        }

        

        
    }
}
