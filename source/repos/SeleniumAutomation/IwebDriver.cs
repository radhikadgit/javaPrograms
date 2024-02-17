using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumAutomation
{
    internal class IwebDriver
    {
        public static implicit operator IwebDriver(ChromeDriver v)
        {
            throw new NotImplementedException();
        }

        internal object Navigate()
        {
            throw new NotImplementedException();
        }
    }
}