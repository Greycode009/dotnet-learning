using System;
using System.Threading.Tasks;

class Program
{
    static async Task DownloadFileAsync(string fileName, int delayMs)
    {   
        Console.WriteLine($"Starting download: {fileName}");
        await Task.Delay(delayMs);
        Console.WriteLine($"Completed download: {fileName}");

    }
    static async Task Main()
    {
        Console.WriteLine("==== Download Started ====");

        Task task1 = DownloadFileAsync("Document.pdf", 2000);
        Task task2 = DownloadFileAsync("Image.jpg", 1000);

        await Task.WhenAll(task1, task2);
        Console.WriteLine("=== All Downloads finished! ===");

    }
}