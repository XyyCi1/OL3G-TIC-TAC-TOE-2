using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Database
    {
        private static SQLiteConnection _conn;

        public static SQLiteConnection GetConnection()
        {
            if (_conn == null)
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string dbPath = Path.Combine(folder, "accounts.db3");

                _conn = new SQLiteConnection(dbPath);
                _conn.CreateTable<UserAccount>();
                _conn.CreateTable<MatchRecord>();
            }

            return _conn;
        }
    }
}
