using AventStack.ExtentReports;
using OrangeHRM1.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM1.Test
{
    internal class PwdReset:Base
    {
        [Test]
        public void PassReset()
        {
            test = extent.CreateTest("Verify login");
            test.Log(Status.Info, "Started test login");
            LoginPage lp = new LoginPage(driver);
            //lp.getUsername().SendKeys("Admin");
            lp.CorrectLogin("Admin", "admin123");
            Reset r = new Reset(driver);
            r.Reset1("FMLName1", "Samsung12345", "Samsung12345");

          Assert.Pass("pwd reset Successfully ");


        }
    }
}
    
