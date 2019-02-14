using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Birthday
{
    public static class DataAccess
    {
        public static void InitializeDatabase()
        {
            using (SqliteConnection db =
                new SqliteConnection("Filename=birthday.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS birthdayTable (Primary_Key INTEGER PRIMARY KEY, name VARCHAR, birthday DATE)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}
