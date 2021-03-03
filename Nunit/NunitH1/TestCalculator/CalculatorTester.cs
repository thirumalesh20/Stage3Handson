using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitH1;

namespace TestCalculator
{
    [TestFixture]
    public class CalculatorTester
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();

        }
        [Test]
        [TestCase(1,2,3)]
        [TestCase(2,4,6)]

    public void CalculatorAddMethod(int a,int b,int Result)
        {
            //Calculator add = new Calculator();
            var result = calculator.Add(a, b);
            Assert.That(result,Is.EqualTo(Result));
        }
    }
}
