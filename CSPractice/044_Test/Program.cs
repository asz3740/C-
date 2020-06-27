using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int input;
            int correctcount = 0;
            Random rnd = new Random();
            
            while (count <= 5)
            {
                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)", count);
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);
                Console.WriteLine("{0} + {1} = ??", a, b);
                input = int.Parse(Console.ReadLine());
                if (input == (a + b))
                {
                    Console.WriteLine("== 정답 ==");
                    correctcount++;
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", a + b);
                }
                count++;
            }
            Console.WriteLine(correctcount);
        }
    }
}
