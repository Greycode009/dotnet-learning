using System;
using System.IO;
namespace FileIOStreamWriterDemo
{
    class StreamWriterDemo
    {
        class WriteToFile
        {
            public void Data()
            {
                StreamWriter sw = new StreamWriter("demo.txt");
                Console.WriteLine("Enter the text you want to write on File: ");
                
                //TO read the input from the user
                string str = Console.ReadLine();
                sw.WriteLine(str); //To write a line in buffer
                sw.Flush();
                sw.Close();

            }
        }
        static void Main(string[] args)
        {
            WriteToFile wr = new WriteToFile();
            wr.Data();
            Console.ReadKey();
        }
    }
}