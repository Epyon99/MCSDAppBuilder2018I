using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LO.EKPMJA.Desktop.ViewModels
{
    public class CarrerasModel : INotifyPropertyChanged
    {
        private string nombreCarrera;
        private int ciclos;
        private string facultad;

        public string NombreCarrera
        {
            get
            {
                return nombreCarrera;
            }
            set
            {
                nombreCarrera = value;
                NotifyPropertyChange();
            }
        }

        public int Ciclos
        {
            get
            {
                return ciclos;
            }
            set
            {
                ciclos = value;
                NotifyPropertyChange();
            }
        }

        public string Facultad {
            get
            {
                return facultad;
            }
            set
            {
                facultad = value;
                NotifyPropertyChange();
            }
        }

        private void NotifyPropertyChange([CallerMemberName]String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
