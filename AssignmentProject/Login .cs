using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using System.Text;

using WebDriverManager.DriverConfigs.Impl;

namespace AssignmentProject
{
    internal class Login : LoginBase
    {
        IWebDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
             driver = new ChromeDriver();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        
        
        
        }
        [Test]

        public void LocatorsIdentification
    }




}
    
