// Day 10: Binary Numbers

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        decimal n = Convert.ToInt32(Console.ReadLine().Trim());
        // our digit list
        List<decimal> digitList = new List<decimal>();
        // fill with binary digits
        while(n >= 1)
            {
                decimal e = n % 2;
                n = Math.Floor(n / 2);
                digitList.Add(e);
            }
        // creating result and control variables
        decimal result = 0;
        decimal control = 0;
        // searching consecutive 1's
        for(var i = 0; i < digitList.Count; i++)
            {
                if(digitList[i] == 1)
                    {
                        control++;
                    }
                else
                    if(control > result)
                    {
                        result = control;
                        control = 0;
                    }
                    else
                        control = 0;
            }
            // last check for consecutives
            if(control > result)
                {
                    result = control;
                }
        Console.WriteLine(result);
    }
}
