using Azure.DevTools.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Azure.DevTools.App.Views;

public sealed partial class KeyvaultsPage : Page
{
    public KeyvaultsViewModel ViewModel
    {
        get;
    }

    public KeyvaultsPage()
    {
        ViewModel = App.GetService<KeyvaultsViewModel>();
        InitializeComponent();
    }
}
