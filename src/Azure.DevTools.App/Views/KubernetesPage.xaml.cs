using Azure.DevTools.App.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace Azure.DevTools.App.Views;

public sealed partial class KubernetesPage : Page
{
    public KubernetesViewModel ViewModel
    {
        get;
    }

    public KubernetesPage()
    {
        ViewModel = App.GetService<KubernetesViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
