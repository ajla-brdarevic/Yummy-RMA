using SQLite;
using System.IO;
using Yummy.Models;

namespace Yummy.Pages
{
    public partial class Login : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;

        public Login()
        {
            InitializeComponent();
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yummy.db3");
            _connection = new SQLiteAsyncConnection(dbPath);
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            var username = usernameEntry.Text;
            var password = passwordEntry.Text;

            var user = await _connection.Table<User>()
                                .Where(u => u.UserName == username && u.Password == password)
                                .FirstOrDefaultAsync();
            if (user != null)
            {
                //await Navigation.PushAsync(new Home());
                //await ((App)Application.Current).GoToHomePage();
                await Shell.Current.GoToAsync("///Home");

            }
            else
            {
                await DisplayAlert("Error", "Invalid email or password.", "OK");
            }
        }

        private async void GoRegistreButton_clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Register");
        }
    }
}
