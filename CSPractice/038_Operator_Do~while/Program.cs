using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_Operator_Do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int num;
            int total = 0;

            Console.Write("0부터 몇까지 더할까요?");
            num = int.Parse(Console.ReadLine());

            do
            {
                total = total + a++;
                Console.WriteLine("{0}", a);
            } while (a <= num);

            Console.WriteLine("total:  {0}", total);
        }
    }
}
