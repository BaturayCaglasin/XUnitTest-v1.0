using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;


namespace NUnitTest_Logiwa_v1._0
{
    public class Base : IDisposable
    {


        public IWebDriver driver = new ChromeDriver();
        public static By emailfield = By.Name("email");
        public static By passwordfield = By.Name("password");
        public static By logInButton = By.XPath("//button[contains(.,'Sign In')]");
        public static By signUpButton = By.XPath("//a[contains(text(),'Sign Up')]");
        public static By closeOnBoardingButtons = By.CssSelector(".close path");
        public static By firstNameField = By.Id("firstName");
        public static By lastNameField = By.Id("lastName");
        public static By emailField = By.Id("email");
        public static By passwordField = By.Id("password");
        public static By agreeTermsField = By.CssSelector(".k-checkbox-label");
        public static By submitButtonforSignUp = By.XPath("//button[@type='submit']");
        public String email = "mobilereceipttest@logiwa.com";
        public String password = "Test*01";
        public String MyLogiwaDEVURL = "https://mydev.logiwa.com/en/public/signin/?isTestAutomationLive=true";


        [Fact]
        public void SetupBeforeEachTest()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Guid demoGuid = Guid.NewGuid();

            driver.Navigate().GoToUrl(MyLogiwaDEVURL);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
            //for login: 

            /*wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((emailfield)));
            driver.FindElement(emailfield).SendKeys(email);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((passwordfield)));
            driver.FindElement(passwordfield).SendKeys(password);
            driver.FindElement(logInButton).Click();*/

            //for signup: 
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((signUpButton)));
            driver.FindElement(signUpButton).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((closeOnBoardingButtons)));
            driver.FindElement(closeOnBoardingButtons).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((firstNameField)));
            driver.FindElement(firstNameField).SendKeys("first" + demoGuid);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((lastNameField)));
            driver.FindElement(lastNameField).SendKeys("last" + demoGuid);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((emailField)));
            driver.FindElement(emailField).SendKeys(demoGuid + "email.com");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((passwordField)));
            driver.FindElement(passwordField).SendKeys("Test*01");

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((agreeTermsField)));
            driver.FindElement(agreeTermsField).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable((submitButtonforSignUp)));
            driver.FindElement(submitButtonforSignUp).Click();

            Thread.Sleep(3000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/en/wms/dashboard"));
        }


        public void Dispose()
        {
            driver.Quit();
        }
    }
}
