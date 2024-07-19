using shop.Views.Login;
using shop.Views.Main.Account;
using shop.Views.Main.Cart;
using shop.Views.Main.Categories;
using shop.Views.Main.Home;

namespace shop;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(ResetPasswordPage), typeof(ResetPasswordPage));
        Routing.RegisterRoute(nameof(AddressPage), typeof(AddressPage));
        Routing.RegisterRoute(nameof(HistoryPage), typeof(HistoryPage));
        Routing.RegisterRoute(nameof(PaymentMethodsPage), typeof(PaymentMethodsPage));
        Routing.RegisterRoute(nameof(SupportPage), typeof(SupportPage));
        Routing.RegisterRoute(nameof(HistoryDetailsPage), typeof(HistoryDetailsPage));
        Routing.RegisterRoute(nameof(LootBoxPage), typeof(LootBoxPage));
        Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        Routing.RegisterRoute(nameof(UserDetailsPage), typeof(UserDetailsPage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
        Routing.RegisterRoute(nameof(ItemDetailsPage), typeof(ItemDetailsPage));
        Routing.RegisterRoute(nameof(NotificationsPage), typeof(NotificationsPage));
        Routing.RegisterRoute(nameof(CategoryDetailsPage), typeof(CategoryDetailsPage));
    }
}