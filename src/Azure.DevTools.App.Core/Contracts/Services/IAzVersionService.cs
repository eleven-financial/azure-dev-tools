using System.Threading.Tasks;
using Azure.DevTools.App.Core.Models;

namespace Azure.DevTools.App.Core.Contracts.Services;

public interface IAzVersionService
{
    Task<AzVersion> GetAsync();
}
