using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112343
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp, tmp1 = Console.ReadLine();
            tmp = new string(tmp1.Reverse().ToArray());
            if (tmp == tmp1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            }
    }
}
