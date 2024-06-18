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
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'cell-actions')]/button[@type='button'][1]")]
        private IWebElement deleteUser;
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'footer')]/button/i[contains(@class,'trash')]")]
        private IWebElement confirmdeleteUser;
        public IWebElement getAdminTab()
        {
            return admintab;
        }
        public void getuserSearchr(string abc)
        {
            userSearch.SendKeys(abc); ;
        }
        public IWebElement getsearchButton()
        {
            return searchButton;
        }
       
        
        public IWebElement getUserDeleted()
        {
            return checkbox;
        }
        public IWebElement getdeleteUser()
        {
            return deleteUser;
        }
        public IWebElement getconfirmdeleteUser()
        {
            return confirmdeleteUser;
        }






    }
}