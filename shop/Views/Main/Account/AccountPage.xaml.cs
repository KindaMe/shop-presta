using shop.Helpers;
using shop.ViewModels;

namespace shop.Views.Main.Account;

public partial class AccountPage : ContentPage
{
    public AccountPage(AccountViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (BindingContext is AccountViewModel model) model.IsLoggedIn = !string.IsNullOrEmpty(Settings.Token);
    }
}