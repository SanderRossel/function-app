using System;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                // Replace with your own URL.
                string url = "https://functions2213.azurewebsites.net/api/Function1?code=HGVGvjEecLEKxZObeJahStGHkNra7UAw8hORfkC3wYGQisM9Swf42w==";
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
