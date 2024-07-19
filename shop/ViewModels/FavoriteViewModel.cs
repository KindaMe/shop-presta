using CommunityToolkit.Mvvm.Input;
using shop.Views.Main.Cart;

namespace shop.ViewModels;

public partial class FavoriteViewModel : BaseViewModel
{
    public FavoriteViewModel()
    {
        Title = "Ulubione";
    }
    
    [RelayCommand]
    private async Task GoToItemDetails()
    {
        await Shell.Current.GoToAsync(nameof(ItemDetailsPage));
    }
}