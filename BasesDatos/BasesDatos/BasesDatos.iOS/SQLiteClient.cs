using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BasesDatos.Dependencies;
using BasesDatos.iOS;
using Foundation;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteClient))]
namespace BasesDatos.iOS
{
    public class SQLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            String bbddfile = "HOSPITAL.db";
            string rutadocumentos = 
                Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string librarypath = Path.Combine(rutadocumentos, ".."
                , "Library", "Databases");

            if (!Directory.Exists(librarypath))
            {
                Directory.CreateDirectory(librarypath);
            }
            string path = Path.Combine(librarypath, bbddfile);

            SQLite.SQLiteConnection connection = 
                new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}