using System;
using System.IO;

namespace DemoFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path
            var path = "C:\\Workspace\\Personal\\Lourtec-2018-i\\MCSDAppBuilder2018I\\Clase-5\\holaMundo.txt";

            /* Tip sobre los strings de forma nativa/implicita
             "" al crear string con comillas dobles necesitan caracteres de escape para algunos caracteres especiales para eso se utiliza un backslash \, un doble backslash para incluir uno en el text \\
             @"" copia strings literales, todos sin caracteres de escape, incluye saltos de linea
             $"" permite generar concatenacion con anclas dinamicas con {}
             */
            var parentDirectory = Path.GetDirectoryName(path);
            Console.WriteLine(parentDirectory);

            var extension = Path.GetExtension(path);
            Console.WriteLine(extension);

            var root = Path.GetPathRoot(path);
            Console.WriteLine(root);

            var randomName = Path.GetRandomFileName();
            Console.WriteLine(randomName);
            // Directory 

            var randomDirectoryName = $"{Path.GetDirectoryName(path)}\\{Path.GetRandomFileName()}";
            if (!Directory.Exists(randomDirectoryName))
            {
                Directory.CreateDirectory(randomDirectoryName);

                Console.WriteLine(Directory.GetParent(randomDirectoryName));
                Directory.SetCreationTime(randomDirectoryName,new DateTime(1999,12,15));
                Console.WriteLine(Directory.GetCreationTime(randomDirectoryName));
            }

            // DirectoryInfo
            Console.Write("------------Directory Info------------------");
            DirectoryInfo d = new DirectoryInfo(randomDirectoryName);
            Console.WriteLine($"{d.FullName} {d.CreationTime} {d.Attributes.ToString()}");

            // File
            randomName = randomDirectoryName + "\\" + randomName + ".txt";
            if (!File.Exists(randomName))
            {
                using (var fileStream = File.CreateText(randomName))
                {
                    fileStream.WriteLine("Hola Mundo");
                    fileStream.Flush();
                }

                Console.WriteLine(File.ReadAllText(randomName));
            }
            // FileInfo
            FileInfo f = new FileInfo(randomName);
            Console.WriteLine($"{f.FullName} {f.CreationTime} {f.Attributes}");

            Console.ReadKey();
        }
    }
}
