using System;
using System.Collections.Generic;
using System.Text;

namespace GetBrowserEnum
{
    public interface ICheck
    {
        //3)Написать Интерфейс с функцией CheckBrowser принимающую на вход параметр типа BrowserType и
        //возвращающей true или false И второй функцией возвращающей BrowserType GetBrowser. Написать три класса, 
        //каждый из которых возвращает true только если в фунцию CheckBrowser передано значение равное значению GetBrowser.

        bool CheckBrowser(BrowserType browserType);
        BrowserType GetBrowser();
    }
}
