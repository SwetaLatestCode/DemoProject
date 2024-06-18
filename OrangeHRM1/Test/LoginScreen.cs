using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
//using AventStack.ExtentReports;
//using OrangeHRM1.PageObject;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM1
{

    public class LoginScreen : Base
    {
        [Test]
        public void Login()

        {

            test = extent.CreateTest("Verify login");
            test.Log(Status.Info, "Started test login");
            LoginPage lp = new LoginPage(driver);
            //lp.getUsername().SendKeys("Admin");
            lp.CorrectLogin("Admin", "admin123");
            test.Log(Status.Info, "Dashboard is displayed ");
            test.Log(Status.Pass, "User successfully logged into app");
        }
    }
}
