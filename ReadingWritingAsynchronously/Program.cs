using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await ReadFromFileAsync();
    }

    static async Task ReadFromFileAsync()
    {
        Console.WriteLine("Please write some text::");
        string userInput = Console.ReadLine();

        await File.WriteAllTextAsync("file.txt", userInput);
        Console.WriteLine("Content written to the file successfully.");

        string fileContent = await File.ReadAllTextAsync("file.txt");
        Console.WriteLine($"File read successfully: \n{fileContent}");
    }
}