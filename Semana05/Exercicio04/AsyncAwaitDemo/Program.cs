using System;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace AsyncAwaitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string URL = "https://raw.githubusercontent.com/13oxer/Doggo/main/README.md"

            //defining a new stopwatch to count the time span for the execution
            Stopwatch sw = new Stopwatch();
            //start counting
            sw.Start();
            
            var tasks = new List<Task> { SummonDogLocally, SummonDogFromURL(URL) };
            await Task.WhenAll(tasks);

            sw.Stop();

            Console.WriteLine("We are done Here ...." + sw.ElapsedMilliseconds);
        }
        static async Task SummonDogLocally()
        {
            Console.WriteLine("1. Summoning Dog Locally ...");

            //read all the text inside the dog.txt async
            string dogtext = await File.ReadAllTextAsync("dog.txt");
            Thread.Sleep(1000);

            //display the data inside the txt file
            Console.WriteLine($"2. Dog Summoned Locally \n{dogtext}");

        
        }
        // A Task return will eventually yield a void 
        static async Task SummonDogFromURL(string URL)
        {
            Console.WriteLine("1. Summoning Dog from URL ...");

            using (var httpClient = new HttpClient())
            {
                string result = await httpClient.GetStringAsync(URL);

                //From this line and below, the execution will resume once the
                //above awaitable is done
                //using await keyword, it will do the magic of unwrapping
                //the Task<string> into string (result variable)
                Console.WriteLine($"2. Dog Summoned Locally \n{result}");
            }
        }
        
    }
}
