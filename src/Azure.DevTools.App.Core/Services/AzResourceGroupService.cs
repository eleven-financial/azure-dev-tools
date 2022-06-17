using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Helpers;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Services;

public class AzResourceGroupService : IAzResourceGroupService
{
    public async Task<AzResourceGroup> GetAsync(string name)
    {
        var shell = await PowerShell.RunAsync($"az group show --name {name}");
        return await shell.ResultOutput.ToObjectAsync<AzResourceGroup>();
    }

    public async Task<List<AzResourceGroup>> ListAllAsync()
    {
        var shell = await PowerShell.RunAsync("az group list");
        return await shell.ResultOutput.ToObjectAsync<List<AzResourceGroup>>();
    }
}
