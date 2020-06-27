using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _046_Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int max = 0;
            int min = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                if(i==0)
                {
                    max = input;
                    min = input;
                }
                else if(max < input)
                {
                    max = input;
                }
                else if(min > input)
                {
                    min = input;
                }
            }
            Console.WriteLine("최대값: {0} 최소값: {1}", max, min);
        }
    }
}
