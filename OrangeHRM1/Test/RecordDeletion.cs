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

public class RecordDeletion : Base
{

    [Test]
    public void DeletedU()
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
        usernameFilter.getUsernameFilter().SendKeys("ABCDEFGH");
        test.Log(Status.Info, "Admin value provided on usernameFilteronGRID");

        //Click on Serach Button
        usernameFilter.getSearchButton().Click();
        test.Log(Status.Info, "Click on Serach button");
        {

        }



        //RecordDeletion RecordDeletion = new RecordDeletion(driver);
        //string usernameToDelete = "username_to_delete";
        //RecordDeletion.RecordDeletion(usernameToDelete);
        //test.Log(Status.Info, $"Deleted user '{usernameToDelete}'");
    }
}

