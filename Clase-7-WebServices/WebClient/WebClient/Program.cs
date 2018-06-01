using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {

            //http://localhost:56527/api/values
            // Web client para diferentes tipos de request
            System.Net.WebClient webClient = new System.Net.WebClient();

            // Solo request HTTP
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:56527/");

            var task = httpClient.GetAsync("api/values");
            task.Wait();

            HttpResponseMessage result = task.Result;
            var texto = result.Content.ReadAsStringAsync();
            texto.Wait();
            Console.WriteLine(texto.Result);

            Console.WriteLine("-----Fin del consumo de HTTP ---");
            Console.ReadKey();


            //http://localhost:56540/Service1.svc
            SR.Service1Client s1c = new SR.Service1Client();
            Console.WriteLine(s1c.GetData(10));
            var resultado = s1c.GetDataUsingDataContract(new SR.CompositeType()
            {
                BoolValue = true,
                StringValue = "Moises Chirinos "
            });
            Console.WriteLine(resultado.StringValue);

            Console.ReadKey();
        }
    }
}
