using System.Collections.ObjectModel;
using System.Windows.Input;

using Azure.DevTools.App.Contracts.Services;
using Azure.DevTools.App.Contracts.ViewModels;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Azure.DevTools.App.ViewModels;

public class DatabasesViewModel : ObservableRecipient, INavigationAware
{
    private readonly INavigationService _navigationService;
    private readonly ISampleDataService _sampleDataService;
    private ICommand _itemClickCommand;

    public ICommand ItemClickCommand => _itemClickCommand ??= new RelayCommand<SampleOrder>(OnItemClick);

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DatabasesViewModel(INavigationService navigationService, ISampleDataService sampleDataService)
    {
        _navigationService = navigationService;
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetContentGridDataAsync();
        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    private void OnItemClick(SampleOrder clickedItem)
    {
        if (clickedItem != null)
        {
            _navigationService.SetListDataItemForNextConnectedAnimation(clickedItem);
            _navigationService.NavigateTo(typeof(DatabasesDetailViewModel).FullName, clickedItem.OrderID);
        }
    }
}
