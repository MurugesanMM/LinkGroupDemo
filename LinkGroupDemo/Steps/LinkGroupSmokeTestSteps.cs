using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Features
{

    [Binding]
    public class LinkGroupDemo
    {

        private IWebDriver driver;
        [When(@"I open the home page")]
        public void WhenIOpenTheHomePage()
        {
            Console.WriteLine("test case started ");
            //create the reference for the browser 
            driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.linkgroup.eu");
            driver.Manage().Window.Maximize();
        }

        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            String actualTitle = driver.Title;
            Assert.IsTrue (actualTitle.Equals("Home"),"Page title is not matched");
            Console.WriteLine("The page title is validated as " + actualTitle);
            driver.Close();
            Console.WriteLine("test case ended ");

        }
    }
}
