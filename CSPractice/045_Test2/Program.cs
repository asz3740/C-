using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int input;
            int count = 0;
            int a = rnd.Next(1, 100);
            while (true)
            {
                Console.Write("1~99사이 어떤 숫자일까요(단, 0은 나가기)");
                input = int.Parse(Console.ReadLine());

                //Console.WriteLine("{0},{1}", a);

                if (input == 0)
                {
                    break;
                }

                if (input < a)
                {
                    Console.WriteLine("입력한 수는 작아요");
                    count++;
                }
                else if (input > a)
                {
                    Console.WriteLine("입력한 수는 커요");
                    count++;
                }
                else if(input == a)
                {
                    Console.WriteLine("=== 정답입니다. ===");
                    count++;
                    Console.WriteLine("총 {0}번 시도", count);
                }
                

            
            }
    
        }
    }
}
