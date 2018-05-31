using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6_DBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Camisa camisa = new Camisa
            {
                Id = new Random().Next(0,10000),
                Nombre = "Chao Mundo",
                Talla = "1",
                Tela = "Seda",
            };

            Zapato zapato = new Zapato()
            {
                Id = new Random().Next(0, 10000)
                ,
                Marca = $"Nike{new Random().Next(0, 10000)}"
            };

            Clase6Entities1 db = new Clase6Entities1();

            // INSERT INTO CAMISA () VALUES
            db.Camisas.Add(camisa);
            db.Zapatos.Add(zapato);

            db.SaveChanges();

            // SELECT * FROM CAMISAS;
            foreach(var c in db.Camisas.ToList())
            {
                Console.WriteLine(c.Nombre);
            }

            foreach(var z in db.Zapatos.ToList())
            {
                Console.WriteLine(z.Marca);
            }
            ReadData(db);
            Console.ReadKey();
        }

        public static void ReadData(Clase6Entities1 database)
        {
            // Get Data
            // IQueryable
            var zapatos = from zapato in database.Zapatos
                          select zapato;

            zapatos = from zapato in database.Zapatos
                      where zapato.Id > 5
                      select zapato;

            zapatos = from zapato in database.Zapatos
                      where zapato.Id > 5
                      orderby zapato.Marca
                      //orderby descending zapato.Marca
                      select zapato;

            // Linq Lineal / Lambda style
            // => 
            database.Zapatos.Where(zapato => zapato.Id > 5);
            database.Zapatos.Where(zapato => zapato.Id > 5).OrderBy(zapato => zapato.Marca).ToList();
        }
    }
}
