﻿using AddaDiLeonardo.Database.Classes;
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

        public Task<Tappa> GetTappaAsync(int id)
        {
            return Database.Table<Tappa>().Where(i => i.ID == id).FirstOrDefaultAsync();
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

        public Task<List<Sezione>> GetSezioneAsync()
        {
            return Database.Table<Sezione>().ToListAsync();
        }

        public Task<List<Sezione>> GetSezioneAsync(int idtappa)
        {
            return Database.Table<Sezione>().Where(i => i.IDTappa == idtappa).ToListAsync();
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

        public Task<List<Contenuto>> GetContenutoAsync(int idsezione)
        {
            return Database.Table<Contenuto>().Where(i => i.IDSezione == idsezione).ToListAsync();
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