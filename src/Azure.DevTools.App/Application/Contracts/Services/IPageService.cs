using System;

namespace Azure.DevTools.App.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
