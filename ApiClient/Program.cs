using System;
using System.Net.Http;
using TransactionAPIClient;

namespace APIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            var clients = new swaggerClient("https://localhost:5001/", httpClient);
            var results = await clients.CarsGetCarAsync(10);
            foreach (var item in results)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
