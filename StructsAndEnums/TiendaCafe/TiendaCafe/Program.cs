using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCafe.Modelos;

namespace TiendaCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ejecutando = true;
            while (ejecutando)
            {
                var menu = new Menu(new Cafe[0]);
                for (int indice = 0; indice < menu.Cafes.Length; indice++)
                {
                    Console.WriteLine($"Opcion {indice}: " + menu[indice]);
                }
                Console.WriteLine("10 - Salir");
                var opcion = 0;
                try
                {
                    // Buena practica tener un try/catch para metodos que pueden arrojar excepciones
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 10)
                    {
                        // Rompe la ejecucion de cualquier bucle While/Do-While/Foreach/Fors
                        break;
                    }
                    if (opcion >= menu.Cafes.Length)
                    {
                        // Mala practica
                        // No se deberia usar excepciones para el flujo adrede del programa
                        //throw new Exception();

                        // buena practica
                        Console.WriteLine("Elija una opcion");
                        // Continue pasa a la siguiente iteracion inmediatamente
                        continue;
                    }

                    var cafe = menu[opcion];
                    bool bebiendo = true;
                    while (bebiendo)
                    {
                        Console.WriteLine("1) Servirse");
                        Console.WriteLine("2) Beber");
                        Console.WriteLine("3) Oneshot Drink");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                cafe.Servir();
                                break;
                            case 2:
                                cafe.Beber();
                                Console.WriteLine($"Le queda { cafe.Cantidad } mm");
                                break;
                            case 3:
                                cafe.Cantidad = 0;
                                if (cafe.Temperatura > 30)
                                {
                                    Console.WriteLine("Se acaba de quemar la garganta");
                                }
                                break;
                        }
                        if (cafe.Cantidad == 0)
                        {
                            bebiendo = false;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Elija una opcion");
                }
                finally
                {
                    //if (opcion == 10)
                    //{
                    //    ejecutando = false;
                    //}
                }
            }
        }
    }
}
