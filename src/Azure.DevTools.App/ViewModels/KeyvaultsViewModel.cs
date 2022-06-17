using Azure.DevTools.App.Contracts.ViewModels;
using Azure.DevTools.App.Core.Contracts.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Azure.DevTools.App.ViewModels;

public class KeyvaultsViewModel : ObservableRecipient, INavigationAware
{
    private readonly IAzKeyVaultService _azKeyVaultService;
    private readonly IAzLoginService _azLoginService;

    public KeyvaultsViewModel(IAzKeyVaultService azKeyVaultService, IAzLoginService azLoginService)
    {
        _azKeyVaultService = azKeyVaultService;
        _azLoginService = azLoginService;
    }

    public void OnNavigatedFrom()
    {
    }
    
    public async void OnNavigatedTo(object parameter)
    {
        //TODO: Only test
        var isAuthenticated = await _azLoginService.IsAuthenticatedAsync();
        if (!isAuthenticated)
        {
            await _azLoginService.LoginAsync();
        }

        var vaults = await _azKeyVaultService.ListAllAsync();
    }
}
