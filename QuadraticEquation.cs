﻿using System;

public class QuadraticEquation
{
    public static Tuple<double, double> FindRoots(double a, double b, double c)
    {
        double x1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
        double x2 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
        return Tuple.Create(x2, x1);
    }

    public static void Main(string[] args)
    {
        Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
        Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
    }
}