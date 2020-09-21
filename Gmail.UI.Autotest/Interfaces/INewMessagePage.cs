using Gmail.UI.Autotests.Models;

namespace Gmail.UI.Autotests.Interfaces
{
    public interface INewMessagePage : IBasePage
    {
        void FillNewMessage(NewMessageModel messageModel);
        void SendMessage();
    }
}