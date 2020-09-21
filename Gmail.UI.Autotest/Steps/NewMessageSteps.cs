using Gmail.UI.Autotests.Interfaces;
using Gmail.UI.Autotests.Models;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Gmail.UI.Autotests.Steps
{
    [Binding]
    public sealed class NewMessageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly INewMessagePage _newMessagePage;

        public NewMessageSteps(INewMessagePage newMessagePage, ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _newMessagePage = newMessagePage;
        }

        [When(@"populate (.*) as recipient, (.*) as CC, (.*) as subject, (.*) as message body")]
        public void WhenPopulateFieldsAtNewMessagePage(string emailTo, string emailCC, string topic, string bodyMsg)
        {
            var messages = new List<NewMessageModel>();

            var initNewMessage = new NewMessageModel
            {
                RecipientTo = emailTo,
                RecipientCc = emailCC,
                MsgBody = bodyMsg,
                Subject = topic
            };

            messages.Add(initNewMessage);
            _scenarioContext["newMessages"] = messages;
            _newMessagePage.FillNewMessage(initNewMessage);
        }

        [When(@"send new message")]
        public void WhenSendNewMessage()
        {
            _newMessagePage.SendMessage();
        }
    }
}