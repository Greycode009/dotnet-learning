using System;
using System.Collections.Generic;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating and initializing lists
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(45);

            List<string> lst2 = new List<string>();
            lst2.Add("Hi");
            lst2.Add("Welcome");
            lst2.Add("TO");
            lst2.Add("Tutlane");

            Console.WriteLine("List1 Elements Count: " + lst.Count);
            Console.WriteLine("List1 Capacity: " + lst.Capacity);
            Console.WriteLine("*******List1 Elements*********");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List2 Elements Count: " + lst2.Count);
            Console.WriteLine("List2 Capacity: " + lst2.Capacity);
            Console.WriteLine("*******List2 Elements*********");
            foreach (var item in lst2)
            {
                Console.WriteLine(item);
            }

            FileStream F = new FileStream("test.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);

            }
            F.Position = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadLine();


        }
    }
}