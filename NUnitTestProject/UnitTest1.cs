using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    public class Tests
    {
        //3)Написать unit тесты для классов Calculator, StringMathCalculator, StringLingvoCalculator 
        private string _someText = "Hello world";
        private int _actualSum;
        private int _actualDifference;
        private int _actualComposition;
        private int _actualQuotient;
        private int _actualRezultFromString;
        private int _actualNumberFromString;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine(_someText);
            CreateCalculator.Calculator calculator = new CreateCalculator.Calculator();
            _actualSum = calculator.GetSum(2, 2);
            _actualDifference = calculator.GetDifference(20, 11);
            _actualComposition = calculator.GetComposition(7, 7);
            _actualQuotient = calculator.GetQuotient(8, 4);
            CreateCalculator.StringMathCalculator stringMath = new CreateCalculator.StringMathCalculator();
            _actualRezultFromString = stringMath.GetSumNumbersInString("5*5");
            CreateCalculator.StringLingvoCalculator stringLingvo = new CreateCalculator.StringLingvoCalculator();
            _actualNumberFromString = stringLingvo.GetSumNumbersInString("hjh1h2jhn7");
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(_someText == "Hello world");
        }

        [Test]
        public void CheckSum()
        {
            Assert.AreEqual(4, _actualSum);
        }

        [Test]
        public void CheckDifference()
        {
            Assert.AreEqual(9, _actualDifference);
        }

        [Test]
        public void CheckComposition()
        {
            Assert.AreEqual(49, _actualComposition);
        }

        [Test]
        public void CheckQuotient()
        {
            Assert.AreEqual(2, _actualQuotient);
        }

        [Test]
        public void CheckMathRezultFromString()
        {
            Assert.AreEqual(21, _actualRezultFromString);
        }

        [Test]
        public void CheckNumberInString()
        {
            Assert.AreEqual(127, _actualNumberFromString);
        }
    }
}