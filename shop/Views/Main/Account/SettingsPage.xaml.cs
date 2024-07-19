using shop.Helpers;
using shop.ViewModels;

namespace shop.Views.Main.Account;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();

        switch (Settings.Theme)
        {
            case 0:
                RadioButtonSystem.IsChecked = true;
                break;
            case 1:
                RadioButtonLight.IsChecked = true;
                break;
            case 2:
                RadioButtonDark.IsChecked = true;
                break;
        }

        BindingContext = viewModel;
    }

    private void RadioButton_CheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        if (!e.Value)
            return;

        var val = (sender as RadioButton)?.Value as string;
        if (string.IsNullOrWhiteSpace(val))
            return;

        Settings.Theme = val switch
        {
            "System" => 0,
            "Light" => 1,
            "Dark" => 2,
            _ => Settings.Theme
        };
    }
}