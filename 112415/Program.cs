using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _112415
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp = Console.ReadLine();
            string tmp1 = "";
            long res = 0;
            tmp = "+" + tmp;
            for (int i = tmp.Length - 1; i >= 0 ; i--)
            {
                if (tmp[i] == '+')
                {
                    tmp1 = new string(tmp1.Reverse().ToArray());
                    if (tmp1 != "")
                        res += Convert.ToInt64(tmp1);
                    tmp1 = "";
                }
                else if(tmp[i]== '-')
                {
                    tmp1 = new string(tmp1.Reverse().ToArray());
                    if (tmp1 != "")
                        res -= Convert.ToInt64(tmp1);
                    tmp1 = "";
                }
                else
                {
                    tmp1 += tmp[i];
                }
            }
            Console.WriteLine(res);
        }
    }
}
