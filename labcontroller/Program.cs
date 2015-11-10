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
        public string UserName { get; internal set; }
        public string Text { get; internal set; }
        public int Id { get; internal set; }
        public DateTime DatePosted { get; internal set; }
    }
    class Program
    {
        private static RestRequest request;

        //public static object msg;
        //private static IRestRequest request;

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(" Welcome to Slacker");
                Console.WriteLine(" Would you like to Submit a post or Read a post?");
                Console.WriteLine(" type Submit or Read");
                //Console.ReadLine();


                var client = new RestClient("http://localhost:51500/");


                Message msg = new Message();
                if (Console.ReadLine() == "Submit")
                {

                    Console.WriteLine("please enter UserName");
                    msg.UserName = Console.ReadLine();
                    Console.WriteLine("please enter Text");
                    msg.Text = Console.ReadLine();
                    msg.DatePosted = DateTime.Now;
                    var request = new RestRequest("api/messages/", Method.POST)
                    { RequestFormat = DataFormat.Json };
                    request.AddJsonBody(msg);
                    var response = client.Execute<Message>(request);
                    break;
                }

                else if (Console.ReadLine() == "Read")
                {

                   // var response = client.Execute<Message>(request);
                    request = new RestRequest("api/messages", Method.GET);
                    var messages = client.Execute<List<Message>>(request).Data;
                    messages.ForEach(x => Console.WriteLine(x));
                    //foreach (var x in messages)
                    //{

                    //    Console.WriteLine(x.UserName);
                    //    Console.WriteLine(x.Text);
                    //    Console.WriteLine(x.DatePosted);
                    //    Console.ReadLine();
                    //}
                }
                Console.ReadLine();



                Console.Clear();
                //
            }
        }
    }
}
