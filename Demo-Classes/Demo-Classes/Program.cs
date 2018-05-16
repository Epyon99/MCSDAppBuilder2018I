using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var trineo = new Trineo(9);
            foreach (var reno in trineo.Renos)
            {
                Console.WriteLine($"Reno {reno.Nombre} esta en el trineo");
            }
            while (true)
            {
                var volar = Console.ReadLine();
                if (volar == "volar" && !trineo.IsVolando)
                {
                    // Volar
                    trineo.Volar();
                }

                if (volar == "aterrizar" && trineo.IsVolando)
                {
                    // Aterrizar
                    trineo.Volar();
                }

                if (volar.Contains("intercambiar"))
                {
                    // Clonar la lista de renos de un punto a otro alterando posiciones
                    var lista = trineo.Renos;
                    var copia = lista;

                    copia[0].Nombre = "Rudoltf";
                    //MostrarRenos(trineo, lista, copia);

                    // Clonar la lista elemento por elemento
                    var listaNueva = new List<Reno>();
                    var copiaNueva = listaNueva;
                    foreach (var reno in trineo.Renos)
                    {
                        listaNueva.Add(new Reno() { Nombre = reno.Nombre });
                    }

                    copiaNueva[0].Nombre = "Reno de la nariz roja";
                    MostrarRenos(trineo, listaNueva, copiaNueva);


                    var listaRegalos = trineo.Regalos;
                    var copiaRegalos = listaRegalos;

                    var r1 = trineo.Regalos[0].Entrega;
                    var r2 = listaRegalos[0].Entrega;
                    var r3 = copiaRegalos[0].Entrega;

                    r1 = DateTime.Now.AddMinutes(5);
                    r2 = DateTime.Now.AddMinutes(10);
                    r3 = DateTime.Now.AddMinutes(20);

                    Trineo.MostrarRegalos(trineo, listaRegalos, copiaRegalos);

                    Console.WriteLine(r1);
                    Console.WriteLine(r2);
                    Console.WriteLine(r3);
                }

                Console.WriteLine($"El trineo esta volando?: {trineo.IsVolando}");

                if (volar == "exit")
                {
                    break;
                }
            }
        }        
    }

    public class Trineo
    {
        public Trineo()
        {
            isVolando = false;
            Renos = new List<Reno>()
            {
                new Reno(){ Nombre = "Rodolfo"}
            };
        }

        public Trineo(int numeroRenos)
        {
            isVolando = false;
            Renos = new List<Reno>();
            Regalos = new List<Regalo>();
            for (int i = 0; i < numeroRenos; i++)
            {
                Renos.Add(new Reno(i));
                Regalos.Add(new Regalo() { Entrega = DateTime.Now });
            }
        }

        private bool isVolando;
        public bool IsVolando { get => isVolando; }

        public List<Regalo> Regalos { get; set; }
        public List<Reno> Renos { get; set; }

        public void Volar()
        {
            isVolando = !isVolando;
        }

        public void MostrarRenos(Trineo trineo, List<Reno> lista, List<Reno> copia)
        {
            foreach (var reno in trineo.Renos)
            {
                Console.WriteLine($"Reno {reno.Nombre} esta en el trineo");
            }
            foreach (var reno in lista)
            {
                Console.WriteLine($"Reno {reno.Nombre} esta en el trineo");
            }
            foreach (var reno in copia)
            {
                Console.WriteLine($"Reno {reno.Nombre} esta en el trineo");
            }
        }
        public static void MostrarRegalos(Trineo trineo, List<Regalo> lista, List<Regalo> copia)
        {
            foreach (var reno in trineo.Regalos)
            {
                Console.WriteLine($"Regalo {reno.Entrega} ");
            }
            foreach (var reno in lista)
            {
                Console.WriteLine($"Regalo {reno.Entrega}");
            }
            foreach (var reno in copia)
            {
                Console.WriteLine($"Regalo {reno.Entrega} ");
            }
        }
    }

    public class Reno
    {
        public Reno() { }
        public Reno(int numero)
        {
            switch (numero)
            {
                case 0:
                    Nombre = "Rodolfo";
                    break;
                case 1:
                    Nombre = "Trueno";
                    break;
                case 2:
                    Nombre = "Relampago";
                    break;
                case 3:
                    Nombre = "Jugueton";
                    break;
                case 4:
                    Nombre = "Cupido";
                    break;
                case 5:
                    Nombre = "Cometa";
                    break;
                case 6:
                    Nombre = "Brioso";
                    break;
                case 7:
                    Nombre = "Bailarin";
                    break;
                case 8:
                    Nombre = "Acrobata";
                    break;
                default:
                    Nombre = "Rodolfo";
                    break;
            }
        }
        public string Nombre { get; set; }
    }

    public struct Regalo
    {
        public DateTime Entrega { get; set; }
    }
}
