using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using shop.Helpers;
using shop.Views.Login;
using shop.Views.Main.Account;
using shop.Views.Main.Favorites;
using shop.Views.Main.Home;

namespace shop.ViewModels;

public partial class AccountViewModel : BaseViewModel
{
    [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsNotLoggedIn))]
    private bool _isLoggedIn;

    public bool IsNotLoggedIn => !IsLoggedIn;


    public AccountViewModel()
    {
        Title = "Profil";
    }

    [RelayCommand]
    private async Task GoToFavorites()
    {
        await Shell.Current.GoToAsync(nameof(FavoritePage));
    }

    [RelayCommand]
    private async Task GoToAddress()
    {
        await Shell.Current.GoToAsync(nameof(AddressPage));
    }

    [RelayCommand]
    private async Task GoToPaymentMethods()
    {
        await Shell.Current.GoToAsync(nameof(PaymentMethodsPage));
    }

    [RelayCommand]
    private async Task GoToHistory()
    {
        await Shell.Current.GoToAsync(nameof(HistoryPage));
    }

    [RelayCommand]
    private async Task GoToSettings()
    {
        await Shell.Current.GoToAsync(nameof(SettingsPage));
    }

    [RelayCommand]
    private async Task GoToSupport()
    {
        await Shell.Current.GoToAsync(nameof(SupportPage));
    }

    [RelayCommand]
    private async Task GoToUserDetails()
    {
        await Shell.Current.GoToAsync(nameof(UserDetailsPage));
    }

    [RelayCommand]
    private async Task Logout()
    {
        Settings.Token = string.Empty;
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    [RelayCommand]
    private async Task Login()
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}