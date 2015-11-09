using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labcontroller
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Slacker");
            Console.WriteLine(" Would you like to Submit a post or Read a post?");
            Console.WriteLine(" type Submit or Read");
            Console.ReadLine();
            if (Console.ReadLine() == "Read")
            {
            }
            else if (Console.ReadLine() == "Submit")
            {
                    Console.WriteLine("please enter username");
                    Console.WriteLine("please enter text");
            }

        }
    }
}
