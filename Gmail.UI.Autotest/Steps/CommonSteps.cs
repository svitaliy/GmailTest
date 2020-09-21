using Gmail.UI.Autotests.Helpers;
using Gmail.UI.Autotests.Interfaces;
using TechTalk.SpecFlow;

namespace Gmail.UI.Autotests.Steps
{
    [Binding]
    public sealed class CommonSteps
    {
        private readonly IBasePage _basePage;
        private readonly ScenarioContext _scenarioContext;
        private readonly ILoginPage _loginPage;

        public CommonSteps(IBasePage basePage, ILoginPage loginPage, ScenarioContext scenarioContext)
        {
            _basePage = basePage;
            _scenarioContext = scenarioContext;
            _loginPage = loginPage;
        }

        [Given(@"I have navigated to (.*) page")]
        public void NavigateToGmailPage(string app)
        {
            _loginPage.EnterLogin(AtConfiguration.GetConfiguration("Email"));
            _loginPage.EnterPassword(AtConfiguration.GetConfiguration("Password"));
        }
    }
}