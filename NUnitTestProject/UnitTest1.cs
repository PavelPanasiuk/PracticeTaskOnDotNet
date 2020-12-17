using NUnit.Framework;
using System;
using CreateCalculator;

namespace NUnitTestProject
{
    public class Tests
    {
        //1)Установить NUnit
        //2)Написать Hello world используя NUnit test вместо main методаю.
        //3)Написать unit тесты для классов Calculator, StringMathCalculator, StringLingvoCalculator 
        //4)Отключить один из юнит тестов

        private Calculator _calculator = new Calculator();
        private StringMathCalculator _stringMath = new StringMathCalculator();
        private StringLingvoCalculator _stringLingvo = new StringLingvoCalculator();

        [SetUp]
        public void Setup()
        {

        }
        [Ignore("Write_HelloWorld_ToConsole")]


        [Test]
        public void Write_HelloWorld_ToConsole()
        {
            Console.WriteLine("Hello world");
        }

        [Test]
        public void Add_TwoNumbers_ReturnSumOfNumbers()
        {
            int actualSum = _calculator.GetSum(2, 2);
            int expectedSum = 4;
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void Add_TwoNumbers_ReturnDifferenceOfNumbers()
        {
            int actualDifference = _calculator.GetDifference(20, 11);
            int expectedDifference = 9;
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [Test]
        public void Add_TwoNumbers_ReturnCompositionOfNumbers()
        {
            int actualComposition = _calculator.GetComposition(7, 7);
            int expectedComposition = 49;
            Assert.AreEqual(expectedComposition, actualComposition);
        }

        [Test]
        public void Add_TwoNumbers_ReturnQoutient()
        {
            int actualQuotient = _calculator.GetQuotient(8, 4);
            int expectedQoutient = 2;
            Assert.AreEqual(expectedQoutient, actualQuotient);
        }

        [Test]
        public void Add_StringWithTwoNumbers_ReturnRezultOfAdding()
        {
            int actualRezultFromString = _stringMath.GetSumNumbersInString("5*5");
            int expectedRezult = 25;
            Assert.AreEqual(expectedRezult, actualRezultFromString);
        }

        [Test]
        public void Add_StringWithNumbers_ReturnOnlyNumbers()
        {
            int actualNumberFromString = _stringLingvo.GetSumNumbersInString("hjh1h2jhn7");
            int expectedNumberFromString = 127;
            Assert.AreEqual(expectedNumberFromString, actualNumberFromString);
        }
    }
}