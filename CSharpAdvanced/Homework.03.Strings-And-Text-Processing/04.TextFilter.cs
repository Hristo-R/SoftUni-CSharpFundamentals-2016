using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextFilter
{
    public static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        StringBuilder newText = new StringBuilder(text);
        string newStr;
        int index;

        Console.WriteLine();
        for (int i = 0; i < bannedWords.Length; i++)
        {
            index = text.IndexOf(bannedWords[i], 0);
            if (index != -1)
            {
                newStr = new string('*', bannedWords[i].Length);
                newText.Replace(bannedWords[i], newStr);
            }
        }

        Console.WriteLine(newText.ToString());
    }
}