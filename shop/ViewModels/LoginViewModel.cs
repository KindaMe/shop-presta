using CommunityToolkit.Mvvm.Input;
using shop.Helpers;
using shop.Views.Login;

namespace shop.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    public LoginViewModel()
    {
        Title = "Logowanie";
    }
    
    [RelayCommand]
    private async Task GoToRegister()
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    [RelayCommand]
    private async Task GoToResetPassword()
    {
        await Shell.Current.GoToAsync(nameof(ResetPasswordPage));
    }

    [RelayCommand]
    private async Task Login()
    {
        Settings.Token = "123";
        await Shell.Current.GoToAsync("..");
    }
}