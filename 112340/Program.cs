using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112340
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            var data = tmp.Split(' ');
            for (int i = data.Length-1; i >= 0; i--)
            {
                if(data[i] != "")
                {
                    Console.WriteLine(data[i]);
                    return;
                }
            }
        }
    }
}
