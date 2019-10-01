using System.Collections.Generic;
using System.Threading.Tasks;
using ResearchDocumenter.Model;
using SQLite;

namespace ResearchDocumenter.Data
{
    public class ResearchDatabase
    {
        readonly SQLiteAsyncConnection _database;
        
        public ResearchDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Article>().Wait();
            _database.CreateTableAsync<User>().Wait();
        }

        /* Article operations */
        public Task<List<Article>> GetArticlesAsync()
        {
            return _database.Table<Article>().ToListAsync();
        }
        public Task<List<Article>> GetArticlesByTextAsync()
        {
            return _database.Table<Article>().ToListAsync();
        }

        

        public Task<Article> GetArticleAsync(int id)
        {
            return _database.Table<Article>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }   

        public Task<int> SaveArticleAsync(Article article)
        {
            if (article.ID != 0)
            {
                return _database.UpdateAsync(article);
            }
            else
            {
                return _database.InsertAsync(article);
            }
        }

        public Task<int> DeleteNoteAsync(Article article)
        {
            return _database.DeleteAsync(article);
        }
        /* User operations */
        public Task<User> GetUserAsync(string username, string pass)
        {
            return _database.Table<User>()
                            .Where(i => i.Email == username && i.Password == pass)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            if (user.ID != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

    }
}
