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

namespace LO.EKPMJA.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CarrerasModel carrerasModel;
        public MainWindow()
        {
            InitializeComponent();
            carrerasModel = new CarrerasModel();
            Panel.DataContext = carrerasModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{carrerasModel.NombreCarrera}-{carrerasModel.Ciclos}-{carrerasModel.Facultad}");
            carrerasModel.Ciclos = 100;
            carrerasModel.NombreCarrera = "No importa";
            carrerasModel.Facultad = "Programacion";
        }
    }
}
