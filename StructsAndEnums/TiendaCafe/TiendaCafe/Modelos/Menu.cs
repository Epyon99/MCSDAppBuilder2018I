using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCafe.Modelos
{
    public struct Menu
    {
        Cafe[] cafes;

        public Cafe[] Cafes { get => cafes; }
        
        // Indice - Indexador
        public Cafe this[int index]
        {
            get { return this.cafes[index]; }
            set { this.cafes[index] = value; }
        }

        public Menu(Cafe[] cafes)
        {
            this.cafes = new Cafe[]
            {
                new Cafe(10, 200, TipoCafe.Dulce, "Azucarado", "Starbucks", Vaso.Mediano),
                new Cafe(temperatura:10, cantidad:200, tipo:TipoCafe.Grano, nombre:"Peruano", marca:"Peruano", vaso:Vaso.Mediano),
                new Cafe(cantidad:200, tipo:TipoCafe.Helado, nombre:"Venezolano", marca:"Fama de america", vaso:Vaso.Mediano),
                new Cafe(cantidad:500, tipo:TipoCafe.Macerado, nombre:"De Miel", marca:"Colombiano", vaso:Vaso.Grande),
                new Cafe(temperatura:50, tipo:TipoCafe.Tostado, nombre:"Marron", marca:"Cruz de mayo"),
                new Cafe(),
            };
        }



    }
}
