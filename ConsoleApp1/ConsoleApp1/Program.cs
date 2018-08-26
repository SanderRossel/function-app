using System;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                // Replace with your own URL.
                string url = "http://localhost:7071/api/Function1";
                var content = new StringContent("{\"name\": \"Function\"}", Encoding.UTF8, "application/json");
                client.PostAsync(url, content).ContinueWith(async t =>
                {
                    var result = await t.Result.Content.ReadAsStringAsync();
                    Console.WriteLine("The Function result is:");
                    Console.WriteLine(result);
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                }).Wait();
            }
        }
    }
}
