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
        public void AddLetterGrade(char letter)//char =single character
        {
         switch (letter)
         {
             case 'A':
             AddGrade(90);
             break;
             case 'B' :
             AddGrade(80);
             break;
             case 'C':
             AddGrade(70);
             break;
             case'D':
             AddGrade(60);
             break;

             default:
             AddGrade(0);
             break;
         }

        }

        public void AddGrade(double grade)
        {
            if (grade<=100 && grade>=0)
            {
             grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
      
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
            switch(result.Average)
            {
                case var d when d>= 90.0: //Only if when returns true will be executed de code asociated w the case statment
                    result.Letter = 'A';
                    break;
                case var d when d>= 80.0: //Only if when returns true will be executed de code asociated w the case statment
                    result.Letter = 'B';
                    break;
                case var d when d>= 70.0: //Only if when returns true will be executed de code asociated w the case statment
                    result.Letter = 'C';
                    break;
                case var d when d>= 60.0: //Only if when returns true will be executed de code asociated w the case statment
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter= 'F';
                    break;
            }

            return result;
        }
        private List<double> grades;
    public string Name; //When is public always has an uppercase name
    }

}