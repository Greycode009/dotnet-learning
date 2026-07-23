using System;
class Program
{
    static void Main()
    {
        int number1 = 10;
        int number2 = 20;

        PassByValue(number1);
        Console.WriteLine("After PassByValue: number1 = " + number1);

        PassByReference(ref number2);
        Console.WriteLine("After PassByReference: number2 = " + number2);

        int result = PassByValue(number1);
        Console.WriteLine("Result from PassByValue: " + result);
    }
    static int PassByValue(int a)
    {
        a = a + 20;
        return a;
    }
    static void PassByReference(ref int b)
    {
        b = b + 30;
    }
}