﻿using AventStack.ExtentReports;
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
    internal class UsernameGrid : Base
    {
        [Test]
        public void LoginandAdmin()
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

            //GRID USERNAME FILD on Admin tab
            Search_UsernameFilter usernameFilter = new Search_UsernameFilter(driver);
            usernameFilter.getUsernameFilter().SendKeys("Admin");
            test.Log(Status.Info, "Admin value provided on usernameFilteronGRID");

            //Click on Serach Button
            usernameFilter.getSearchButton().Click();
            test.Log(Status.Info, "Click on Serach button");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[@class='oxd-text oxd-text--span']")));
            bool validuser = usernameFilter.UserSearch.Displayed;
            TestContext.WriteLine("Admin"+ validuser);
            Assert.AreEqual(true,  validuser);
            // Asserting presence of data or no data based on the search
            //try
            //{
            //    IWebElement noDataMessage = driver.FindElement(By.XPath("//span[contains(text(), 'No Records Found')]"));
            //    Assert.IsNotNull(noDataMessage, "No data found for the username 'sweta'.");
            //    test.Log(Status.Info, "No records found for the username 'sweta'. Assertion passed.");
            //}
            //catch (NoSuchElementException)
            //{
            //    IList<IWebElement> rows = driver.FindElements(By.XPath("//span[@class='oxd-text oxd-text--span']"));
            //    Assert.IsTrue(rows.Count > 0, "Data found for the username 'sweta'.");
            //    test.Log(Status.Info, "Records found for the username 'sweta'. Assertion passed.");






        }

        }
    }
