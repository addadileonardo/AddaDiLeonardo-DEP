using AddaDiLeonardo.Database.Classes;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AddaDiLeonardo.Database
{
     public class LanguageDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return DependencyService.Get<IDBInterface>().CreateConnection(DBName);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static string DBName = "Italian.db3";
        static bool initialized = false;

        public LanguageDatabase(string dbName)
        {
            DBName = dbName;
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

        public async Task<object> GetTesto()
        {
            string query = "Select * FROM Contenuto";
            var r = await Database.GetTableInfoAsync("Contenuto");
            return r;
        }

        //===== TABLES ====

        public async Task<CreateTableResult> CreateTableTappa()
        {
            return await Database.CreateTableAsync<Tappa>().ConfigureAwait(false);
        }

        public async Task<CreateTableResult> CreateTableSezione()
        {
            return await Database.CreateTableAsync<Sezione>().ConfigureAwait(false);
        }

        public async Task<CreateTableResult> CreateTableContenuto()
        {
            return await Database.CreateTableAsync<Contenuto>().ConfigureAwait(false);
        }

        public async Task DeleteTables()
        {
            await Database.DropTableAsync<Tappa>().ConfigureAwait(false);
            await Database.DropTableAsync<Sezione>().ConfigureAwait(false);
            await Database.DropTableAsync<Contenuto>().ConfigureAwait(false);
        }

        public async Task<List<TableName>> GetAllTablesAsync()
        {
            string queryString = $"SELECT name FROM sqlite_master WHERE type = 'table'";
            return await Database.QueryAsync<TableName>(queryString).ConfigureAwait(false);
        }

        //=================

        //=== Tappa ====

        public Task<List<Tappa>> GetTappaAsync()
        {
            return Database.Table<Tappa>().ToListAsync();
        }

        public async Task<Tappa> GetTappaAsync(int id)
        {
            return await Database.Table<Tappa>().Where(i => i.ID == id).FirstOrDefaultAsync().ConfigureAwait(false);
        }

        public Task<int> SaveTappaAsync(Tappa item)
        {
            if (item.ID /*!*/== 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteTappaAsync(Tappa item)
        {
            return Database.DeleteAsync(item);
        }

        //=====================

        //=== Sezione ====

        public async Task<List<Sezione>> GetSezioneAsync()
        {
            return await Database.Table<Sezione>().ToListAsync().ConfigureAwait(false);
        }

        public async Task<List<Sezione>> GetSezioneAsync(int idtappa)
        {
            return await Database.Table<Sezione>().Where(i => i.IDTappa == idtappa).ToListAsync().ConfigureAwait(false);
        }

        public Task<int> SaveSezioneAsync(Sezione item)
        {
            if (item.ID /*!*/== 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteSezioneAsync(Sezione item)
        {
            return Database.DeleteAsync(item);
        }

        //=====================

        //=== Contenuto ====

        public Task<List<Contenuto>> GetContenutoAsync()
        {
            return Database.Table<Contenuto>().ToListAsync();
        }

        public async Task<List<Contenuto>> GetContenutoAsync(int idsezione)
        {
            return await Database.Table<Contenuto>().Where(i => i.IDSezione == idsezione).ToListAsync().ConfigureAwait(false);
        }

        public Task<int> SaveContenutoAsync(Contenuto item)
        {
            if (item.ID /*!*/== 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteContenutoAsync(Contenuto item)
        {
            return Database.DeleteAsync(item);
        }

        //=====================

    }

    public class TableName
    {
        public TableName() { }
        public string name { get; set; }
    }
}
