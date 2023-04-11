using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolessUP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 3

            int[] nums = new int[4] { 1, 3, 5, 6 };

            int target = 5;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    Console.WriteLine($"Индекс цели: {i}") ;
            }

            Console.ReadLine();
        }
    }

}
    