using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AddaDiLeonardo.Database;
using AddaDiLeonardo.iOS;
using Foundation;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseService))]
namespace AddaDiLeonardo.iOS
{
    public class DatabaseService : IDBInterface
    {
        public DatabaseService()
        {
        }

        public SQLiteAsyncConnection CreateConnection(string dbName)
        {
            var sqliteFilename = dbName;

            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            string path = Path.Combine(libFolder, sqliteFilename);

            // This is where we copy in the pre-created database
            if (!File.Exists(path))
            {
                var existingDb = NSBundle.MainBundle.PathForResource("Employee", "db");
                File.Copy(existingDb, path);
            }

            //var iOSPlatform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLiteAsyncConnection(path);

            // Return the database connection 
            return connection;
        }
    }
}