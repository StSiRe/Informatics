using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112398
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = System.IO.File.ReadAllLines("input.txt");
            int k = Convert.ToInt32(s[0]);
            int counter = 0;
            string output = "";
            for (int i = 1; i < s.Length; i++)
            {
                var t = s[i].Split(' ');
                if (Convert.ToInt32(t[1]) < k)
                {
                    counter++;
                    output += (s[i] + '\n');
                }
            }
            System.IO.File.WriteAllText("output.txt", output + '\n' + counter.ToString());
        }
    }
}
