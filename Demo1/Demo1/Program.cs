using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");

            string entrada = Console.ReadLine();

            Console.WriteLine("El usuario introdujo:" + entrada);
            Console.ReadKey();
            int numeroEntero = 123456;
            long numeroLong = 1234556778;
            float f = 12.123f;
            double d = 12.3123123;
            decimal de = 12.23213M;
            string strings = "12345";
            char c = 'c';
            bool b = true | false;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hola");
            sb.AppendLine("Mundo");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();


        }
    }
}
