//using AventStack.ExtentReports;
//using OpenQA.Selenium;
//using OpenQA.Selenium.DevTools.V123.Debugger;
//using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.PageObjects;
//using SeleniumExtras.WaitHelpers;
//using System;
//using System.Collections.Generic;
//namespace OrangeHRM.Page_Objects
//{
//    internal class EditRecord
//    {
//        private IWebDriver driver;
//        private WebDriverWait wait;

//        public EditRecord(IWebDriver driver)
//        {
//            this.driver = driver;
//            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
//            PageFactory.InitElements(driver, this);
//        }

//        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
//        private IWebElement admintab;
//        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
//        private IWebElement userSearch;
//        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
//        private IWebElement searchButton;
//        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-icon-button oxd-table-cell-action-space'])[2]")]
//        private IWebElement edituser;
//        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text oxd-select-text--active'])[2]")]
//        private IWebElement changestatus;

//        public void userNameSearch(string us)
//        {
//            admintab.Click();
//            userSearch.SendKeys(us);
//            searchButton.Click();
//        }
//        public IWebElement getEdituser()
//        {
//            return edituser;
//        }
//        public IWebElement getStatus()
//        {
//            wait.Until(ExpectedConditions.ElementToBeClickable(changestatus));
//            return changestatus;

//        }
//        public void Statusdropdown(string option)
//        {
//            changestatus.Click();

//            IList<IWebElement> lists = driver.FindElements(By.XPath("//div[@role='listbox']"));
//            foreach (IWebElement list in lists)
//            {
//                if (list.Text.Contains(option))
//                {
//                    list.Click();
//                    //changestatus.SendKeys(Keys.Escape);
//                    break;
//                }
//            }


//        }
//    }
//}