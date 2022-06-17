namespace Azure.DevTools.App.Core.Models;

public class AzResourceGroup
{
    public string Id
    {
        get; set;
    }

    public string Location
    {
        get; set;
    }

    public string Name
    {
        get; set;
    }

    public dynamic Tags
    {
        get; set;
    }
}
