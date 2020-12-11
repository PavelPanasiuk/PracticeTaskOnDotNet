using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCalculator
{
    class StringLingvoCalculator : StringMathCalculator
    {
        //3)Написать класс StringLingvoCalculator меняющий функциональность класса StringMathCalculator, 
        //  и предоставляющий функцию которая может обрабатывать строку вида
        //  "2+2" и выдавать решение как обьединение строк. ("2+2"-> "22")
        private string _rezult;

        public string GetRezult => _rezult;

        public override void GetSumNumbersInString(string someNumbers)
        {
            foreach (var charecter in someNumbers)
            {
                if (char.IsDigit(charecter))
                {
                    _rezult += charecter;
                }
            }
        }
    }
}
