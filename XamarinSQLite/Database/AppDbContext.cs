using CRUDApplication.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDApplication.Database
{
    public class AppDbContext
    {
        public SQLiteConnection Connection { get; set; }
        public AppDbContext()
        {
            Initialize();
        }

        void Initialize()
        {
            Connection = new SQLiteConnection(DbConnection.DatabasePath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite);
            Connection.CreateTable<Employees>(CreateFlags.None);
        }
    }
}
