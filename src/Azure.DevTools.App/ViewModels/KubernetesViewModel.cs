using System.Collections.ObjectModel;
using System.Linq;

using Azure.DevTools.App.Contracts.ViewModels;
using Azure.DevTools.App.Core.Contracts.Services;
using Azure.DevTools.App.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace Azure.DevTools.App.ViewModels;

public class KubernetesViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder _selected;

    public SampleOrder Selected
    {
        get => _selected;
        set => SetProperty(ref _selected, value);
    }

    public ObservableCollection<SampleOrder> SampleItems { get; private set; } = new ObservableCollection<SampleOrder>();

    public KubernetesViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetListDetailsDataAsync();

        foreach (var item in data)
        {
            SampleItems.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    public void EnsureItemSelected()
    {
        if (Selected == null)
        {
            Selected = SampleItems.First();
        }
    }
}
