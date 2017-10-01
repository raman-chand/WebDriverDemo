using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using(IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://wwww.google.com");
            }
        }
    }
}
