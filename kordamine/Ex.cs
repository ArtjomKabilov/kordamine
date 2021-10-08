using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class Ex
    {
        public static void Main(string[] args)
        {

            Random rnd = new Random();
            int N = rnd.Next(2, 8);
            int M = rnd.Next(9, 15);
            int[] number = new int [M-N];
            for (int i = N; i < M+1; i++)
            {


                number[i-N] = i;
                Console.WriteLine(" {0} ", i * i);
            }
            foreach (var m in number)
            {
                Console.WriteLine("{0}", m);
            }

            Console.WriteLine("---------------------------");
            /*
            Console.WriteLine("Напиши первое число:");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напиши второе число:");
            double two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напиши третье число:");
            double three = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напиши четвёртое число:");
            double four = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напиши пятое число:");
            double five = Convert.ToDouble(Console.ReadLine());*/

            
            







            Console.ReadLine();

        }
    }
}
