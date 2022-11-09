using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyFirstApp.datas;
using SQLite;
using Xamarin.Forms;
using System.Threading;
using Android.Webkit;



[assembly: Dependency(typeof(MyFirstApp.Droid.connection.sqlconnection))]
namespace MyFirstApp.Droid.connection
{
    public class sqlconnection : Idatabase
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }

        public SQLiteConnection GetSqlConnection()
        {
            var filename = "Places.db";
            var documentspath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = System.IO.Path.Combine(documentspath, filename);
            var connection = new SQLiteConnection(path);
            return connection;
            
        }

        public SQLiteConnection GetSqlconnection()
        {
            throw new NotImplementedException();
        }
    }
}
