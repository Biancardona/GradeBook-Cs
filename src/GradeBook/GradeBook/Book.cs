using System;
using System.Collections.Generic;

namespace GradeBook
{
    
    public class Book{
         public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()//Resturns an object of type statistics 
        {
            var result =new Statistics();//New instance 
            result.Average = 0.0; 
            result.High = double.MinValue; //Initialize with the lowest value (MinValue property smallest possible value)
            result.Low = double.MaxValue; //Initializing with the higher floating type possible value
            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High); //Obtaining highGrade comparing number with highGrade (it´s initialize w lowest value); 
                result.Low = Math.Min(grade, result.Low);
                result.Average+= grade;
            }
            result.Average /= grades.Count;
            return result;
        }
        private List<double> grades;
    public string Name; //When is public always has an uppercase name
    }

}