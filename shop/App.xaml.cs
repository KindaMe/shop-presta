using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using shop.Helpers;

namespace shop;

public partial class App : Application
{
    public App(INotificationService notificationService)
    {
        InitializeComponent();

        notificationService.NotificationActionTapped += NotificationServiceOnNotificationActionTapped;

        Current!.UserAppTheme = Settings.Theme switch
        {
            0 => AppTheme.Unspecified,
            1 => AppTheme.Light,
            2 => AppTheme.Dark,
            _ => throw new ArgumentOutOfRangeException()
        };

        MainPage = new AppShell();
    }

    private void NotificationServiceOnNotificationActionTapped(NotificationActionEventArgs e)
    {
        if (e.IsDismissed)
        {
            return;
        }

        if (e.IsTapped)
        {
            return;
        }

        // if Notification Action are setup
        switch (e.ActionId)
        {
        }
    }
}