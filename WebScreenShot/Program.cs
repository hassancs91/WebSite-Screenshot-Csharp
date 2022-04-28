using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebScreenShot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CaptureWebPage("https://learnwithhasan.com");

        }


        public static void CaptureWebPage(string url)
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");
            options.AddArgument("user-agent=Mozilla/5.0 " +
                "(Windows NT 10.0; Win64; x64) AppleWebKit/537.36" +
                " (KHTML, like Gecko) Chrome/74.0.3729.169 " +
                "Safari/537.36");

            IWebDriver driver = new ChromeDriver("E:\\TechVideos\\Python",options);

            driver.Navigate().GoToUrl(url);

            ITakesScreenshot screenshotDriver = 
                driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile("Test.png");




        }
    }
}
