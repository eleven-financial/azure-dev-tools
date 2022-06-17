using System;

namespace Azure.DevTools.App.Core.Models;

public class AzSubscription
{
    public Guid Id
    {
        get; set;
    }

    public string Name
    {
        get; set;
    }

    public bool IsDefault
    {
        get; set;
    }

    public Guid TenantId
    {
        get; set;
    }

    public AzUser User
    {
        get; set;
    }
}

public class AzUser
{
    public string Name
    {
        get; set;
    }

    public string Type
    {
        get; set;
    }
}
