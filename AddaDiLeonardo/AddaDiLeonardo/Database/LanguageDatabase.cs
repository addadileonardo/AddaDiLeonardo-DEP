using AddaDiLeonardo.Database.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddaDiLeonardo.Database
{
     public class LanguageDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public LanguageDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Tappa).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Tappa)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }

        //Methods

        public void CreateTable()
        {
            _ = Database.CreateTableAsync<Tappa>().Result;
        }

        public Task<List<Tappa>> GetItemsAsync()
        {
            return Database.Table<Tappa>().ToListAsync();
        }

        //public Task<List<Tappa>> GetItemsNotDoneAsync()
        //{
        //    // SQL queries are also possible
        //    return Database.QueryAsync<Tappa>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        //}

        public Task<Tappa> GetItemAsync(int id)
        {
            return Database.Table<Tappa>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Tappa item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Tappa item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
