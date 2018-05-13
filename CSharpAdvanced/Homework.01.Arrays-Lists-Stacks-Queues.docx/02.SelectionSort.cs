namespace _02.SelectionSort
{
    using System;

    public class SelectionSort
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            int arrLength = strArr.Length;
            int[] nums = new int[arrLength];
            int minNum;
            int temp;

            for (int i = 0; i < arrLength; i++)
            {
                nums[i] = int.Parse(strArr[i]);
            }

            for (int i = 0; i < arrLength; i++)
            {
                minNum = nums[i];

                for (int j = i; j < arrLength; j++)
                {
                    if (nums[j] < minNum)
                    {
                        minNum = nums[j];
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
