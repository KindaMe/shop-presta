using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using shop.Views.Main.Account;

namespace shop.ViewModels;

public partial class HistoryViewModel : BaseViewModel
{
    public ObservableCollection<string> Orders { get; } = [];

    public HistoryViewModel()
    {
        Title = "Historia zamówień";
    }

    [RelayCommand]
    private async Task GoToDetails()
    {
        await Shell.Current.GoToAsync(nameof(HistoryDetailsPage));
    }

    [RelayCommand]
    private async Task Refresh()
    {
        IsBusy = true;

        Orders.Clear();
        
        //await Task.Delay(1500);

        for (var i = 1; i <= 20; i++)
        {
            Orders.Add($"Order {i}");
        }

        IsRefreshing = false;
        IsBusy = false;
    }

    [RelayCommand]
    private async Task Hmmm()
    {
        IsRefreshing = true;
    }
}