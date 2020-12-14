using System;
using System.Collections.Generic;
using System.Text;

namespace CreateCalculator
{
    public class Calculator
    {
        //1)Написать класс Calculator, который может сложить, вычесть, разделить, 
        //  умножить два числа и имеет функцию сохранения текущего результата.

        private int _rezult;

        public int GetRezult => _rezult;

        public int GetSum(int x, int y)
        {
            return _rezult = x + y;
        }

        public int GetDifference(int x, int y)
        {
            return _rezult = x - y;
        }

        public int GetQuotient(int x, int y)
        {
            try
            {
                _rezult = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _rezult;
        }

        public int GetComposition(int x, int y)
        {
            return _rezult = x * y;
        }
    }
}
