using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;


namespace LinkGroupDemo.PageObjectModel
{
    public class LingGroup
    {

        public By BtnAccept = By.Id("btnAccept");

        public By searchIcon = By.XPath("//*[@id='TN-search']");

        public By searchTerm = By.XPath("//*[@id='TN-search']/div/form/input");

        public By searchBtn = By.XPath("//*[@id='TN-search']/div/form/button");





    }
}
