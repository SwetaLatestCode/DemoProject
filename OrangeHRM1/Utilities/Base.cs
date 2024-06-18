using NUnit;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.IO;
//using AventStack.ExtentReports.Core;
//using OrangeHRM1;
//using ICSharpCode.SharpZipLib.Zip;

namespace OrangeHRM1
{
    public class Base
    {

        public ExtentReports extent;

        public IWebDriver driver;
        public ExtentTest test;
        //private static ExtentReports extent;


        //private static ExtentTest test;


        //Report File
        [OneTimeSetUp]
        public void Setup()

        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;//prent added 
            string reportpath = projectDirectory + "//index.html";
            var htmlReporter = new ExtentHtmlReporter(reportpath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "localHost");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Use Name", "Sweta Kumari");





        }

        //private object ExtentReporters()
        //{
        //    throw new NotImplementedException();
        //}

        //public IWebDriver driver;
        //private string workingDirectory;
        //private object extentReporters;

       // public object MediaEntityBuilder { get; }
        //public object ExtentReporters { get; private set; }

        [SetUp]

        public void StartBrowser()
        {
           // test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
            String browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        }
        ////public IWebDriver getDriver()
        //{
        //    return driver;
        //}


        public void InitBrowser(String browserName)
        {
            switch (browserName)
            {
                case "Chrome":

                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Firefox":

                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;
            }


        }
        [TearDown]
        public void TearDownBrowser()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            //var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);
            var StackTrace = TestContext.CurrentContext.Result.StackTrace;
            //var errorMessage = TestContext.CurrentContext.Result.Message;
            DateTime time = DateTime.Now;
            string fileName = "Screenshot_" + time.ToString("hh_mm_ss") + "png";
            if (status == TestStatus.Failed)
            {
                test.Fail("Test failed", CaptureScreenshot(driver, fileName));
                test.Log(Status.Fail, "test failed with logtrace" + StackTrace);
            }
            else if(status == TestStatus.Passed)
            {

            }
            extent.Flush();
            driver.Quit();
        }

        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver,string screenshotName)
        {           
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;
            // return MediaEntityBuilder.createScreenCaptureFromBase64String(screenshot, screenshotName).BuildMediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenshotName).Build();
          
          return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot,screenshotName).Build();
        }

    }
}