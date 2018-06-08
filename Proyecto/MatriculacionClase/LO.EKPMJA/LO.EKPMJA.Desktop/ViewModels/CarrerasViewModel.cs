using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Desktop.ViewModels
{
    public class CarrerasViewModel : ObservableCollection<CarrerasModel>
    {
        public CarrerasViewModel()
        {
            Add(new CarrerasModel()
            {
                NombreCarrera = "Informatica",
                Ciclos = 10,
                Facultad = "Informatica"
            });
            Add(new CarrerasModel()
            {
                NombreCarrera = "Cocinero",
                Ciclos = 10,
                Facultad = "Escuela de Cocina",
            });
            Add(new CarrerasModel()
            {
                NombreCarrera = "Dise♫o",
                Ciclos = 10,
                Facultad = "Humanidades"
            });
        }
    }
}
