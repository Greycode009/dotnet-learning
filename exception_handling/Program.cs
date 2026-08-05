using System;
class MyClient
{
    public static void Main()
    {
        int x = 0;
        int div = 0;
        try
        {
            div = 100/x;
            Console.WriteLine("Result is: {0}", div);   
        }
        catch (DivideByZeroException e)// or we can use DivideByZeroException e to catch only divide by zero exception
        {
            Console.WriteLine("An error occurred: {0}", e.Message); 
        }
        Console.WriteLine($"Result is {div}");
    }
}