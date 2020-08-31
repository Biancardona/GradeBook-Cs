using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Bianca´s Grade Book");
            book.AddGrade(89.18);
            book.AddGrade(90.50);
            book.AddGrade(102.34);
         var stats = book.GetStatistics();

        Console.WriteLine($"The average result is {stats.Average}");
        Console.WriteLine($"The higesth result is {stats.High}");
        Console.WriteLine($"The lowest result is {stats.Low}");
        }
    }
}
