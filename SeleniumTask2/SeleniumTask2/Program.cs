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
        driver.Navigate().GoToUrl("https://www.trademe.co.nz/a/");

        // Find the search input element
        IWebElement searchInput = driver.FindElement(By.Id("search"));

        Thread.Sleep(1000);

        // Enter the search term
        searchInput.SendKeys("IT jobs");

        // Find the submit button element and click it
        IWebElement submitButton = driver.FindElement(By.CssSelector(".tm-global-search__search-form-submit-button"));
        submitButton.Click();


        Thread.Sleep(5000); // Hold position for 5000 milliseconds

        // Wait for the search results to load (e.g., you can use a WebDriverWait here)
        // Perform further actions on the search results page...

        // Close the browser and quit the driver
        driver.Quit(); // Exit process
    }
}
