using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCafe.Modelos
{
    public struct Cafe
    {
        private float temperatura;
        private float cantidad;
        private TipoCafe tipo;
        private string nombre;
        private string marca;
        private Vaso vaso;

        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }
        public TipoCafe Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public Vaso Vaso { get => vaso; set => vaso = value; }

        public Cafe(float temperatura = 10, float cantidad = 50, TipoCafe tipo = TipoCafe.Molido, string nombre = "Oscuro", string marca = "Juan Valdez", Vaso vaso = Vaso.Pequeño)
        {
            this.vaso = vaso;
            this.marca = marca;
            this.nombre = nombre;
            this.tipo = tipo;
            this.cantidad = cantidad;
            this.temperatura = temperatura;
        }

        public void Beber()
        {
            cantidad -= 10;
        }

        public void Servir()
        {
            cantidad += 50;
            switch (vaso)
            {
                case Vaso.Ninguno:
                    Console.WriteLine("Me sirviendo el cafe encima y quema!");
                    break;
                case Vaso.Pequeño:
                    if (cantidad > 50)
                    {
                        Console.WriteLine("Se esta derramando el cafe");
                    }
                    break;
                case Vaso.Mediano:
                    if (cantidad > 250)
                    {
                        Console.WriteLine("Se esta derramando el cafe");
                    }
                    break;
                case Vaso.Grande:
                    if (cantidad > 500)
                    {
                        Console.WriteLine("Se esta derramando el cafe");
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Nombre} - {Marca} - {Vaso} - {Temperatura} - {Cantidad} - {Tipo} ";
        }
    }
}
