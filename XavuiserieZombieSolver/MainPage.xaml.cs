using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XavuiserieZombieSolver.src.BO3;

namespace XavuiserieZombieSolver
{
    /// <summary>
    /// Logique d'interaction pour MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Window fenetrePrincipale = Window.GetWindow(this);

            if (fenetrePrincipale != null)
            {
                fenetrePrincipale.Title = "Xavuiserie Zombie Solver";
            }
        }

        private void BtnAllerBO3Menu_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BO3MenuPage());
        }
    }
}
