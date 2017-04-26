using System;
using WebCoreApplication.Services;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void SampleBusinessLogic_AddTwoNumbers_ShouldAddTwoDoubles() 
        {
            // Arrange
            SampleBusinessLogic sbl = new SampleBusinessLogic();
            double expected = 2.00, actual;

            // Act
            actual = sbl.AddTwoNumbers(1.00, 1.00);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
