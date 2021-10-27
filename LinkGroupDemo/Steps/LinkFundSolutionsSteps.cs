using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LinkGroupDemo.Features
{
    [Binding]
    public class LinkFundSolutionsSteps
    {

        private IWebDriver driver;
        [Given(@"I have opened the Found Solutions page")]
        public void GivenIHaveOpenedTheFoundSolutionsPage()
        {
            //create the reference for the browser 
            driver = new ChromeDriver();
            // navigate to URL
            driver.Navigate().GoToUrl("https://www.linkfundsolutions.co.uk/");
            driver.Manage().Window.Maximize();
        }
        
        [When(@"I view Funds")]
        public void WhenIViewFunds()
        {
            driver.FindElement(By.XPath("//li[@id='navItem-funds']")).Click();
            
            Console.WriteLine("Funds dropdown menu is clicked");
        }

        [Then(@"I can select the investment managers for (.*) investors")]
        public void ThenICanSelectTheInvestmentManagersForInvestors(string invest)

        {

            System.Threading.Thread.Sleep(1000);
            {
                IWebElement element = driver.FindElement(By.XPath("//*[contains(text(),'"+invest+"')]"));
                if(element.Displayed)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.IsTrue(false);
                }
                //Closing  broswer
                driver.Close();

            }
            Console.WriteLine("test case ended ");
        }

    }
}
