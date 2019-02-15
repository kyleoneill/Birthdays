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
            using (SqliteConnection db = new SqliteConnection("Filename=birthday.db"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT EXISTS birthdayTable (Primary_Key INTEGER PRIMARY KEY, name VARCHAR, birthday DATE)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }

        public static void AddPerson(string name, DateTime birthday)
        {
            using (SqliteConnection db = new SqliteConnection("Filename=birthday.db"))
            {
                db.Open();
                SqliteCommand insertCommand = new SqliteCommand
                {
                    Connection = db
                };

                string sqliteBirthday = birthday.Year + "-" + birthday.Month + "-" + birthday.Day + " 00:00:00";
                insertCommand.CommandText = "INSERT INTO birthdayTable (name, birthday) VALUES($name, $date);";
                insertCommand.Parameters.AddWithValue("$name", name);
                insertCommand.Parameters.AddWithValue("$date", sqliteBirthday);
                insertCommand.ExecuteReader();
                db.Close();
            }
        }

        public static void RemovePerson(string name)
        {
            //TODO
        }

        public static List<Person> GetPeople()
        {
            var entries = new List<Person>();

            using (SqliteConnection db = new SqliteConnection("Filename=birthday.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand("SELECT name, birthday FROM birthdayTable", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while (query.Read())
                {
                    string date = query.GetDateTime(1).ToString("MM/dd/yyyy");
                    entries.Add(new Person {Name=query.GetString(0), DateTimeBirthday=query.GetDateTime(1) , StringBirthday=date});
                }
                db.Close();
            }
            return entries;
        } 
    }
}
