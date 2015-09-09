using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // determine current date using DateTime structure 
            DateTime thisDate = DateTime.Now;

            // output current date using a short date pattern (and current (en-us) culture)
            Console.WriteLine(thisDate.ToString("d"));

            // output current date using a long date pattern
            Console.WriteLine(thisDate.ToString("D"));

            // output current date using a short time pattern
            Console.WriteLine(thisDate.ToString("t"));

            // output current date using a long time pattern
            Console.WriteLine(thisDate.ToString("T"));
        }
    }
}
