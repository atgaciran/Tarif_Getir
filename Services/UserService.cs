using SQLite;
using System.Threading.Tasks;
using TarifGetir.Models; // Kullanici sınıfının burada olduğunu varsayıyorum
using System.IO;

namespace TarifGetir.Services
{
    public class UserService
    {
        private readonly SQLiteAsyncConnection _database;

        public UserService()
        {
            _database = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "TarifGetir.db3"));
            _database.CreateTableAsync<Kullanici>().Wait();
        }

        public async Task<Kullanici> GetFirstUserAsync()
        {
            return await _database.Table<Kullanici>().FirstOrDefaultAsync();
        }

        public async Task<Kullanici> GetUserByIdAsync(int userId)
        {
            return await _database.Table<Kullanici>().FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<Kullanici> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            return await _database.Table<Kullanici>().FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }
    }
}
