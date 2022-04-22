// Day 1: Data Types

using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        // Declare second integer, double, and String variables.
        int x;
        double y;
        string z;
        // Read and save an integer, double, and String to your variables.
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());
        z = Convert.ToString(Console.ReadLine());
        
        // Print the sum of both integer variables on a new line.
        int sumOfInts = i + x;
        Console.WriteLine(sumOfInts);
        // Print the sum of the double variables on a new line.
        double sumOfDoubles = d + y;
        string stringifiedDoubles = sumOfDoubles.ToString("0.0");
        Console.WriteLine(stringifiedDoubles);
        // Concatenate and print the String variables on a new line
        string concatenateOfStrings = String.Concat(s + z);
        Console.WriteLine(concatenateOfStrings);
        // The 's' variable above should be printed first.
    }
