using System;

namespace GetBrowserEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)Написать перечисление BrowserType содержащее значения InternetExplorer, Chrome и Firefox
            //2)Написать функцию PrintBrowser принимающую на вход параметр типа BrowserType и в зависимости 
            //от результата выводящий какое значение было передано
            //3)Написать Интерфейс с функцией CheckBrowser принимающую на вход параметр типа BrowserType и 
            //возвращающей true или false И второй функцией возвращающей BrowserType GetBrowser. Написать три класса, 
            //каждый из которых возвращает true только если в фунцию CheckBrowser передано значение равное значению GetBrowser.
            //4)Вместо интерфейса для задачи 3 использовать абстрактный класс.   


            Console.WriteLine();

        }

        public static void PrintBrowser(BrowserType browserEnum)
        {
            Console.WriteLine(browserEnum);
        }




    }
}
