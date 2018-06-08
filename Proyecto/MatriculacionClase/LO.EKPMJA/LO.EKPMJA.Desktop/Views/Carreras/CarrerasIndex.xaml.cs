using LO.EKPMJA.Desktop.ViewModels;
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

namespace LO.EKPMJA.Desktop.Views.Carreras
{
    /// <summary>
    /// Interaction logic for CarrerasIndex.xaml
    /// </summary>
    public partial class CarrerasIndex : Page
    {
        CarrerasViewModel model = new CarrerasViewModel();

        public CarrerasIndex()
        {
            InitializeComponent();
            CarrersList.ItemsSource = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CarrerasCreate.xaml",UriKind.RelativeOrAbsolute));
        }
    }
}
