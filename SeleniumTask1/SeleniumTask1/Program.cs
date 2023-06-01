using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Set the path to the ChromeDriver executable
        string chromedriverPath = @"C:\Users\GGPC\Desktop\SeleniumAssessment\SeleniumTask1\SeleniumTask1\bin\Debug\chromedriver.exe";
        // Create a new instance of the Chrome driver
        IWebDriver driver = new ChromeDriver(chromedriverPath);
        // Open Google website
        driver.Navigate().GoToUrl("https://www.google.co.nz");
        // Find the search input element
        IWebElement searchInput = driver.FindElement(By.Name("q"));
        // Enter the search term
        searchInput.SendKeys("Taupo Weather");
        Thread.Sleep(3000);
        // Submit the search form
        searchInput.Submit();
        Thread.Sleep(5000); 
        // Wait for the search results to load (e.g., you can use a WebDriverWait here)
        // Perform further actions on the search results page...
        // Close the browser and quit the driver
        driver.Quit(); // Exit process
    }
}
