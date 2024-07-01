using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V123.Debugger;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;

namespace OrangeHRM.Page_Objects
{
    internal class Add
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Add (IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='/web/index.php/admin/viewAdminModule']")]
        private IWebElement AdminTab;

        [FindsBy(How = How.XPath, Using = "//div[@class='orangehrm-header-container']/button")]
     
        private IWebElement AddUser;

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-select-text-input']")]
        private IWebElement DropdownUserRole;

      
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Type for hints...']")]
        private IWebElement Employeename;

        [FindsBy(How = How.XPath, Using = "//div[@role='option']")]
        private IList<IWebElement> suggestions;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[1]")]
       
        private IWebElement Status;

        [FindsBy(How = How.XPath, Using = "//div[@class='oxd-form-row']/div/div[4]/div/div[2]/child::input")]

        private IWebElement usernameTAB;

        [FindsBy(How = How.XPath, Using = "//input[@type='password'][1]")]
        private IWebElement passwordTAB;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input")]
        private IWebElement confirmpasswordTAB;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement Savebutton;

        [FindsBy(How = How.XPath, Using = "//div[text()='Sweta94']")]
        public IWebElement validateUser;


        public IWebElement getAdminTab()
        {
            return AdminTab;
        }

        public IWebElement getAddUser()
        {
            return AddUser;
        }

        public IWebElement getDropdownUserRole()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(DropdownUserRole));
            return DropdownUserRole;
        }


        public IWebElement getStatus()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(Status));
            return Status;
        }
        public IWebElement getusernameTAB()
        {
            return usernameTAB;
        }
        public IWebElement getpasswordTAB()
        {
            return passwordTAB;
        }

        public IWebElement getconfirmpasswordTAB()
        {
            return confirmpasswordTAB;
        }
        public IWebElement getSavebutton()
        {
            return Savebutton;
        }


        public void SelectUserRole(string role)
        {
            DropdownUserRole.Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@role='listbox']")));
            IList<IWebElement> items = driver.FindElements(By.XPath("//div[@role='listbox']"));
            foreach (IWebElement item in items)
            {
                if (item.Text.Contains(role))
                {
                    item.Click();
                    DropdownUserRole.SendKeys(Keys.Escape);
                    break; 

                }

            }
        }
        public void Employeenamefield(string name)
        {

            Employeename.SendKeys(name);
        }

        public void SelectFirstSuggestion()
        {
            suggestions.First().Click();
        }

        public void Statusdropdown(string option)
        {
            Status.Click();

            IList<IWebElement> lists = driver.FindElements(By.XPath("//div[@role='listbox']"));
            foreach (IWebElement list in lists)
            {
                if (list.Text.Contains(option))
                {
                    list.Click();
                    Status.SendKeys(Keys.Escape);
                    break;
                }
            }


        }
    }
}
