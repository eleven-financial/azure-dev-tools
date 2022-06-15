using Azure.DevTools.App.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Azure.DevTools.App.Views;

public sealed partial class DatabasesPage : Page
{
    public DatabasesViewModel ViewModel
    {
        get;
    }

    public DatabasesPage()
    {
        ViewModel = App.GetService<DatabasesViewModel>();
        InitializeComponent();
    }
}
