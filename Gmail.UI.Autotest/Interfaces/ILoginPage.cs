namespace Gmail.UI.Autotests.Interfaces
{
    public interface ILoginPage : IBasePage
    {
        void EnterLogin(string login);
        void EnterPassword(string password);       
    }
}