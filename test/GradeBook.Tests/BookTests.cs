using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(85.62);
            book.AddGrade(35.09);
            book.AddGrade(31.09);
    
            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.62, result.High, 1);//that "1" indicate precision= Number of decimal places
            Assert.Equal(31.09, result.Low, 1);
            Assert.Equal(50.6, result.Average, 1);
            Assert.Equal('F', result.Letter);

        }
    }
}
