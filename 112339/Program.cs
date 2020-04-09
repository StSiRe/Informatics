using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112339
{
    class Program
    {
        static void Main(string[] args)
        {

            string tmp = Console.ReadLine();
            var data = tmp.Split(' ');
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != "")
                {
                    Console.WriteLine(data[i]);
                    return;
                }
            }
        }
    }
}
