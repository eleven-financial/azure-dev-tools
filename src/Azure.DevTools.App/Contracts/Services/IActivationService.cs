using System.Threading.Tasks;

namespace Azure.DevTools.App.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
