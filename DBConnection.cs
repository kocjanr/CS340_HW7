using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Homework7_GUI
{
    class DBConnection {

        private SQLiteConnection _db;

        public DBConnection() { 
            _db = new SQLiteConnection("Data Source=D://Projects//Homework7_GUI//Homework7_GUI//homework07.sqlite3.db; Version=3;");
        }

        private void CloseDatabase() {
            _db.Close();
        }
        
        public void SQLTest(string sql) {
            _db.Open();
            SQLiteCommand command = new SQLiteCommand(sql, _db);
            command.ExecuteNonQuery();
            CloseDatabase();
        }

        public void ExecuteSelectQuery(string sql, string tableName) {
            _db.Open();
            SQLiteCommand command = new SQLiteCommand(sql, _db);
            command.ExecuteNonQuery();
            SQLiteDataReader reader = command.ExecuteReader();

            DisplayQuery(reader, tableName);

            CloseDatabase();
        }

        public void ExecuteInsertQuery(string tableName, string value, string column) {
            string sql = "INSERT INTO " + tableName + "(" + column + ") VALUES ('" + value + "');" ;
            _db.Open();
            SQLiteCommand command = new SQLiteCommand(sql, _db);
            command.ExecuteNonQuery();
            CloseDatabase();
        }

        public void DeleteEntry(string id, string table) {
            string sql = "DELETE FROM " + table + " WHERE id= " + id + ";";
            _db.Open();
            SQLiteCommand command = new SQLiteCommand(sql, _db);
            command.ExecuteNonQuery();
            CloseDatabase();
        }

        public void EditRecord(string id, string table, string column) {

        }

        private void DisplayQuery(SQLiteDataReader reader, string tableName) {

            switch (tableName) {
                case "colors":
                    while (reader.Read()) { 
                        Console.WriteLine("Id: " + reader["id"] + " Color: " + reader["name"]);
                    }
                    break;
                case "teams":
                    while (reader.Read()) { 
                        Console.WriteLine("Id: " + reader["id"] + " Team: " + reader["name"]);
                    }
                    break;
                case "powers":
                    while (reader.Read()) { 
                        Console.WriteLine("Id: " + reader["id"] + " Power: " + reader["name"]);
                    }
                    break;
                case "superheroes":
                    while (reader.Read()) { 
                        Console.WriteLine("Id: " + reader["id"] + " Name: " + reader["name"] + "Villain: " + reader["villain_id"] + "Team: " + reader["team_id"]);
                    }
                    break;
                case "villains":
                    while (reader.Read()) { 
                        Console.WriteLine("Id: " + reader["id"] + " Name: " + reader["name"]);
                    }
                    break;
            }

        }
    }
}