using System;
using System.Collections.Generic;
using System.Text;

namespace AndersenTraineeTasksOnDotNet
{
    class Cycles
    {
        private int _numberOfCalls = 0;
        private string[] _arrayString = new string[111];

        public void UseForCycle()
        {
            Console.WriteLine("\nUse \"For Cycle\":\n");
            for (int i = 0; i < 111; i++)
            {
                _arrayString[i] = "Hello world";
                Console.WriteLine($"{++_numberOfCalls} {_arrayString[i]}");
            }
        }

        public void UseForeachCecle()
        {
            Console.WriteLine("\nUse \"Foreach Cycle\":\n");
            foreach (var stringFromArray in _arrayString)
            {
                Console.WriteLine($"{++_numberOfCalls} {stringFromArray}");
            }
        }

        public void UseDoWhileCycle()
        {
            Console.WriteLine("\nUse \"Do Cycle\":\n");
            int i = 0;
            do
            {                
                Console.WriteLine($"{++_numberOfCalls} Hello world");
                i++;
            }
            while (i < 111);
        }



    }
}
