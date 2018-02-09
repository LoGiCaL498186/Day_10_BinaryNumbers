using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(n, 2);

        int count = binary.Split('0')
                     .Select(num => num)
                     .Max()
                     .ToString()
                     .Length;

        Console.WriteLine(count);
        Console.ReadLine();


    }
}