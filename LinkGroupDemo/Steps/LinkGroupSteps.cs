using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LinkGroup.Features
{

    [Binding]
    public class LinkGroupDemo
    {

        private IWebDriver driver;
        IWebElement btnAccept => driver.FindElement(By.Id("btnAccept"));
        IWebElement searchIcon => driver.FindElement(By.XPath("//*[@id='TN-search']"));
        IWebElement searchTerm => driver.FindElement(By.XPath("//*[@id='TN-search']/div/form/input"));
        IWebElement searchBtn => driver.FindElement(By.XPath("//*[@id='TN-search']/div/form/button"));
        IWebElement searchResult => driver.FindElement(By.XPath("//*[@id='SearchResults']/h3/em"));
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
            Assert.IsTrue(actualTitle.Equals("Home"), "Page title is not matched");
            Console.WriteLine("The page title is validated as " + actualTitle);
            driver.Close();

        }
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
            btnAccept.Click();
        }

        [When(@"I search for '(.*)'")]
        public void WhenISearchFor(string Name)
        {
            //Clink on search field
            searchIcon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            //Clicking search term field and clicking search term field
            searchTerm.Click();
            //passing the Leeds value
            searchTerm.SendKeys(Name);
            //clicking Searchterm field
            searchBtn.Click();
        }

        [Then(@"the search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            System.Threading.Thread.Sleep(1000);
            // Verifying the search results
            Console.WriteLine("You searched for : " + searchResult.Text + " is displayed in the Search Result page");
            //Closing  broswer
            driver.Quit();
            Console.WriteLine("test case ended ");
        }
    }
}
