using Azure.DevTools.App.Contracts.Services;
using Azure.DevTools.App.ViewModels;

using CommunityToolkit.WinUI.UI.Animations;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace Azure.DevTools.App.Views;

public sealed partial class AllToolsDetailPage : Page
{
    public AllToolsDetailViewModel ViewModel
    {
        get;
    }

    public AllToolsDetailPage()
    {
        ViewModel = App.GetService<AllToolsDetailViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        base.OnNavigatingFrom(e);
        if (e.NavigationMode == NavigationMode.Back)
        {
            var navigationService = App.GetService<INavigationService>();
            navigationService.SetListDataItemForNextConnectedAnimation(ViewModel.Item);
        }
    }
}
