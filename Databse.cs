using MyFirstApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace MyFirstApp.datas
{
    public class Databse
    {
        static object locker = new object();

        SQLiteConnection _sqlconnection;

        public Databse()
        {
            _sqlconnection = DependencyService.Get<Idatabase>().GetConnection();
            _sqlconnection.CreateTable<Places>();
        }
        public int Insert(Places place)
        {
            lock (locker)
            {
                return _sqlconnection.Insert(place);
            }
        }
        public int Update(Places place)
        {
            lock (locker)
            {
                return _sqlconnection.Update(place);
            }
        }
        public int Delete(int id)
        {
            lock (locker)
            {
                return _sqlconnection.Delete<Places>(id);
            }
        }
        public IEnumerable<Places> GetAll()
        {
            lock (locker)
            {
                return (from i in _sqlconnection.Table<Places>() select i).ToList();
            }
        }
        public int FullDelete()
        {
            lock (locker)
            {
                return _sqlconnection.DeleteAll<Places>();
            }
        }
        public Places Get(int id)
        {
            lock (locker)
            {
                return _sqlconnection.Table<Places>().FirstOrDefault(t => t.Id == id);
            }
        }
        public void Dispose()
        {
            _sqlconnection.Dispose();
        }
    }
}
