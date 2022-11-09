using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp.datas
{
    public interface Idatabase
    {
        SQLiteConnection GetSqlconnection();
        SQLiteConnection GetConnection();
    }
}
