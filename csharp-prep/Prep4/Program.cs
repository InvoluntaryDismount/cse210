using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        
        // prep work
        List<float> nums = new List<float>();
        float num = -134353653;
        float sum = 0;

        //  loop to get numbers and append to nums
        do    
        {
        Console.Write("Enter a number: ");
        num = float.Parse(Console.ReadLine());
        nums.Add(num);
        } while (num != 0);
    
        // calculations
        foreach (int value in nums)
        {
            sum += value;
        }

        float avg =  sum / nums.Count;
        float max = nums.Max();


       Console.WriteLine($"The sum is: {sum}");
       Console.WriteLine($"The average is: {avg}");
       Console.WriteLine($"The largest number is: {max}");
    }
}