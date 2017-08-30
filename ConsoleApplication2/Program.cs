using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Net;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient client = new WebClient())
            {
               
                string url = "https://mail.ru";
                string wrongUrl = "https://mai1.ru";
                try { 
               // string content = client.DownloadString(url);
                string secondContent = client.DownloadString(wrongUrl);
              // Console.WriteLine(content);//верный
                Console.WriteLine(secondContent);//не верный;
                }
                catch (System.Net.WebException e  )
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
