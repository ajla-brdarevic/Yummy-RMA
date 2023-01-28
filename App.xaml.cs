using Yummy.Pages;

namespace Yummy;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        Shell.Current.GoToAsync("//WelcomePage");
    }

}
