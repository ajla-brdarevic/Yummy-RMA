using Yummy.Pages;

namespace Yummy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Navigation.PushModalAsync(new Login());
    }
}
