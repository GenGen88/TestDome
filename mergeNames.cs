﻿using System;
using System.Linq;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        var union = names1.Union(names2).ToArray<string>();
        return union;
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}