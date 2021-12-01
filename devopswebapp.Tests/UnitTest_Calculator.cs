using System;
using Xunit;
using devopswebapp.Models;
using System.Runtime.InteropServices;

namespace devopswebapp.Tests
{
    public class UnitTest_Calculator
    {
        // private readonly Random _random = new Random();
        // private double valueOne = _random.NextDouble(1, 1000);
        // private double valueTwo = _random.NextDouble(1, 1000);


        private double valueOne = 3;
        private double valueTwo = 5;
        private double knownTotal = 8;
        public UnitTest_Calculator()
        { }

        [Fact]
        public void TestCalculator()
        {
            Calculation calc = new Calculation();
            var totalValue = calc.AddTwoValues(valueOne, valueTwo);
            // double knownTotal = valueOne + valueTwo;
            Assert.Equal(totalValue, knownTotal);
        }
    }
}
