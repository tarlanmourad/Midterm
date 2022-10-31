using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '.')
                {
                    count++;
                }
            }

            for (int i = str.Length - 1; i >= 0 && count > 1; i--)
            {
                if (str[i] == '.')
                {
                    str = str.Remove(i, 1);
                    count--;
                }
            }

            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
