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
            //1)Улучшить класс Calculator перехватывая деление на ноль, и вместо exception выдавая 
            //сообщение об ошибке в консоль

            StringLingvoCalculator stringLingvo = new StringLingvoCalculator();
            stringLingvo.GetSumNumbersInString("*0*1*2");
            Console.WriteLine(stringLingvo.GetRezult);            

            StringMathCalculator stringMath = new StringMathCalculator();
            stringMath.GetSumNumbersInString("8+4");
            Console.WriteLine(stringMath.GetRezult);

        }
    }
}