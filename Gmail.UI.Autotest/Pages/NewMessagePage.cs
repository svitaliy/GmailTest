using Gmail.UI.Autotest;
using Gmail.UI.Autotests.Interfaces;
using Gmail.UI.Autotests.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Gmail.UI.Autotests.Pages
{
    public class NewMessagePage : BasePage, INewMessagePage
    {
        #region Selectors
        private IWebElement RecipientCcIcon => 
            _webDriver.FindElement(By.CssSelector("div[role='dialog'] tbody td [name='cc']"));
        private IWebElement MsgBody => 
            _webDriver.FindElement(By.XPath("//div[contains(@aria-label,'Message Body') and not(contains(@form, 'nosend'))]"));
        private IWebElement MsgHeader(string textarea) => 
            _webDriver.FindElement(By.CssSelector($"div[role='dialog'] tbody td [name='{textarea}']"));

        private const string RecipientTo = "to";
        private const string RecipientCc = "cc";
        private const string Subject = "subjectbox";
        #endregion

        private readonly IWebDriver _webDriver;
        public NewMessagePage(IWebDriver webDriver) : base(webDriver)
        {
            _webDriver = webDriver;
        }

        public void FillNewMessage(NewMessageModel messageModel)
        {
            if (string.IsNullOrEmpty(messageModel.RecipientTo))
            {
                MsgHeader(RecipientTo).SendKeys(messageModel.RecipientTo);
            };

            if (string.IsNullOrEmpty(messageModel.RecipientCc))
            {
                RecipientCcIcon.Click();
                MsgHeader(RecipientCc).SendKeys(messageModel.RecipientCc);
            };

            if (string.IsNullOrEmpty(messageModel.Subject))
            {
                MsgHeader(Subject).Click();
                MsgHeader(Subject).SendKeys(messageModel.Subject);
            };

            if (string.IsNullOrEmpty(messageModel.MsgBody))
            {
                MsgBody.Click();
                MsgBody.SendKeys(messageModel.MsgBody);
            };
        }

        public void SendMessage()
        {
            Actions builder = new Actions(_webDriver);
            builder.KeyDown(Keys.Control).KeyDown(Keys.Enter).Perform();
            builder.KeyUp(Keys.Control).KeyUp(Keys.Enter).Perform();
        }
    }
}