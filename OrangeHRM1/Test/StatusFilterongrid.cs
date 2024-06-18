using AventStack.ExtentReports;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrangeHRM.Page_Objects;
using OrangeHRM1;
using System.IO;

namespace OrangeHRM1.Tests
{
    internal class StatusFilterongrid : Base
    {
        [Test]
        public void GridStatus()
        {
            test = extent.CreateTest("Add AdminLogin ");
            test.Log(Status.Info, "Started test login");
            LoginPage loginpage = new LoginPage(driver);
            //Testreader Data = new Testreader();
            //string username = Data.getUserName();
            //string password = Data.getPassword();
            loginpage.CorrectLogin("Admin", "admin123");

            //Loginpage loginpage = new Loginpage(driver);
            //loginpage.validlogin("Admin", "admin123");

            test.Log(Status.Info, "Usermanagement tab");
            Add adminpage = new Add(driver);
            adminpage.getAdminTab().Click();
            test.Log(Status.Info, "Admin button clicked");

            StatusFilter sf = new StatusFilter(driver);
            sf.StatusFiltersdropdown("Enabled");
            test.Log(Status.Info, "from dropdown Enabled  selected");

            sf.getSearchButton().Click();
            test.Log(Status.Info, "Click on Serach button");


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='oxd-text oxd-text--span']")));

            // Asserting presence of data or no data based on the search value
            try
            {
                IWebElement noDataMessage = driver.FindElement(By.XPath("//span[contains(text(), 'No Records Found')]"));
                Assert.IsNotNull(noDataMessage, "No data found for the Status 'Enabled'.");
                test.Log(Status.Info, "No records found for the username 'Enabled'. Assertion passed.");
            }
            catch (NoSuchElementException)
            {
                IList<IWebElement> rows = driver.FindElements(By.XPath("//span[@class='oxd-text oxd-text--span']"));
                Assert.IsTrue(rows.Count > 0, "Data found for the username 'Enabled'.");
                test.Log(Status.Info, "Records found for the username 'Enabled'. Assertion passed.");






            }

        }
    }
}