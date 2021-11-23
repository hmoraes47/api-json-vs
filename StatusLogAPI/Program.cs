using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StatusLogAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(value:"Hello World!");

            await Get();
        }

        public static async Task Get()
        {
            var httpClient = new HttpClient();
            var Username = "carriertesting@project44.com";
            var Password = "IntegrationTesting";
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{Username}:{Password}")));

            var response = await httpClient.GetAsync(requestUri: "https://cloud.p-44.com/api/carriers/v2/tl/shipments/statusUpdates");

            var data = await response.Content.ReadAsStringAsync();
        }

        public static async Task Post()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage();

            var objeto = new Arquivo(); //Adicionar forma de transformar em objeto

            var content = ToRequest(Arquivo); //Esperando receber um objeto

            var response = await httpClient.PostAsync("https://cloud.p-44.com/api/carriers/v2/tl/shipments/statusUpdates", content);
    }

         public static StringContent ToRequest(object obj)
        {
            var json = JsonContent.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, mediaType: "application/json");

            return data;
        }
    }
}
