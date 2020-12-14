using System;
using System.Collections.Generic;
using System.Text;

namespace GetBrowserEnum
{
    public class FireFox : ICheck
    {
        //3)Написать Интерфейс с функцией CheckBrowser принимающую на вход параметр типа BrowserType и
        //возвращающей true или false И второй функцией возвращающей BrowserType GetBrowser. Написать три класса, 
        //каждый из которых возвращает true только если в фунцию CheckBrowser передано значение равное значению GetBrowser.
        private BrowserType _browserType = BrowserType.FireFox;

        BrowserType ICheck.GetBrowser()
        {
            return _browserType;
        }

        bool ICheck.CheckBrowser(BrowserType browserType)
        {
            return _browserType == browserType;
        }
    }
}
