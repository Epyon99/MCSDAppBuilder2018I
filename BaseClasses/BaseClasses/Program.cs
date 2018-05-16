using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            LibraryItem libraryItem = new Book();
            ComputerProgram computerProgram = new ComputerProgram();
            RecordedItem recordedItem = new ComputerProgram();
            Film film = new Film("Moises");
            film.Adquirir(1000);
            film.Catalogo();
            Console.ReadKey();
            
        }
    }
    // libros, revistas, periodos, vidos, programs, grabaciones
    public abstract class LibraryItem
    {
        public LibraryItem()
        {
            Costo = 0;
            Status = "Disponible";
        }
        public string NumeroRegistro { get; set; }

        public DateTime FechaAdquision { get; set; }

        public decimal Costo { get; set; }

        public string Status { get; set; }

        public string Tipo { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public void Adquirir(decimal costo)
        {
            Costo = costo;
            FechaAdquision = DateTime.Now;
            Status = "Disponible";
        }

        public void Catalogo()
        {
            Console.WriteLine($"Tipo:{Tipo} - Autor:{ Autor} - NumeroRegistro:{NumeroRegistro}");
        }
        

        public void Solicitar()
        {
            Status = "Ocupado";
        }

        public void Retornar()
        {
            Status = "Disponible";
        }
    }


    // Los publica un editor
    public abstract class PublishedItem : LibraryItem
    {
        public string Publicador { get; set; }
        public DateTime PublishingDate { get; set; }
        public string Editorial { get; set; }
    }

    public abstract class RecordedItem : LibraryItem
    {
        public RecordedItem(string autor) : base()
        {
            var guid = Guid.NewGuid().ToString();
            base.NumeroRegistro = guid;
            Autor = autor;
        }
        public string Medio { get; set; }
    }

    public sealed class Book : PublishedItem
    {
        public string Edicion { get; set; }
        public string ISBN { get; set; }
    }

    public sealed class Magazine : PublishedItem
    {
        public int Year { get; set; }
        public int Issue { get; set; }
    }

    public sealed class Newspaper : PublishedItem
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Ink { get; set; }
        public string Paper { get; set; }
    }

    public class Film : RecordedItem
    {
        public Film(string autor) : base(autor)
        {
            
        }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string> Actores { get; set; }

        public Dictionary<string,string> Creditos { get; set; }
    }

    public class ComputerProgram: RecordedItem
    {
        public ComputerProgram():base("Library")
        {

        }
        public string Version { get; set; }
        public string Plataforma { get; set; }
    }
}
