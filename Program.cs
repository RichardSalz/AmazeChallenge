using HightechICT.Amazeing.Client;
using HightechICT.Amazeing.Client.Rest;

using System;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            //var Mazes = new List<MazeInfo>(getMazeInfo());
            client.DefaultRequestHeaders.Add("Authorization", "HTI Thanks You [4d39]");

           client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

           using HttpResponseMessage httpResponseMessage = await client.GetAsync("/api/mazes/all");
           string Mazes = await httpResponseMessage.Content.ReadAsStringAsync();
        }

        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://maze.hightechict.nl"),    
        };

        private static IEnumerable<MazeInfo> getMazeInfo()
        {
            return null;
        }
    }
}