using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        // [Fact] is an attribute, little piece of data that is attached to Test1 method
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // 3sections : 1.arrange, 2.act, 3.assert
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var stats = book.GetStatistics();

            Assert.Equal(85.6, stats.Average, 1);
            Assert.Equal(77.3, stats.Low, 1);
            Assert.Equal(90.5, stats.High, 1);



        }
    }
}
