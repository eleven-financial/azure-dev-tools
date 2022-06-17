using Newtonsoft.Json;

namespace Azure.DevTools.App.Core.Models;

public class AzVersion
{
    [JsonProperty("azure-cli")]
    public string AzureCLI
    {
        get; set;
    }
}
