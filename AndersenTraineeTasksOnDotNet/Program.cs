using System;

namespace CycleTask
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1)Написать HelloWorld согласно
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/inside-a-program/hello-world-your-first-program
            // -Обратить внимание на использование namespace в программе
            //  -Обратить внимание на класс
            //  2)Заменить строки используемые для вывода на переменные.
            //3)Написать отдельную функцию выводящую 'Hello World' 333 раза с использованием 
            //всех операторов перебора возможных в C#
            string forInput = "Hello world";
            Console.WriteLine("Hello world");
            Console.WriteLine(forInput);
            Cycles cycles = new Cycles();
            cycles.GetInfoToConsole();
        }
    }
}
