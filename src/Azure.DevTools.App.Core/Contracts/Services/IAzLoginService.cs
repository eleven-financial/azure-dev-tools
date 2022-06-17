using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Contracts.Services;

public interface IAzLoginService
{
    Task<bool> IsAuthenticatedAsync();

    Task<List<AzSubscription>> LoginAsync();

    Task LogoutAsync();
}
