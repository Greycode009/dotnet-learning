using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>  {1,2,3,4,5,6,7,8,9,10};

        var result = numbers.Where(n => n%2 == 0 ).Select(n => n * n).OrderByDescending(n => n);

        Console.WriteLine("Processed Results:");
        foreach(var val in result)
        Console.WriteLine(val);
    }
}