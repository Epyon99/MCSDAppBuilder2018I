using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.ViewModels
{
    public class CarrerasModel : INotifyPropertyChanged
    {
        public string NombreCarrera { get; set; }

        public int Ciclos { get; set; }

        public string Facultad { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
