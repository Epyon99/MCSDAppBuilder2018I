using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;
            Console.WriteLine("Elija una opcion:");
            Console.WriteLine("Sumar");
            Console.WriteLine("Multiplicar");
            Console.WriteLine("Dividir");
            Console.WriteLine("Salir");
            bool ejecutando = true;
            while (ejecutando)
            {
                var opcion = Console.ReadLine();
                opcion = opcion.ToLower();
                switch (opcion)
                {
                    case "sumar":
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        var suma = a + b;
                        Console.WriteLine(suma);
                        break;
                    case "multiplicar":
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        var multiplicacion = a * b;
                        Console.WriteLine(multiplicacion);
                        break;
                    case "dividir":
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        double division =(double) a / b;
                        Console.WriteLine(division);
                        break;
                    case "salir":
                        ejecutando = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
