using System;
using Xunit;
using SimpleCalculator;
using System.Collections.Generic;
using Linq;



namespace SimpleCalculator.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void MakeEquation_FirstNum_IsTrue()
        {
            var calculator = new Calculator();
            //Arrange
            var inputEquation = "10 + 3";

            //Act
            calculator.MakeEquation(inputEquation);
            var firstNum = 10;
            var operatr = "+";
            var secondNum = 3;

            //Assert
            Assert.Equal("8", result);

        }
    }
}
