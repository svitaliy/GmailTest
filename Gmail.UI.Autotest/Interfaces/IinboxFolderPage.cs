﻿using Gmail.UI.Autotests.Models;
using System.Collections.Generic;

namespace Gmail.UI.Autotests.Interfaces
{
    public interface IinboxFolderPage : IBasePage
    {
        IEnumerable<MainAreaMsgModel> GetInboxInfo();
    }
}