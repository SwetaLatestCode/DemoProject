//using AventStack.ExtentReports;
//using OrangeHRM.Page_Objects;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OrangeHRM1.Test
//{

//    internal class EditUser : Base
//    {
//        [Test]
//        public void Addscreen()
//        {


//            test = extent.CreateTest("Add AdminLogin ");
//            test.Log(Status.Info, "Started test login");
//            LoginPage loginpage = new LoginPage(driver);
//            //Testreader Data = new Testreader();
//            //string username = Data.getUserName();
//            //string password = Data.getPassword();usernameFilter
//            loginpage.CorrectLogin("Admin", "admin123");


//            //Loginpage loginpage = new Loginpage(driver);
//            //loginpage.validlogin("Admin", "admin123");

//            //loginpage.getUsername().SendKeys("Admin");
//            //test.Log(Status.Info, "userName");
//            //loginpage.getPassWord().SendKeys("admin123");
//            //test.Log(Status.Info, "Password");
//            //loginpage.getSubmit().Click();

//            test.Log(Status.Info, "Usermanagement tab");
//            Add adminpage = new Add(driver);
//            adminpage.getAdminTab().Click();
//            test.Log(Status.Info, "Admin button clicked");
//            //ENter Usernamefield  dropdown

//            adminpage.Usernamefield("Rahul Das");
//            Thread.Sleep(TimeSpan.FromSeconds(2));
//            adminpage.SelectFirstSuggestion();
//            test.Log(Status.Info, " Rahul is input from search dropdown RahulDas selected");

//            //ENter Status dropdown

//            adminpage.Statusdropdown("Enabled");
//            test.Log(Status.Info, "from dropdown Enabled  selected");






//        }
//    }
//}