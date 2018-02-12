using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsumer
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var client = new ServiceReference1.Service1Client())
            {
                Console.WriteLine(client.GetMyName());
            }

            Console.ReadLine();
        }
    }
}
