using System.Threading.Tasks;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Helpers;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Services;

public class AzVersionService : IAzVersionService
{
    public async Task<AzVersion> GetAsync()
    {
        var shell = await PowerShell.RunAsync("az version");
        return await shell.ResultOutput.ToObjectAsync<AzVersion>();
    }    
}
