using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using AventStack.ExtentReports;
using OpenQA.Selenium.Internal;
using OrangeHRM1;


using System.IO;
using OrangeHRM.Page_Objects;


namespace OrangeHRM1.Tests
{
    internal class AddScreen : Base
    {

        [Test]
        public void Addscreen()
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

            //loginpage.getUsername().SendKeys("Admin");
            //test.Log(Status.Info, "userName");
            //loginpage.getPassWord().SendKeys("admin123");
            //test.Log(Status.Info, "Password");
            //loginpage.getSubmit().Click();

            test.Log(Status.Info, "Usermanagement tab");
            Add adminpage = new Add(driver);
            adminpage.getAdminTab().Click();
            test.Log(Status.Info, "Admin button clicked");


            adminpage.getAddUser().Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            test.Log(Status.Info, "Add user button clicked");

            //ENter the UserRole dropdown

            adminpage.SelectUserRole("Admin");
            test.Log(Status.Info, "from dropdown admin selected");

            //ENter the  Employeenamefield  dropdown

            adminpage.Employeenamefield("Rahul  Das");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            adminpage.SelectFirstSuggestion();
            test.Log(Status.Info, " Rahul is input from search dropdown RahulDas selected");

            //ENter the Status dropdown

            adminpage.Statusdropdown("Enabled");
            test.Log(Status.Info, "from dropdown Enabled  selected");

            //ENter the Username 

            adminpage.getusernameTAB().SendKeys("Sweta94");
            test.Log(Status.Info, "Enter value in USername Tab");

            //ENter the Password 

            adminpage.getpasswordTAB().SendKeys("Sweta123");
            test.Log(Status.Info, "Enter value in Password Tab");

            //Enter the Confirm password
            
            adminpage.getconfirmpasswordTAB().SendKeys("Sweta123");
            test.Log(Status.Info, "Enter value in Confirm Password Tab");

            //click on the save button

            adminpage.getSavebutton().Click();
            test.Log(Status.Info, "Save button click");

            Assert.Pass("Successfully saved");












        }
    }


}




//







