using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Helpers;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Services;

public class AzKeyVaultService : IAzKeyVaultService
{
    public async Task<List<AzKeyVault>> ListAllAsync()
    {
        var shell = await PowerShell.RunAsync("az keyvault list");
        return await shell.ResultOutput.ToObjectAsync<List<AzKeyVault>>();
    }

    public async Task<List<AzKeyVaultSecret>> ListAllSecretsAsync(string vaultName)
    {
        var shell = await PowerShell.RunAsync($"az keyvault secret list --vault-name {vaultName}");
        return await shell.ResultOutput.ToObjectAsync<List<AzKeyVaultSecret>>();
    }

    public async Task<AzKeyVaultSecretValue> ShowSecretAsync(string id)
    {
        var shell = await PowerShell.RunAsync($"az keyvault secret show --id {id}");
        return await shell.ResultOutput.ToObjectAsync<AzKeyVaultSecretValue>();
    }
}
