using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GeckoDriver added to PATH var
            using(IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://wwww.google.com");
            }

            // MicrosoftDriver located in libraryPath
            string libraryPath = "C:\\Libraries\\";
            using (IWebDriver driverEdge = new EdgeDriver(@libraryPath))
            {
                driverEdge.Navigate().GoToUrl("http://youtube.com");
            }
        }
    }
}
