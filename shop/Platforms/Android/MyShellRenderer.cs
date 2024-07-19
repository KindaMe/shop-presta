using Android.Content;
using Google.Android.Material.BottomNavigation;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;

namespace shop;

public class MyShellRenderer : ShellRenderer
{
    protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
    {
        return new ShellBottomNavViewAppearanceTrackerEx(this, shellItem.CurrentItem);
    }
}

internal class ShellBottomNavViewAppearanceTrackerEx(IShellContext shellContext, ShellItem shellItem)
    : ShellBottomNavViewAppearanceTracker(shellContext, shellItem)
{
    public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
    {
        base.SetAppearance(bottomView, appearance);
        bottomView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
    }
}