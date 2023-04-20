using System;

namespace unit3_2
{

    internal class Program
    {
        public static string TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int sum = nums[i] + nums[j];
                    if (sum == target)
                    {
                        string indexes = $"[{i}, {j}]";
                        return indexes;
                    }
                }
            }
            return "Такое число нельзя получить суммой двух элементов из массива";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чисело");
            int target = int.Parse(Console.ReadLine());
            int[] nums = { 2, 7, 11, 15 };
            Console.WriteLine(TwoSum(nums, target));
            Console.ReadKey();
        }
    }
}
