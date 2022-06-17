using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Contracts.Services;

public interface IAzResourceGroupService
{
    Task<AzResourceGroup> GetAsync(string name);

    Task<List<AzResourceGroup>> ListAllAsync();
}
