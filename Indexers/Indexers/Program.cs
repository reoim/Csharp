using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookies = new HttpCookie();
            cookies["name"] = "Reo";
            Console.WriteLine(cookies["name"]);

        }
    }
}
