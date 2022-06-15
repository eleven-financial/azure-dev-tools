using System.Linq;

using Azure.DevTools.App.Contracts.ViewModels;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace Azure.DevTools.App.ViewModels;

public class AllToolsDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder _item;

    public SampleOrder Item
    {
        get => _item;
        set => SetProperty(ref _item, value);
    }

    public AllToolsDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
