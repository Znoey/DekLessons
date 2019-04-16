using System;
using System.IO;

namespace Lesson01.FileExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text you want to save.");
            var input = Console.ReadLine();
            File.WriteAllText("newFile.txt", input);

            Console.WriteLine("Done!");
        }
    }
}
