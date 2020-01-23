using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AddaDiLeonardo.Database
{
    public interface IDBInterface
    {
        SQLiteAsyncConnection CreateConnection(string dbName);
    }
}
