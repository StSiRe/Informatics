using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112396
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = System.IO.File.ReadAllLines("input.txt");
            List<string> res = new List<string>();
            for (int j = 0; j < data.Length; j++)
            {
                for (int i = 1; i < data.Length - j; i++)
                {
                    char a1 = data[i][data[i].Length - 1];
                    char a2 = data[i - 1][data[i - 1].Length - 1];
                    int a = Convert.ToInt32(a1.ToString());
                    int b = Convert.ToInt32(a2.ToString());

                    if (a < b)
                    {
                        var tmp = data[i];
                        data[i] = data[i - 1];
                        data[i - 1] = tmp;
                    }
                }
            }
            System.IO.File.WriteAllLines("output.txt", data);
        }
    }
}
