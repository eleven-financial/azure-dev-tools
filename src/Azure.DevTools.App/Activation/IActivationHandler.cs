using System.Threading.Tasks;

namespace Azure.DevTools.App.Activation;

public interface IActivationHandler
{
    bool CanHandle(object args);

    Task HandleAsync(object args);
}
