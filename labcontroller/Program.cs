using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labcontroller
{
    public class Message
    {

    }
    class Program
    {
        static void Main(string[] args)
        {



            //var client = new RestClient("http://deckofcardsapi.com");
            //var newDeckAndShuffle = new RestRequest("api/deck/new/shuffle/?deck_count=1", Method.GET);
            //DeckResponse response = client.Execute<DeckResponse>(newDeckAndShuffle).Data;


            //while (true)
            //    message msg = new message();
            //msg text = "hello"





            var client = new RestClient("http://localhost:51500/");


            var request = new RestRequest("api/message", Method.POST)
            {
                requestformat = dataformat.Json);


            request.addJsosngBody(msg);
        }

        var response = client.executes<message>(request);


        request = new RestRequest("api/message",Method.GET)
            var messages = client.Execute<List<Messages>(request).Data;

        Console.Clear();
            message.foreach(x=>Console.WriteLine(x));



            //Console.WriteLine(" Welcome to Slacker");
            //Console.WriteLine(" Would you like to Submit a post or Read a post?");
            //Console.WriteLine(" type Submit or Read");
            //Console.ReadLine();
            //if (Console.ReadLine() == "Read")
            //{
            //}
            //else if (Console.ReadLine() == "Submit")
            //{
            //    Console.WriteLine("please enter username");
            //    Console.WriteLine("please enter text");
            //}
            //Console.ReadLine();
        }
}
}
