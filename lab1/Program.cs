using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До якого числа рахувати?");
            int n = Int32.Parse(Console.ReadLine());
            int first = 1;
            int second = 1;
            Console.Write("{0} ", second);
            int sum = 0;
            while (n > sum)
            {
                sum = first + second;
                Console.Write("{0} ", sum);
                first = second;
                second = sum;
            }
            Console.ReadKey();
        }
    }
}
