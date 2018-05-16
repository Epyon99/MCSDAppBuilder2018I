using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////
            // Estructura normal
            Aves aguila = new Aves();
            Console.WriteLine($"Aguila: Garras:{ aguila.Garras} - Alas: {aguila.Alas} - Plumas:{aguila.Plumas} ");

            Peces salmon = new Peces();
            Console.WriteLine($"Salon: Branquias: {salmon.Branquias} - Aletas {salmon.Aletas}");

            Reptiles cocodrilo = new Reptiles();
            Console.WriteLine($"CocodriloAlien: Garras:{ cocodrilo.Garras} - Alas: {cocodrilo.Alas} - Plumas:{cocodrilo.Plumas}  - Branquias: {cocodrilo.Branquias} - Aletas {cocodrilo.Aletas}");

            ////////////////////////////////////
            IVoladores volador = aguila;
            Console.WriteLine($"Volador: Garras:{ volador.Garras} - Alas: {volador.Alas} - Plumas:{volador.Plumas} ");
            volador = cocodrilo;
            Console.WriteLine($"Volador: Garras:{ volador.Garras} - Alas: {volador.Alas} - Plumas:{volador.Plumas} ");

            ///////////////////////////////////
            IAcuaticos acuatico = salmon;
            Console.WriteLine($"acuatico: Branquias: {acuatico.Branquias} - Aletas {acuatico.Aletas}");
            acuatico = cocodrilo;
            Console.WriteLine($"acuatico: Branquias: {acuatico.Branquias} - Aletas {acuatico.Aletas}");


            // Collections and generics
            List<string> a = new List<string>();
            a.Add("a");

            List<int> b = new List<int>();
            b.Add(2);

            Testing<Reptiles> testing = new Testing<Reptiles>();
            testing.Get(cocodrilo);

            Testing<Aves> testingA = new Testing<Aves>();
            testingA.Get(aguila);
            Console.ReadKey();
        }

        public class Testing<T>
        {
            public T Get(T variable)
            {
                Console.WriteLine(variable.ToString());
                return variable;
            }
        }

        public class Aves : IVoladores
        {
            public string Nombre { get; set; }

            public int Garras => 2;

            public int Alas => 2;

            public int Plumas => 100;
        }

        public class Peces : IAcuaticos
        {
            public string Nombre { get; set; }

            public bool Branquias => true;

            public bool Aletas => true;
        }

        public class Reptiles : IVoladores, IAcuaticos
        {
            public string Nombre { get; set; }

            public int Garras => 4;

            public int Alas => 2;

            public int Plumas => 50;

            public bool Branquias => false;

            public bool Aletas => true;
        }

        public interface IVoladores
        {
            int Garras { get; }
            int Alas { get; }
            int Plumas { get; }
        }

        public interface IAcuaticos
        {
            bool Branquias { get; }
            bool Aletas { get; }
        }
    }
}
