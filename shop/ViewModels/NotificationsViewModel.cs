using CommunityToolkit.Mvvm.Input;
using Plugin.LocalNotification;

namespace shop.ViewModels;

public partial class NotificationsViewModel : BaseViewModel
{
    private readonly INotificationService _notificationService;

    public NotificationsViewModel(INotificationService notificationService)
    {
        _notificationService = notificationService;
        Title = "Powiadomienia";
    }

    [RelayCommand]
    private async Task ClearNotifications() //TODO: Implement actual clearing of notifications
    {
        //for now it's just a test for showing notifications
        if (await _notificationService.AreNotificationsEnabled() == false)
        {
            await _notificationService.RequestNotificationPermission();
        }

        var notification = new NotificationRequest
        {
            NotificationId = 100,
            Title = "Test",
            Description = "Test Description",
            ReturningData = "Dummy data", // Returning data when tapped on notification.
            Android =
            {
                IconSmallName =
                {
                    ResourceName = "dotnet_bot"
                },
                // IconLargeName =
                // {
                //     ResourceName = "dotnet_bot"
                // }
            }
            // Schedule =
            // {
            //     NotifyTime =
            //         DateTime.Now
            //             .AddSeconds(
            //                 30) // This is Used for Scheduling local notifications; if not specified, the notification will show immediately.
            // }
        };
        await _notificationService.Show(notification);
    }
}