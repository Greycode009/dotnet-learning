using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Display the elements of the 2D array
        Console.WriteLine($"Total number of elements in the 2D array: {matrix.Length}");
        Console.WriteLine($"Number of rows (Dimension 0): {matrix.GetLength(0)}");
        Console.WriteLine($"Number of columns (Dimension 1): {matrix.GetLength(1)}");
        Console.WriteLine("--------------------------------------------");
        
        //Method 1: Using nested for loops to display the elements of the 2D array
        Console.WriteLine("-----Printing Grid View (Nested Loops)-----");

        //matrix.GetLength(0) - Number of rows
        //matrix.GetLength(1) - Number of columns
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
        //Method 2: Using foreach loop to display the elements of the 2D array
        Console.WriteLine("-----Printing Grid View (Foreach Loop)-----");
        foreach (int element in matrix)
        {
            Console.Write(element + "\t");
        }
        Console.WriteLine();
    }

}