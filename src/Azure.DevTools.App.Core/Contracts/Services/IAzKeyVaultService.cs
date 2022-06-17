using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Contracts.Services;

public interface IAzKeyVaultService
{
    Task<List<AzKeyVault>> ListAllAsync();

    Task<List<AzKeyVaultSecret>> ListAllSecretsAsync(string vaultName);

    Task<AzKeyVaultSecretValue> ShowSecretAsync(string id);
}
