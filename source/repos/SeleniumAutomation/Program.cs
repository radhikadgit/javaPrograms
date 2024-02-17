
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //create a reference for chrome browser
            IwebDriver driver = new ChromeDriver();
            var navigate = driver.Navigate();



            // Go to google page
            driver.Navigate().GoToUrl("https://www.google.com");

  

                
        }
    }
}
