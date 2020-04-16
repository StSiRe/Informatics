using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112359
{
    class Program
    {
        public static int k =0;
        static int count(string s,char c)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) count++;
            }
            return count;
        }
        static void Tumba(string alp,string w,int l)
        {
            if(w.Length == l)
            {
                if(count(w,alp[0]) > 1)
                {
                    Console.WriteLine(w);
                    k++;
                }
                return;
            }
            foreach (var item in alp)
            {
                Tumba(alp, w + item, l);
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();                
            int n = Convert.ToInt32(Console.ReadLine());
            Tumba(s, "", n);
            Console.WriteLine(k);
        }
    }
}
