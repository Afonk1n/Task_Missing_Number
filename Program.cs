using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3, 0, 1};
            //Array.Sort(nums);

            //if (nums[nums.Length - 1] != nums.Length)
            //{
            //    Console.WriteLine(nums.Length);
            //}
            //else
            //{
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (i != nums[i])
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            int n = nums.Length;
            Console.WriteLine(n * (n + 1) / 2 - nums.Sum()); //Arithmetic progression formula
            Console.ReadLine();
        }
    }
}
