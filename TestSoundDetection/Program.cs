using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSoundDetection.Classes;

namespace TestSoundDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
                Fish().Wait();

            //Console.WriteLine("Press key to continue!");
            //Console.ReadKey();
        }

        public static async Task Fish()
        {
            // Inspiration for code from https://github.com/UltimateFishbot/UltimateFishbot
            Ears ears = new Ears();

            var fishHeard = await ears.Listen(2000, new System.Threading.CancellationToken());

            Console.WriteLine($"{fishHeard}");

        }

    }
}
