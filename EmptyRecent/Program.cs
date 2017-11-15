using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Steamworks;

namespace EmptyRecent
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SteamAPI.IsSteamRunning())
            {
                
                Console.WriteLine("EmptyRecent tool by Weespin");
                Console.WriteLine("Running fake game #1");
                Environment.SetEnvironmentVariable("SteamAppId", "399220");
                SteamAPI.Init();
                SteamAPI.Shutdown();
                Console.WriteLine("Stopping playing fake game #1");
                Console.WriteLine("Running fake game #2");
                Environment.SetEnvironmentVariable("SteamAppId", "399510");
                SteamAPI.Init();
                SteamAPI.Shutdown();
                Console.WriteLine("Stopping playing fake game #2");
                Console.WriteLine("Running fake game #3");
                Environment.SetEnvironmentVariable("SteamAppId", "399480");
                SteamAPI.Init();
                SteamAPI.Shutdown();
                Console.WriteLine("Stopping playing fake game #3");
                Console.WriteLine("Done!");
            }
            else
            {
               Console.WriteLine("Steam is not running!");
            }
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }
    }
}
