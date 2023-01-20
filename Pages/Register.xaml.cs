using SQLite;
using System.IO;
using Yummy.Models;

namespace Yummy.Pages
{
    public partial class Register : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;
        public Register()
        {
            InitializeComponent();
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yummy.db3");
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<User>().Wait();
        }

        private async void RegisterButton_clicked(object sender, EventArgs e)
        {
            var email = emailEntry.Text;
            var password = passwordEntry.Text;
            var username = usernameEntry.Text;

            var user = new User { Email = email, Password = password, UserName = username };
            await _connection.InsertAsync(user);

            await Navigation.PushModalAsync(new ChooseDiet());
        }

        private async void GoLoginButton_clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Login");
        }
    }
}
