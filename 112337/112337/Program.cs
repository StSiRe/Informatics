using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112337
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            int counter = 0;
            foreach(var c in tmp)
            {
                if (c == 'a' || c == 'A')
                    counter++;
            }
            tmp = tmp.Replace('a', 'b');
            tmp = tmp.Replace('A', 'B');
            Console.WriteLine(tmp);
            Console.WriteLine(counter);
        }
    }
}
