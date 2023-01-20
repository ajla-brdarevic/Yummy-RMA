using SQLite;
using System;
using System.Threading.Tasks;

namespace Yummy.Models
{
    internal class Users
    {
        private readonly SQLiteConnection _database;

        public Users(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            CreateTable();
        }

        private void CreateTable()
        {
            _database.CreateTable<User>();
        }

        public void AddUser(string email, string password, string userName)
        {
            var user = new User
            {
                Email = email,
                Password = password,
                UserName = userName
            };
            _database.Insert(user);
        }

        public User GetUser(string userName, string password)
        {
            var user = _database.Table<User>().Where(u => u.UserName == userName).FirstOrDefault();
            if (user != null && user.Password == password)
            {
                return user;
            }
            return null;
        }
    }

    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public string Password { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }
    }
}
