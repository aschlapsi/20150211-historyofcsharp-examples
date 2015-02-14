using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press enter to start program");
            Console.ReadLine();
            ShowPageLength("http://msdn.microsoft.com");
            Console.WriteLine("Back in main again.");
            Thread.Sleep(10000);
            //task.Wait();
        }

        static async void ShowPageLength(string url)
        {
            var lengthTask = GetPageLength(url);
            Console.WriteLine("Called GetPageLength");
            Console.WriteLine("Length of '{0}': {1}", url, await lengthTask);
        }

        static async Task<int> GetPageLength(string url)
        {
            var client = new HttpClient();

            Task<string> getPageTask = client.GetStringAsync(url);
            Console.WriteLine("Just started task");
            string contents = await getPageTask;
            return contents.Length;
        }
    }
}
