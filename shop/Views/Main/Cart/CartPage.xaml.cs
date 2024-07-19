using shop.ViewModels;

namespace shop.Views.Main.Cart;

public partial class CartPage : ContentPage
{
    public CartPage(CartViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}