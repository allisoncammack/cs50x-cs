using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MachineName: {0}", Environment.MachineName);
            Console.WriteLine("ProcessorCount: {0}", Environment.ProcessorCount);
            Console.WriteLine("Is64BitOperatingSystem: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion);
            Console.ReadLine();
        }
    }
}
