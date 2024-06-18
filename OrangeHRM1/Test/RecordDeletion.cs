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
using static OrangeHRM.Page_Objects.UserDeletion;

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
        UserDeletionb ud = new UserDeletionb(driver);
        ud.getAdminTab().Click();
        ud.getuserSearchr("Amira.Stoltenberg");
        ud.getsearchButton().Click();
        ud.getUserDeleted().Click();
        ud.getdeleteUser().Click();
        ud.getconfirmdeleteUser().Click();


    }
}

        