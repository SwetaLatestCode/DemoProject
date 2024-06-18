
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OrangeHRM1
{
    public class LoginPage 
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='username']")]
         
     private IWebElement username;
        [FindsBy(How = How.CssSelector, Using = "input[name='password']")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--main orangehrm-login-button']")]
        private IWebElement loginbutton;
        public void CorrectLogin(string user,string p)
        {
            username.SendKeys(user);
            password.SendKeys(p);
            loginbutton.Click();
        }


        public IWebElement getUsername() 
        {
            return username;
        }
    }
}



