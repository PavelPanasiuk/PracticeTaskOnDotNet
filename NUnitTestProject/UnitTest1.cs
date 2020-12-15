using NUnit.Framework;
using System;

namespace NUnitTestProject
{
    public class Tests
    {
        //1)Установить NUnit
        //2)Написать Hello world используя NUnit test вместо main методаю.
        //3)Написать unit тесты для классов Calculator, StringMathCalculator, StringLingvoCalculator 
        //4)Отключить один из юнит тестов

        private string _someText = "Hello world";        

        [SetUp]
        public void Setup()
        {
            Console.WriteLine(_someText);            
        }

        [Test]
        public void Test1()
        {
            Assert.Ignore();
            Assert.IsTrue(_someText == "Hello world");
        }

        [Test]
        public void Add_TwoNumbers_ReturnSumOfNumbers()
        {
            CreateCalculator.Calculator calculator = new CreateCalculator.Calculator();
            int actualSum = calculator.GetSum(2, 2);
            int existedSum = 4;
            Assert.AreEqual(existedSum, actualSum);
        }

        [Test]
        public void Add_TwoNumbers_ReturnDifferenceOfNumbers()
        {
            CreateCalculator.Calculator calculator = new CreateCalculator.Calculator();
            int actualDifference = calculator.GetDifference(20, 11);
            int existedDifference = 9;
            Assert.AreEqual(existedDifference, actualDifference);
        }

        [Test]
        public void Add_TwoNumbers_ReturnCompositionOfNumbers()
        {
            CreateCalculator.Calculator calculator = new CreateCalculator.Calculator();
            int actualComposition = calculator.GetComposition(7, 7);
            int existedComposition = 49;
            Assert.AreEqual(existedComposition, actualComposition);
        }

        [Test]
        public void Add_TwoNumbers_ReturnQoutient()
        {
            CreateCalculator.Calculator calculator = new CreateCalculator.Calculator();
            int actualQuotient = calculator.GetQuotient(8, 4);
            int existedQoutient = 2;
            Assert.AreEqual(existedQoutient, actualQuotient);
        }

        [Test]
        public void Add_StringWithTwoNumbers_ReturnRezultOfAdding()
        {
            CreateCalculator.StringMathCalculator stringMath = new CreateCalculator.StringMathCalculator();
            int actualRezultFromString = stringMath.GetSumNumbersInString("5*5");
            int existedRezult = 25;
            Assert.AreEqual(existedRezult, actualRezultFromString);
        }

        [Test]
        public void Add_StringWithNumbers_ReturnOnlyNumbers()
        {
            CreateCalculator.StringLingvoCalculator stringLingvo = new CreateCalculator.StringLingvoCalculator();
            int actualNumberFromString = stringLingvo.GetSumNumbersInString("hjh1h2jhn7");
            int existedNumberFromString = 127;
            Assert.AreEqual(existedNumberFromString, actualNumberFromString);
        }
    }
}