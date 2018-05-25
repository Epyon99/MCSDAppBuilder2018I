using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

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
                Directory.SetCreationTime(randomDirectoryName, new DateTime(1999, 12, 15));
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


            // Creacion de Fantasmas
            List<Fantasma> fantasmas = new List<Fantasma>();
            var phantonPath = $"{Path.GetDirectoryName(path)}\\Fantasmas";
            if (!Directory.Exists(phantonPath))
            {
                Directory.CreateDirectory(phantonPath);
            }

            if (Directory.Exists(phantonPath))
            {

                Console.WriteLine("----Binary---");
                SerializacionBinaria(phantonPath, fantasmas);

                Console.WriteLine("----XML---");
                SerializacionXml(phantonPath, fantasmas);


                Console.WriteLine("----JSON---");
                SerializacionJson(phantonPath, fantasmas);
            }

            // PDF ITextSharp
            string pdfPath = @"C:\Workspace\Personal\Lourtec-2018-i\MCSDAppBuilder2018I\Clase-5\phdThesis.pdf";
            string pdfPathClone = @"C:\Workspace\Personal\Lourtec-2018-i\MCSDAppBuilder2018I\Clase-5\Clone.pdf";


            iTextSharp.text.Document document = null;
            try
            {
                document = new iTextSharp.text.Document();
                PdfWriter write = PdfWriter.GetInstance(document, new FileStream(pdfPathClone, FileMode.Create));
                Anchor anchor = new Anchor("Hola Mundo");
                iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();
                paragraph.Add(anchor);
                document.Open();
                document.OpenDocument();

                document.Add(new Chunk("Hola Mundo Chunk"));
                document.Add(paragraph);
                if (document.IsOpen())
                {
                    document.NewPage();
                }
                document.Close();
                write.Close();
            }
            catch (Exception ex)
            {

            }

        }

        public static void SerializacionBinaria(string phantonPath, List<Fantasma> fantasmas)
        {
            // Serializacion Binaria
            var phantonBinary = $"{phantonPath}\\phanton.file";
            // Deserializar
            if (File.Exists(phantonBinary))
            {
                IFormatter formatter = new BinaryFormatter();
                using (var buffer = File.OpenRead(phantonBinary))
                {
                    fantasmas = formatter.Deserialize(buffer) as List<Fantasma>;
                    foreach (var g in fantasmas)
                    {
                        g.Asustar();
                        Console.WriteLine(g.ToString());
                    }
                }
            }
            // Logica de Negocios
            var fantasma = new Fantasma()
            {
                Nombre = "Fantasma-" + Path.GetRandomFileName(),
            };
            foreach (var g in fantasmas)
            {
                fantasma.Asustar();
            }
            fantasmas.Add(fantasma);

            // Serializar
            using (var file = File.OpenWrite(phantonBinary))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, fantasmas);
                file.Flush();
            }
        }

        public static void SerializacionXml(string phantonPath, List<Fantasma> fantasmas)
        {
            // Serializacion Binaria
            var phantonXml = $"{phantonPath}\\phanton.xml";
            if (File.Exists(phantonXml))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Fantasma>));
                using (var buffer = File.OpenRead(phantonXml))
                {
                    fantasmas = formatter.Deserialize(buffer) as List<Fantasma>;
                    foreach (var g in fantasmas)
                    {
                        g.Asustar();
                        Console.WriteLine(g.ToString());
                    }
                }
            }
            using (var file = File.OpenWrite(phantonXml))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Fantasma>));
                var fantasma = new Fantasma()
                {
                    Nombre = "Fantasma-" + Path.GetRandomFileName(),
                };
                foreach (var g in fantasmas)
                {
                    fantasma.Asustar();
                }
                fantasmas.Add(fantasma);
                formatter.Serialize(file, fantasmas);
                file.Flush();
            }
        }

        public static void SerializacionJson(string phantonPath, List<Fantasma> fantasmas)
        {
            // Serializacion Json
            var phantonJson = $"{phantonPath}\\phanton.json";
            if (File.Exists(phantonJson))
            {
                using (var buffer = File.OpenRead(phantonJson))
                {
                    using (var streamReader = new StreamReader(buffer))
                    {
                        var texto = streamReader.ReadToEnd();
                        fantasmas = JsonConvert.DeserializeObject<List<Fantasma>>(texto);
                        foreach (var g in fantasmas)
                        {
                            g.Asustar();
                            Console.WriteLine(g.ToString());
                        }
                    }
                }
            }

            using (FileStream file = File.OpenWrite(phantonJson))
            {
                var fantasma = new Fantasma()
                {
                    Nombre = "Fantasma-" + Path.GetRandomFileName(),
                };
                foreach (var g in fantasmas)
                {
                    fantasma.Asustar();
                }
                fantasmas.Add(fantasma);
                var texto = JsonConvert.SerializeObject(fantasmas);
                using (var streamWriter = new StreamWriter(file))
                {
                    streamWriter.Write(texto);
                }
            }
        }
    }
}
