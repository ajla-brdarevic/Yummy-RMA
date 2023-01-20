using Yummy.Pages;

namespace Yummy;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		//Routing.RegisterRoute("Login", typeof(Login));

    }

}
