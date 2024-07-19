namespace shop.Helpers;

public static class Settings
{
    public static int Theme
    {
        get => Preferences.Get(nameof(Theme), 0);
        set
        {
            Preferences.Set(nameof(Theme), value);

            Application.Current!.UserAppTheme = Theme switch
            {
                //default
                0 => AppTheme.Unspecified,
                //light
                1 => AppTheme.Light,
                //dark
                2 => AppTheme.Dark,
                _ => AppTheme.Unspecified
            };
        }
    }
    
    public static string Token
    {
        get => Preferences.Get(nameof(Token), string.Empty);
        set => Preferences.Set(nameof(Token), value);
    }
}