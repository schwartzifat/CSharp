using System;
using System.Collections.Generic;

namespace arrayEx;
class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> evens = new List<int>();
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] % 2 == 0)
            {
                evens.Add(nums[i]);
            }
        }
        Console.WriteLine("Even numbers are:");
        foreach (var num in evens)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("Hello, World!");
        List<int> nums1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> odds = new List<int>();
        for (int i = 0; i < nums1.Count; i++)
        {
            if (nums1[i] % 2 == 0)
            {
                odds.Add(nums1[i]);
            }
        }
        Console.WriteLine("Odd numbers are:");
        foreach (int num in odds)
        {
            Console.WriteLine(num);
        }

        List<string> strs = new List<string> { "a", "ab", "abc", "abcd", "abcde" };
        List<string> longStrs = new List<string>();
        for (int i = 0; i < strs.Count; i++)
        {
            if (strs[i].Length > 3)
            {
                longStrs.Add(strs[i]);
            }
        }
        Console.WriteLine("Long strings are:");
        foreach (string str in longStrs)
        {
            Console.WriteLine(str);
        }

        List<int> powerThree = new List<int>();
        for (int i = 0; i < nums.Count; i++)
        {
            powerThree.Add((int)Math.Pow(nums[i],3));
        }
        Console.WriteLine("numbers powered by three:");
        foreach (int num in powerThree)
        {
            Console.WriteLine(num);
        }

        List<string> names1 = new List<string> { "Ifat", "Eran", "Agam", "Romi", "Yonatan" };
        List<int> namesLength = new List<int>();
        for (int i = 0; i < names1.Count; i++)
        {
            namesLength.Add(names1[i].Length);
        }
        Console.WriteLine("Names length are:");
        foreach (int nameLength in namesLength)
        {
            Console.WriteLine(nameLength);
        }

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> strings = new List<string> { "a", "ab", "abc", "abcd", "abcde" };
        List<string> names = new List<string> { "Ifat", "Eran", "Agam", "Romi", "Yonatan" };

        List<int> evenNumbers = Filter(numbers, n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        List<int> oddNumbers = Filter(numbers, n => n % 2 != 0);
        Console.WriteLine("Odd Numbers: " + string.Join(", ", oddNumbers));

        List<string> longStrings = Filter(strings, n => n.Length >3);
        Console.WriteLine("String with length more then 3: " + string.Join(", ", longStrings));

        List<double> poweredByThree = Transform(numbers, n => Math.Pow(n, 3));
        Console.WriteLine("Numbers powered by 3: " + string.Join(", ", poweredByThree));

        List<int> lengthsNames = Transform(names, n => n.Length);
        Console.WriteLine("Length of names: " + string.Join(", ", lengthsNames));

    }
    public static List<T> Filter<T>(List<T> items, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (T item in items)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

    public static List<R> Transform<T,R>(List<T> items, Func<T, R>transforme)
    {
        List<R> result = new List<R>();
        foreach(T item in items)
        {
            result.Add(transforme(item));
        }
        return result;
    }
}

