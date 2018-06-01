using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.ViewModels
{
    public class CarrerasViewModel : ObservableCollection<CarrerasModel>
    {
        public CarrerasViewModel()
        {
            Add(new CarrerasModel()
            {
                NombreCarrera = "1",
                Ciclos = 1,
                Facultad = "1"
            });
        }
    }
}
