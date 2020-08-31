using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            //Taking user input from the console 
            var book = new Book("Bianca´s Grade Book");
          
            while(true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                 break;

                }
                try //Try de following code but it may throw an exeption
                {
                var grade = double.Parse(input); //Parsing the input into a floating point number 
                book.AddGrade(grade);
                }
                catch (ArgumentException ex)//Process the exeption
                {
                    
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally //When is succesfuly the code above the catch
                {
                   Console.WriteLine("**");
                }
            }
     
         var stats = book.GetStatistics();

        Console.WriteLine($"The average result is {stats.Average: N1}");
        Console.WriteLine($"The higesth result is {stats.High}");
        Console.WriteLine($"The lowest result is {stats.Low}");
        Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
