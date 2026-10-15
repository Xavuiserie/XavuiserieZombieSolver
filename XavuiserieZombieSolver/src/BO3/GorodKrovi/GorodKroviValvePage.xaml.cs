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

namespace XavuiserieZombieSolver.src.BO3.GorodKrovi
{
    /// <summary>
    /// Logique d'interaction pour GorodKroviValvePage.xaml
    /// </summary>
    public partial class GorodKroviValvePage : Page
    {
        public GorodKroviValvePage()
        {
            InitializeComponent();

            selectLumiere.ItemsSource = Enum.GetValues(typeof(ValveNames));
            selectCylindre.ItemsSource = Enum.GetValues(typeof(ValveNames));

            GridResult.ItemsSource = null;
        }

        private void Select_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (selectLumiere.SelectedItem is ValveNames lumiere && selectCylindre.SelectedItem is ValveNames cylindre)
            {
                Solver solver = new Solver(lumiere, cylindre);

                Dictionary<ValveNames, int>? result = solver.Solve();

                GridResult.ItemsSource = result;
            }
        }

        private void BtnRetourBO3Menu_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}
