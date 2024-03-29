﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        // Set the path to the ChromeDriver executable
        string chromedriverPath = @"C:\Users\GGPC\Desktop\SeleniumAssessment\SeleniumTask3\SeleniumTask3\bin\chromedriver.exe";
        Q3(chromedriverPath);
    }

    static void Q3(string chromedriverPath)
    {
        // Create a new instance of the ChromeDriver
        using (IWebDriver driver = new ChromeDriver(chromedriverPath))
        {
            // Navigate to the webpage
            driver.Navigate().GoToUrl("https://www.trademe.co.nz/a/");

            // Find all the anchor elements on the page
            var anchorElements = driver.FindElements(By.TagName("a"));

            // Loop through each anchor element
            foreach (var element in anchorElements)
            {
                // Get the link name or text
                string linkText = element.Text;

                // Get the href attribute value
                string href = element.GetAttribute("href");

                // Check if it is an internal link without "trademe.co.nz" in the href and contains "services"
                if (!string.IsNullOrEmpty(linkText) && !string.IsNullOrEmpty(href) && !href.Contains("property") && href.Contains("services"))
                {
                    Console.WriteLine(linkText + "\n" + href + "\n");
                }
            }
            // Quit the driver after processing all anchor elements
            driver.Quit();
        }
    }
}
