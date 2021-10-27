using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LinkGroupDemo.Features
{
    [Binding]
    public class LinkGroupHomePageSteps
    {
        private IWebDriver driver;
                
        [Given(@"i have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            //create the reference for the browser 
            driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.linkgroup.eu");
            driver.Manage().Window.Maximize();
            // CLick on Accept button
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Id("btnAccept")).Click();
        }
        
        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string Name)
        {
            //Clink on search field
            driver.FindElement(By.XPath("//*[@id='TN-search']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            //Clicking search term field and clicking search term field
            IWebElement searchTerm = driver.FindElement(By.XPath("//*[@id='TN-search']/div/form/input"));
            searchTerm.Click();
            //passing the Leeds value
            searchTerm.SendKeys(Name);
            //clicking Searchterm field
            IWebElement searchBtn = driver.FindElement(By.XPath("//*[@id='TN-search']/div/form/button"));
            searchBtn.Click();
        }
        
        [Then(@"the search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            System.Threading.Thread.Sleep(1000);
            // Verifying the search results
            IWebElement searchResult = driver.FindElement(By.XPath("//*[@id='SearchResults']/h3/em"));
            Console.WriteLine("You searched for : " + searchResult.Text + " is displayed in the Search Result page");
            //Closing  broswer
            driver.Close();
            Console.WriteLine("test case ended ");
        }
    }
}
