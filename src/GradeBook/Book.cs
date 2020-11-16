using System;
using System.Collections.Generic;

namespace GradeBook
    {
        public class Book
        {
            // this is constructor, has to be the same name as the class
            public Book(string name)
            {
                grades = new List<double>();
                this.Name = name;
            }
            public void AddGrade(double grade)
            {
                grades.Add(grade);
            }
            public Statistics GetStatistics()
            {
                var result = new Statistics();
                result.Average = 0.0;

                result.High = double.MinValue;
                result.Low = double.MaxValue;
                var gradesLenght = grades.Count;

                foreach(double grade in grades)
                {
                    // if(grade > highGrade)
                    // {
                    //     highGrade = grade;
                    // }

                    if(grade < result.Low){
                        result.Low = grade;
                    }

                    result.High = Math.Max(grade, result.High);
                    result.Average += grade;
                    
                }
                // averageGrade = averageGrade / gradesLenght;
                result.Average /= gradesLenght;

                //N1 in this case converts the number to only 1 decimal number

                // Console.WriteLine($"The average grades is {result.Average:N1}");
                // Console.WriteLine($"This is the highest grade {result.High}");
                // Console.WriteLine($"this is the lowest grade {result.Low}");
                return result;
            }
            // we can't use var outside of this method, that is why grades are declared as List<double> grades;

            private List<double> grades;
            public string Name;

        public double Average { get; private set; }
    }
    }
