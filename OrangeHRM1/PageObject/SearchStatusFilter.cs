using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.Debugger;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
namespace OrangeHRM.Page_Objects
{
    internal class StatusFilter
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public StatusFilter(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//label[text()='Status']/parent::div/following-sibling::div/div[@class='oxd-select-wrapper']/div/div[1]")]
        //"//div[@class='oxd-grid-item oxd-grid-item--gutters']/div/div[1]")]
        private IWebElement StatusFilters;

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-actions']/button[2]")]
        private IWebElement SearchButton;

        public IWebElement getStatusFilters()
        {
            return StatusFilters;
        }


        public IWebElement getSearchButton()
        {
            return SearchButton;
        }

        public void StatusFiltersdropdown(string option)
        {
            StatusFilters.Click();

            IList<IWebElement> lists = driver.FindElements(By.XPath("//div[@role='listbox']"));
            foreach (IWebElement list in lists)
            {
                if (list.Text.Contains(option))
                {
                    list.Click();
                    StatusFilters.SendKeys(Keys.Escape);
                    break;
                }
            }
        }
    }
}