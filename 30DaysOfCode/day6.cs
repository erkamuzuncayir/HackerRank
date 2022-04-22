// Day 6: Let's Review

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int x = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < x; i++)
        {
            List<char> charList = (Console.ReadLine().ToList());

            var oddIndex = charList.Where((odd, index) => index % 2 != 0);
            var evenIndex = charList.Where((even, index) => index % 2 == 0);
                foreach (var e in evenIndex)
                    Console.Write(e);
                    Console.Write(' ');
                foreach (var o in oddIndex)
                    Console.Write(o);
                    Console.WriteLine();
            charList.Clear();
        }
}
}
