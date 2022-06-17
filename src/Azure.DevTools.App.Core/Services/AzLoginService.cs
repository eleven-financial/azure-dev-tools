using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Helpers;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Services;

public class AzLoginService : IAzLoginService
{
    public async Task<bool> IsAuthenticatedAsync()
    {
        var shell = await PowerShell.RunAsync("az account show");
        return !string.IsNullOrWhiteSpace(shell.ResultOutput);
    }

    public async Task<List<AzSubscription>> LoginAsync()
    {
        var shell = await PowerShell.RunAsync("az login");
        return await shell.ResultOutput.ToObjectAsync<List<AzSubscription>>();
    }

    public async Task LogoutAsync()
    {
        await PowerShell.RunAsync("az logout");
    }
}
