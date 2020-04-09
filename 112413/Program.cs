using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112413
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            List<Person> data = new List<Person>();
            int max = int.MinValue;
            for (int i = 0; i < k; i++)
            {
                var tmp = Console.ReadLine().Split(' ');
                Person p = new Person();
                p.name = tmp[0];
                p.fname = tmp[1];
                p.year = tmp[2];
                int tmp1 = Convert.ToInt32(tmp[3]);
                p.balls = tmp1;
                if (tmp1 > max)
                    max = tmp1;
                data.Add(p);
            }
            for (int i = 0; i < k; i++)
            {
                if (data[i].balls == max)
                    Console.WriteLine(data[i].name + " " + data[i].fname);

            }
            Console.WriteLine(max);

        }

    }
    class Person
    {
        public string name { get; set; }

        public string fname { get; set; }
        public string year { get; set; }
        public int balls { get; set; }
    }
}
