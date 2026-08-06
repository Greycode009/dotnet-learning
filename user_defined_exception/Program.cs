
// using System;

class MyException : Exception
{
    public MyException(string str)
    {
        Console.WriteLine("User defined exception" + str);
    }
}

class MyClient
{
    public static void Main()
    {
        try
        {
            throw new MyException("This is the user defined exception");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught here: " + e.ToString());
        }

        Console.WriteLine("Program continues after the exception");
    }
}