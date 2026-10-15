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
using XavuiserieZombieSolver.src.BO3.GorodKrovi;

namespace XavuiserieZombieSolver.src.BO3
{
    /// <summary>
    /// Logique d'interaction pour BO3MenuPage.xaml
    /// </summary>
    public partial class BO3MenuPage : Page
    {
        public BO3MenuPage()
        {
            InitializeComponent();
        }

        private void BtnAllerGorodValve_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GorodKroviValvePage());
        }

        private void BtnRetourMenuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}
