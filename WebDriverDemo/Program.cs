using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GeckoDriver added to PATH var
            using(IWebDriver driver = new FirefoxDriver())
            {
                driver.Navigate().GoToUrl("http://www.google.com");

                // find an element tied to google's search box
                IWebElement searchBox = driver.FindElement(By.Name("q"));
                // send a key string to the search box.
                searchBox.SendKeys("pluralsight");

                searchBox.Submit();
                
                // click the Images link to view pluralsight images
                IWebElement elem = driver.FindElements(By.ClassName("hdtb-mitem"))[4];
                IWebElement imagesLink = elem.FindElement(By.TagName("a"));
                imagesLink.Click();
            }

            // MicrosoftDriver located in libraryPath
            string libraryPath = "C:\\Libraries\\";
            using (IWebDriver driverEdge = new EdgeDriver(@libraryPath))
            {
                driverEdge.Navigate().GoToUrl("http://youtube.com");
            }

            // ChromeDriver located in libraryPath
            using (IWebDriver driverChrome = new ChromeDriver(@libraryPath))
            {
                driverChrome.Navigate().GoToUrl("http://www.cnn.com");
            }
        }
    }
}
