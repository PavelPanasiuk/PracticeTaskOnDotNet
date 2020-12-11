using System;

namespace CreateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)Написать класс Calculator, который может сложить, вычесть, разделить, 
            //  умножить два числа и имеет функцию сохранения текущего результата.
            //2)Написать класс StringMathCalculator расширяющий функциональность класса Calculator, 
            //  и предоставляющий функцию которая может обрабатывать строку вида
            //  "2+2" и выдавать решение такой простейшей арифметической операции("2+2"-> "4")
            //3)Написать класс StringLingvoCalculator меняющий функциональность класса StringMathCalculator, 
            //  и предоставляющий функцию которая может обрабатывать строку вида
            //  "2+2" и выдавать решение как обьединение строк. ("2+2"-> "22")
            StringLingvoCalculator stringLingvoCalculator = new StringLingvoCalculator();
            StringMathCalculator stringMathCalculator = new StringMathCalculator();
            stringMathCalculator.GetSum(2, 10);
            Console.WriteLine(stringMathCalculator.GetRezult);
            stringMathCalculator.GetSumNumbersInString("8*4");
            stringLingvoCalculator.GetSumNumbersInString("1f22bjhbjhv876kjhkjhk2222r3");

            Console.WriteLine(stringLingvoCalculator.GetRezult);
        }
    }
}