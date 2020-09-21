﻿using Gmail.UI.Autotest;
using Gmail.UI.Autotests.Interfaces;
using OpenQA.Selenium;

namespace Gmail.UI.Autotests.Pages
{
    public class LoginPage : BasePage, ILoginPage
    {
        #region CSS_Locators
        private IWebElement EmailInput => _webDriver.FindElement(By.Id("identifierId"));
        private IWebElement PasswordInput => _webDriver.FindElement(By.CssSelector("input[type='password']"));
        private IWebElement EmailNextBtn => _webDriver.FindElement(By.Id("identifierNext"));
        private IWebElement PasswordNextBtn => _webDriver.FindElement(By.Id("passwordNext"));
        #endregion

        private readonly IWebDriver _webDriver;
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            _webDriver = webDriver;
        }
                
        public void EnterLogin(string login)
        {
            EmailInput.SendKeys(login);
            EmailNextBtn.Click();
        }

        public void EnterPassword(string password)
        {
            PasswordInput.SendKeys(password);
            PasswordNextBtn.Click();
        }        
    }
}