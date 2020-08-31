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
            book.AddGrade(285.6);
            book.AddGrade(235.09);
            book.AddGrade(231.09);
    
            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(285.6, result.High, 1);//that "1" indicate precision= Number of decimal places
            Assert.Equal(231.09, result.Low, 1);
            Assert.Equal(250.6, result.Average, 1);

        }
    }
}
