using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCalculator
{
    public class StringMathCalculator : Calculator
    {
        //2)Написать класс StringMathCalculator расширяющий функциональность класса Calculator, 
        //  и предоставляющий функцию которая может обрабатывать строку вида
        //  "2+2" и выдавать решение такой простейшей арифметической операции("2+2"-> "4")
        private int _rezult;

        public int GetRezult => _rezult;

        public virtual int GetSumNumbersInString(string someNumbers)
        {
            int firstNumber = int.Parse(someNumbers[0].ToString());
            char mathematicalSign = someNumbers[1];
            int secondNumber =int.Parse(someNumbers[2].ToString());           
            
            switch (mathematicalSign)
            {
                case '+':
                   _rezult = firstNumber + secondNumber;
                    break;
                case '-':
                    _rezult = firstNumber - secondNumber;
                    break;
                case '*':
                    _rezult = firstNumber * secondNumber;
                    break;
                case '/':
                    _rezult = firstNumber / secondNumber;
                    break;
            }
            return _rezult ;
        }
    }
}
