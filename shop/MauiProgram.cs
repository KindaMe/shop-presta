using Maui.FixesAndWorkarounds;
using Microsoft.Extensions.Logging;
using Plugin.LocalNotification;
using shop.ViewModels;
using shop.Views.Login;
using shop.Views.Main.Account;
using shop.Views.Main.Cart;
using shop.Views.Main.Categories;
using shop.Views.Main.Favorites;
using shop.Views.Main.Home;

namespace shop;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("fa-brands-400.ttf", "FAB");
                fonts.AddFont("fa-regular-400.ttf", "FAR");
                fonts.AddFont("fa-solid-900.ttf", "FAS");
            })
            .ConfigureMauiWorkarounds()
            .UseLocalNotification()
            .ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                handlers.AddHandler(typeof(Shell), typeof(MyShellRenderer));
#endif
            });
        
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<LoginViewModel>();

        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<RegisterViewModel>();

        builder.Services.AddTransient<ResetPasswordPage>();
        builder.Services.AddTransient<ResetPasswordViewModel>();

        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<HomeViewModel>();

        builder.Services.AddTransient<AccountPage>();
        builder.Services.AddTransient<AccountViewModel>();

        builder.Services.AddTransient<CartPage>();
        builder.Services.AddTransient<CartViewModel>();

        builder.Services.AddTransient<NotificationsPage>();
        builder.Services.AddTransient<NotificationsViewModel>();

        builder.Services.AddTransient<SettingsPage>();
        builder.Services.AddTransient<SettingsViewModel>();

        builder.Services.AddTransient<FavoritePage>();
        builder.Services.AddTransient<FavoriteViewModel>();

        builder.Services.AddTransient<AddressPage>();
        builder.Services.AddTransient<AddressViewModel>();

        builder.Services.AddTransient<PaymentMethodsPage>();
        builder.Services.AddTransient<PaymentMethodsViewModel>();

        builder.Services.AddTransient<HistoryPage>();
        builder.Services.AddTransient<HistoryViewModel>();

        builder.Services.AddTransient<SupportPage>();
        builder.Services.AddTransient<SupportViewModel>();

        builder.Services.AddTransient<HistoryDetailsPage>();
        builder.Services.AddTransient<HistoryDetailsViewModel>();

        builder.Services.AddTransient<LootBoxPage>();
        builder.Services.AddTransient<LootBoxViewModel>();

        builder.Services.AddTransient<CategoryPage>();
        builder.Services.AddTransient<CategoryViewModel>();

        builder.Services.AddTransient<UserDetailsPage>();
        builder.Services.AddTransient<UserDetailsViewModel>();

        builder.Services.AddTransient<CheckoutPage>();
        builder.Services.AddTransient<CheckoutViewModel>();

        builder.Services.AddTransient<ItemDetailsPage>();
        builder.Services.AddTransient<ItemDetailsViewModel>();

        builder.Services.AddTransient<CategoryDetailsPage>();
        builder.Services.AddTransient<CategoryDetailsViewModel>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}