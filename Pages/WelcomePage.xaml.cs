namespace Yummy.Pages;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void GetStarted_clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}