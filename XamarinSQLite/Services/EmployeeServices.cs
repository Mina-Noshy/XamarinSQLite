using CRUDApplication.Models;
using CRUDApplication.Repository;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDApplication.Services
{
    public class EmployeeServices : IAppRepository<Employees>
    {
        public SQLiteConnection context = App.context.Connection;

        public int Add(Employees entity)
        {
            return context.Insert(entity);
        }

        public int Delete(Employees entity)
        {
            return context.Delete(entity);
        }

        public IEnumerable<Employees> GetAll()
        {
            return context.Table<Employees>().ToList();
        }

        public IEnumerable<Employees> Search(string txt)
        {
            return context.Table<Employees>().Where(x => x.Name.Contains(txt)).ToList();
        }

        public int Update(Employees entity)
        {
            return context.Update(entity);
        }
    }
}
