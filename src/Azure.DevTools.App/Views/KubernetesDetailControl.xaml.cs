using Azure.DevTools.App.Core.Models;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Azure.DevTools.App.Views;

public sealed partial class KubernetesDetailControl : UserControl
{
    public SampleOrder ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as SampleOrder;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(KubernetesDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public KubernetesDetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var control = d as KubernetesDetailControl;
        control.ForegroundElement.ChangeView(0, 0, 1);
    }
}
