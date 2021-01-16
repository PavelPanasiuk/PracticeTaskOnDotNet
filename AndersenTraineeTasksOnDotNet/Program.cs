using System;

namespace CycleTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1)Написать HelloWorld согласно
            //  https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/inside-a-program/hello-world-your-first-program
            //  -Обратить внимание на использование namespace в программе
            //  -Обратить внимание на класс
            //2)Заменить строки используемые для вывода на переменные.
            //3)Написать отдельную функцию выводящую 'Hello World' 333 раза с использованием 
            //  всех операторов перебора возможных в C#
            string forInput = "Hello world";
            Console.WriteLine("Hello world");
            Console.WriteLine(forInput);
            GetHelloWorldToConsole();
        }

        public static void GetHelloWorldToConsole()
        {
            int allCountOfCallsByCycles = 0;
            int countOfCalls = 333 / 4;
            string[] _arrayString = new string[countOfCalls];

            Console.WriteLine("\nUse \"For Cycle\":\n");
            for (int i = 0; i < countOfCalls; i++)
            {
                _arrayString[i] = "Hello world";
                Console.WriteLine($"{++allCountOfCallsByCycles} {_arrayString[i]}");
            }

            Console.WriteLine("\nUse \"Foreach Cycle\":\n");
            foreach (var stringFromArray in _arrayString)
            {
                Console.WriteLine($"{++allCountOfCallsByCycles} {stringFromArray}");
            }

            Console.WriteLine("\nUse \"Do Cycle\":\n");
            int countOfCallsDoCycle = countOfCalls;
            do
            {
                Console.WriteLine($"{++allCountOfCallsByCycles} Hello world");
                countOfCallsDoCycle--;
            }
            while (countOfCallsDoCycle != 0);

            Console.WriteLine("\nUse \"While Cycle\":\n");
            int countOfCallsWhileCycle = countOfCalls;
            while (countOfCallsWhileCycle != 0)
            {
                Console.WriteLine($"{++allCountOfCallsByCycles} Hello world");
                countOfCallsWhileCycle--;
            }
        }
    }
}
