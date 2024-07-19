using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using shop.Views.Main.Cart;

namespace shop.ViewModels;

public partial class CartViewModel : BaseViewModel
{
    public ObservableCollection<string> Items { get; set; } =
    [
        "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6", "Item 7", "Item 8", "Item 9", "Item 10",
        "Item 11", "Item 12", "Item 13", "Item 14", "Item 15", "Item 16", "Item 17", "Item 18", "Item 19", "Item 20"
    ];
    
    public CartViewModel()
    {
        Title = "Koszyk";
    }

    [RelayCommand]
    private async Task GoToCheckout()
    {
        await Shell.Current.GoToAsync(nameof(CheckoutPage));
    }

    [RelayCommand]
    private async Task GoToItemDetails()
    {
        await Shell.Current.GoToAsync(nameof(ItemDetailsPage));
    }
}