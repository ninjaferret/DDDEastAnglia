﻿using System.Web.Mvc;
using DDDEastAnglia.Models;

namespace DDDEastAnglia.Helpers
{
    public interface IRequestInformationProvider
    {
        string UserAgent { get; }
        string Referrer { get; }
        string SessionId { get; }
        bool IsAjaxRequest { get; }
        string GetIPAddress();
        bool IsLoggedIn();
        UserProfile GetCurrentUser();
    }
}