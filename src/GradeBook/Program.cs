using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Dajana's grade book");
            book.AddGrade(89.1);
            book.AddGrade(8.1);
            book.AddGrade(5.67);
            var stats = book.GetStatistics();

            Console.WriteLine($"The average grades is {stats.Average:N1}");
            Console.WriteLine($"This is the highest grade {stats.High}");
            Console.WriteLine($"this is the lowest grade {stats.Low}");
            // initialization expression for array
            // var numbers = new[] { 12.7, 10.3, 6.11 };
            

            // var result = 0.0;
            // foreach(double number in numbers)
            // {
            //     result += number;
            // }

            // Console.WriteLine(result);

            // Console.WriteLine("Hello " + args[0] + "!");
            // if(args.Length > 0)
            // {
            //     Console.WriteLine($"Hello, {args[0]}!");
            // }
            // else
            // {
            //     Console.WriteLine("Hello!");
            // }
            // to run in console you have to be inside of src/GradeBook and run dotnet run -- Dajana (or any other name)
        }
    }
}
