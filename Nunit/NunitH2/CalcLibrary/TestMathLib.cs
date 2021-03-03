using System;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NunitH2;

namespace TestMathLib
{
    [TestFixture]
    public class CalculatorTester
    {
        private SimpleCalculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();

        }
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 4, 6)]

        public void CalculatorAddMethod(int a, int b, int Result)
        {
            //Calculator add = new Calculator();
            var result = calculator.Addition(a, b);
            //Assert.That(result, Is.EqualTo(Result));
            Assert.AreEqual(result, Result);

        }
        
        [Test]
        [TestCase(3, 1, 2)]
        [TestCase(4, 2, 2)]
        public void CalculatorSubMethod(int a, int b, int Result)
        {
            //Calculator add = new Calculator();
            var result = calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(Result));
        }
       
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 4, 8)]
        public void CalculatorMulMethod(int a, int b, int Result)
        {
           
            var result = calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(Result));
            
        }
       
        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(12, 0, 0)]
        public void CalculatorDivMethod(int a, int b, int Result)
        {
            //Calculator add = new Calculator();
            SimpleCalculator add = new SimpleCalculator();
            try
            {
                var result = calculator.Division(a, b);
                Assert.That(result, Is.EqualTo(Result));
            }
            catch (ArgumentException e)
            {
                Assert.Fail("Division by Zero", e);
            }
            
        }
    }
}
