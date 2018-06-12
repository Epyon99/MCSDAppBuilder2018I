using LO.EKPMJA.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Carreras.xaml
    /// </summary>
    public partial class CarrerasCreate : Page
    {
        CarrerasModel model;

        public CarrerasCreate()
        {
            InitializeComponent();
            model = new CarrerasModel();
            Formulario.DataContext = model;
        }

        private bool Save(CarrerasModel carrera)
        {
            if (string.IsNullOrEmpty(carrera.NombreCarrera))
            {
                return false;
            }
            if (carrera.Ciclos == 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(carrera.Facultad))
            {
                return false;
            }

            //TODO: Agregar base de datos
            return true;
        }

        private void Label_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Save(model))
            {
                NavigationService.Navigate(new Uri("CarrerasIndex.xaml",UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Por favor introduzca los datos correctamente");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("CarrerasIndex.xaml",UriKind.RelativeOrAbsolute));
        }
    }
}
