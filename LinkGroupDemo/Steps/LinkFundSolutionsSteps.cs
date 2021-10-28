﻿using System;
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

        IWebElement fundsDropdown => driver.FindElement(By.XPath("//li[@id='navItem-funds']"));

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
            fundsDropdown.Click();
            Console.WriteLine("Funds dropdown menu is clicked");
        }

        [Then(@"I can select the investment managers for (.*) investors")]
        public void ThenICanSelectTheInvestmentManagersForInvestors(string invest)

        {
            System.Threading.Thread.Sleep(1000);
            {

               IWebElement element = driver.FindElement(By.XPath("//*[contains(text(),'" + invest + "')]"));
              Assert.IsTrue(element.Text.Contains(invest));
                element.Click();
              /*if (element.Displayed)
                {
                    Assert.That(true, element.Text, invest);
                }
                else
                {
                    Assert.That(false, element.Text, invest);
                }*/
            }

            //Closing  broswer
            driver.Quit();
            Console.WriteLine("test case ended ");

        }


    }
}
