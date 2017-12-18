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

namespace OfficialProject_ASOCCER_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StartPage : Page
    {
        public StartPage()
        {
            this.InitializeComponent();
        }
        //for button catching
        private void Catching(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(catching), null);

        }

        //for button throwing
        private void Throwing(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(throwing), null);

        }

        //for button kicking
        private void Kicking(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Kicking), null);

        }

        //for button oneOnOne 
        private void oneOnOne(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(oneOnOne), null);

        }

        //for button DCrossing
        private void DCrossing(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DefendingCrosses), null);

        }

        //for button shape
        private void Shape(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Shape), null);

        }

        //for button shape
        private void shape(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Shape), null);

        }

        //for button SPassing
        private void SPassing(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SPassing), null);

        }

        //for button LPassing
        private void LPassing(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LPassing), null);

        }

        //for button Running
        private void Running(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Running), null);

        }

        //for button Finnishing
        private void Finnishing(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Finishing), null);

        }

        //for button Acrosses
        private void ACrosses(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AttackingCrosses), null);

        }

        //for button Movement
        private void Movement(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Movement), null);

        }
    }
}
