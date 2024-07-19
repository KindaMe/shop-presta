using shop.ViewModels;

namespace shop.Views.Main.Home;

public partial class LootBoxPage : ContentPage
{
    public LootBoxPage(LootBoxViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}