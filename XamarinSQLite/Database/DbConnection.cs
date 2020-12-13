using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CRUDApplication.Database
{
    class DbConnection
    {
        private static string databaseName = "MyAppDb.db3";
        public static string DatabasePath
        {
            get
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(folderPath, databaseName);
            }
        }
    }
}
