using System;
using System.Net.Http;
using System.Threading.Tasks;
using TransactionApiClients;

namespace APIClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var clients = new swaggerClient(httpClient);
            var results = await clients.CarsGetCarAsync(10,"");
            Console.WriteLine(results.Cylinders);
        }
    }
}
