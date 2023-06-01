using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTask4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string chromedriverPath = @"C:\Users\GGPC\Desktop\SeleniumAssessment\SeleniumTask4\SeleniumTask4\bin\Debug\chromedriver.exe";
            // Create a new instance of the Chrome driver
            IWebDriver driver = new ChromeDriver(chromedriverPath);

            // 5 * 5 = 25

            driver.Navigate().GoToUrl("http://www.calculator.net");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[3]/span[4]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[5]/span[4]")).Click();
            Thread.Sleep(5000);

            //Clear Screen
            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[5]/span[3]")).Click();
            Thread.Sleep(1000);

            // 50 - 50 = 0

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[4]/span[1]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[2]/span[4]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[2]/span[2]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[4]/span[1]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[5]/span[4]")).Click();
            Thread.Sleep(5000);

            //Clear Screen
            driver.FindElement(By.XPath("/html/body/div[3]/div/table/tbody/tr/td[1]/table/tbody/tr[2]/td[2]/div/div[5]/span[3]")).Click();
            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
