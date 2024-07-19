using shop.ViewModels;

namespace shop.Views.Main.Favorites;

public partial class FavoritePage : ContentPage
{
    public FavoritePage(FavoriteViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}