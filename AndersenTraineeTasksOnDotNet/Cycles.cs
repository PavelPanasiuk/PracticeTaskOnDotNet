using System;
using System.Collections.Generic;
using System.Text;

namespace CycleTask
{
    class Cycles
    {
        //Написать отдельную функцию выводящую 'Hello World' 333 раза с
        //использованием всех операторов перебора возможных в C#
        private static int _numberOfCalls = 0;
        private string[] _arrayString = new string[333 / 4];

        private void UseForCycle()
        {
            Console.WriteLine("\nUse \"For Cycle\":\n");
            for (int i = 0; i < 333 / 4; i++)
            {
                _arrayString[i] = "Hello world";
                Console.WriteLine($"{++_numberOfCalls} {_arrayString[i]}");
            }
        }

        private void UseForeachCecle()
        {
            Console.WriteLine("\nUse \"Foreach Cycle\":\n");
            foreach (var stringFromArray in _arrayString)
            {
                Console.WriteLine($"{++_numberOfCalls} {stringFromArray}");
            }
        }

        private void UseDoCycle()
        {
            Console.WriteLine("\nUse \"Do Cycle\":\n");
            int i = 333 / 4;
            do
            {
                Console.WriteLine($"{++_numberOfCalls} Hello world");
                i--;
            }
            while (i != 0);
        }

        private void UseWhileCycle()
        {
            int i = 333 / 4;
            Console.WriteLine("\nUse \"Foreach Cycle\":\n");
            while (i != 0)
            {
                Console.WriteLine($"{++_numberOfCalls} Hello world");
                i--;
            }
        }

        public void GetInfoToConsole()
        {
            UseForCycle();
            UseForeachCecle();
            UseDoCycle();
            UseWhileCycle();
        }



    }
}
