using System;
using System.Collections.Generic;
using System.Text;

namespace GetBrowserEnum
{
    class FireFox : ICheck
    {
        //3)Написать Интерфейс с функцией CheckBrowser принимающую на вход параметр типа BrowserType и
        //возвращающей true или false И второй функцией возвращающей BrowserType GetBrowser. Написать три класса, 
        //каждый из которых возвращает true только если в фунцию CheckBrowser передано значение равное значению GetBrowser.
        private BrowserType _browserType;

        BrowserType ICheck.GetBrowser(BrowserType browserType)
        {
           return _browserType = browserType;
        }

        bool ICheck.CheckBrowser(BrowserType browserType)
        {
            if(BrowserType.FireFox == browserType)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
