using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Lab.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Welcome to Slacker");
            System.Console.WriteLine(" would you like to submit a post or read a post?");
            System.Console.WriteLine(" type Submit or Read");
            System.Console.ReadLine();

            var client = new RestClient("http://localhost:51500/Slacker");

            if ( System.Console.ReadLine() == "Read")
            {
                var GetNewPost = new RestRequest("api/Slacker/old/Method.GET");
            }
            else if (System.Console.ReadLine() == "Submit")
            {
                var PostNewPost = new RestRequest("api/Slacker/new/Method.Post");
                break; 
                
            }
            System.Console.WriteLine("please enter username");
            System.Console.WriteLine("please enter text");

        }
    }
}
