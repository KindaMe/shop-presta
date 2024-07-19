using CommunityToolkit.Mvvm.Input;
using shop.Views.Main.Cart;
using shop.Views.Main.Home;

namespace shop.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    public HomeViewModel()
    {
        Title = "Witaj w sklepie!";
    }
    
    [RelayCommand]
    private async Task GoToLootBox()
    {
        await Shell.Current.GoToAsync(nameof(LootBoxPage));
    }
    
    [RelayCommand]
    private async Task GoToItemDetails()
    {
        await Shell.Current.GoToAsync(nameof(ItemDetailsPage));
    }
    
    [RelayCommand]
    private async Task GoToNotifications()
    {
        await Shell.Current.GoToAsync(nameof(NotificationsPage));
    }
}