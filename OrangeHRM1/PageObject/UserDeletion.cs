using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.Debugger;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
namespace OrangeHRM.Page_Objects;
internal class UserDeletion
{


    public class UserDeletionb
    {
        private IWebDriver driver;
        public UserDeletionb(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-checkbox-input oxd-checkbox-input--active --label-right oxd-checkbox-input'])[2]")]
        private IWebElement checkbox;
        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-row']/div/div[1]/div/div[2]/child::input")]
        private IWebElement UsernameFilter;
        [FindsBy(How = How.XPath, Using = "(//button[@type='button'])[7]")]
        private IWebElement deleteUser;
        [FindsBy(How = How.XPath, Using = "(//button[@type='button'])[10]")]
        private IWebElement confirmdeleteUser;
        public IWebElement getAdminTab()
        {
            return admintab;
        }
        public IWebElement getuserSearchr()
        {
            return userSearch;
        }
        public IWebElement getsearchButton()
        {
            return searchButton;
        }
        public IWebElement getUsernameFilter()
        {
            return UsernameFilter;
        }
        public IWebElement getUserDeleted()
        {
            return checkbox;
        }
        public IWebElement getdeleteUser()
        {
            return checkbox;
        }
        public IWebElement getconfirmdeleteUserr()
        {
            return checkbox;
        }






    }
}