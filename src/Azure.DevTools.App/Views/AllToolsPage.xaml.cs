using Azure.DevTools.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Azure.DevTools.App.Views;

public sealed partial class AllToolsPage : Page
{
    public AllToolsViewModel ViewModel
    {
        get;
    }

    public AllToolsPage()
    {
        ViewModel = App.GetService<AllToolsViewModel>();
        InitializeComponent();
    }
}
