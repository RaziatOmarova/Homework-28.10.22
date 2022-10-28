using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_28._10._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(-100, 100);
            }

            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(Find(ints));
            Console.ReadKey();
        }
        static int Find(int[] ints)
        {
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i]<0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
