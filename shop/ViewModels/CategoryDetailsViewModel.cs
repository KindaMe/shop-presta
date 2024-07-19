using CommunityToolkit.Mvvm.Input;
using shop.Views.Main.Cart;

namespace shop.ViewModels;

public partial class CategoryDetailsViewModel : BaseViewModel
{
    public CategoryDetailsViewModel()
    {
        Title = "Nazwa kategorii";
    }
    
    [RelayCommand]
    private async Task GoToItemDetails()
    {
        await Shell.Current.GoToAsync(nameof(ItemDetailsPage));
    }
}