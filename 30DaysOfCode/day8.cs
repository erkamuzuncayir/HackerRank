// Day 8: Dictionaries and Maps

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        Dictionary<string, string> phoneBook =
        new Dictionary<string, string>();
        string input, name, phoneNum;
        int howMany = int.Parse(Console.ReadLine()); 
        for(int i = 0; i < howMany; i++)
        {
            input = Console.ReadLine();
            string[] pair = input.Split(' ');
            name = pair[0];
            phoneNum = pair[1];
            phoneBook.Add(name, phoneNum);
        }
        string askInput;
        while((name = Console.ReadLine()) != null)
        {
            if(phoneBook.ContainsKey(name) == true)
            Console.WriteLine("{0}={1}", name, phoneBook[name]);
            else
            Console.WriteLine("Not found");
        }
    }
}
