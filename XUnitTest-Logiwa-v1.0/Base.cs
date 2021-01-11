using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace XUnitTest_Logiwa_v1._0
{
    public class Base
    {
        public static By signUpButton = By.XPath("//a[contains(text(),'Sign Up')]");
        public static By closeOnBoardingButtons = By.CssSelector(".close path");
        public static By firstNameField = By.Id("firstName");
        public static By lastNameField = By.Id("lastName");
        public static By emailField = By.Id("email");
        public static By passwordField = By.Id("password");
        public static By agreeTermsField = By.CssSelector(".k-checkbox-label");
        public static By submitButtonforSignUp = By.XPath("//button[@type='submit']");

        private string MyLogiwaDevURL = "https://mydev.logiwa.com/en/public/signin/?isTestAutomationLive=true";

        public void Run(ChromeDriver driver, WebDriverWait wait)
        {
            var email = $"automationtest-{Guid.NewGuid()}@gmail.com";
            var password = "Automation1234!";

            driver.Navigate().GoToUrl(MyLogiwaDevURL);
            driver.Manage().Window.Maximize();

            wait.Until(driver => driver.FindElement(signUpButton).Displayed);
            driver.FindElement(signUpButton).Click();
           
            wait.Until(driver => driver.FindElement(closeOnBoardingButtons).Displayed);
            driver.FindElement(closeOnBoardingButtons).Click();
           
            wait.Until(driver => driver.FindElement(firstNameField).Displayed);
            driver.FindElement(firstNameField).SendKeys("firstName");
            Thread.Sleep(1000);
            wait.Until(driver => driver.FindElement(lastNameField).Displayed);
            driver.FindElement(lastNameField).SendKeys("lastName");
            Thread.Sleep(1000);
            wait.Until(driver => driver.FindElement(emailField).Displayed);
            driver.FindElement(emailField).SendKeys(email);
            Thread.Sleep(1000);
            wait.Until(driver => driver.FindElement(passwordField).Displayed);
            driver.FindElement(passwordField).SendKeys(password);
            Thread.Sleep(1000);
            wait.Until(driver => driver.FindElement(agreeTermsField).Displayed);
            driver.FindElement(agreeTermsField).Click();
            Thread.Sleep(1000);
            wait.Until(driver => driver.FindElement(submitButtonforSignUp).Displayed);
            driver.FindElement(submitButtonforSignUp).Click();

            wait.Until(driver => driver.Url.Contains("/en/wms/dashboard"));
        }
    }
}