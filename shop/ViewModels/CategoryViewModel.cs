using CommunityToolkit.Mvvm.Input;
using shop.Views.Main.Cart;
using shop.Views.Main.Categories;

namespace shop.ViewModels;

public partial class CategoryViewModel : BaseViewModel
{
    public CategoryViewModel()
    {
        Title = "Kategorie";
    }
    
    [RelayCommand]
    private async Task GoToCategoryDetails()
    {
        await Shell.Current.GoToAsync(nameof(CategoryDetailsPage));
    }
}