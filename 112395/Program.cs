using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112395
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = System.IO.File.ReadAllLines("input.txt");
            List<string> da = new List<string>();
            foreach (var item in data)
            {
                var s = item.Split(' ');
                foreach (var i in s)
                {
                    da.Add(i);
                }
            }
            int max = int.MinValue;
            foreach (var item in da)
            {
                if (item.Length > max) max = item.Length;
            }
            foreach (var d in da)
            {
                if (max == d.Length)
                {
                    System.IO.File.WriteAllText("output.txt", d);
                    return;
                }
            }
        }
    }
}
