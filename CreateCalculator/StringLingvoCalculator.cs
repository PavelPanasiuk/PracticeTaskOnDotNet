using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCalculator
{
    public class StringLingvoCalculator : StringMathCalculator
    {
        //3)Написать класс StringLingvoCalculator меняющий функциональность класса StringMathCalculator, 
        //  и предоставляющий функцию которая может обрабатывать строку вида
        //  "2+2" и выдавать решение как обьединение строк. ("2+2"-> "22")
        private int _rezult;

        public int GetRezult => _rezult;

        public override int GetSumNumbersInString(string someNumbers)
        {
            string numbers = string.Empty;
            foreach (var charecter in someNumbers)
            {
                if (char.IsDigit(charecter))
                {
                    numbers += charecter;
                }
            }
            return _rezult = Convert.ToInt32(numbers);
        }
    }
}
