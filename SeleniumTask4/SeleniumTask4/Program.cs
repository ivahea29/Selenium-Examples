using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Set the path to the ChromeDriver executable
        string chromedriverPath = @"C:\Users\GGPC\Desktop\SeleniumAssessment\SeleniumTask2\SeleniumTask2\bin\Debug\chromedriver.exe";

        // Create a new instance of the Chrome driver
        IWebDriver driver = new ChromeDriver(chromedriverPath);

        // Open Google website
        driver.Navigate().GoToUrl("https://www.trademe.co.nz/a/property/residential/sale");
        Thread.Sleep(1000);

        // Find the submit button element and click it
        IWebElement button = driver.FindElement(By.CssSelector(".tm-property-home-search-banner__submit-button--compact"));
        // Perform any actions on the button (click, text input, etc.)
        button.Click();
        Thread.Sleep(5000); // Hold position for 5000 milliseconds

        // Close the browser and quit the driver
        driver.Quit(); // Exit process
    }
}
