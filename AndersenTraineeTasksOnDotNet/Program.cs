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
            int _numberOfCalls = 0;
            string[] _arrayString = new string[333 / 4];

            Console.WriteLine("\nUse \"For Cycle\":\n");
            for (int i = 0; i < 333 / 4; i++)
            {
                _arrayString[i] = "Hello world";
                Console.WriteLine($"{++_numberOfCalls} {_arrayString[i]}");
            }

            Console.WriteLine("\nUse \"Foreach Cycle\":\n");
            foreach (var stringFromArray in _arrayString)
            {
                Console.WriteLine($"{++_numberOfCalls} {stringFromArray}");
            }

            Console.WriteLine("\nUse \"Do Cycle\":\n");
            int numberOfCalls = 333 / 4;
            do
            {
                Console.WriteLine($"{++_numberOfCalls} Hello world");
                numberOfCalls--;
            }
            while (numberOfCalls != 0);


            Console.WriteLine("\nUse \"Foreach Cycle\":\n");
            numberOfCalls = 333 / 4;
            while (numberOfCalls != 0)
            {
                Console.WriteLine($"{++_numberOfCalls} Hello world");
                numberOfCalls--;
            }
        }
    }
}
