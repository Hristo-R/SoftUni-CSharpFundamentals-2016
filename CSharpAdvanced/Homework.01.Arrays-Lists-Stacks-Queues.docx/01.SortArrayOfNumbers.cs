namespace _01.SortArrayOfNumbers
{
    using System;

    public class SortArrayOfNumbers
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int[] nums = new int[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                nums[i] = int.Parse(strArr[i]);
            }

            Array.Sort(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
