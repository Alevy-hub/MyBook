using System.Data.SQLite;
using System.IO;

namespace MyBook
{
    class Database
    {
        public SQLiteConnection dbConnection;

        public Database()
        {
            dbConnection = new SQLiteConnection("Data Source = database.db");
            if (!File.Exists("./database.db"))
            {
                SQLiteConnection.CreateFile("database.db");

                Database databaseObject = new Database();
                string query = "CREATE TABLE 'books' ('id' INTEGER,'name' TEXT NOT NULL UNIQUE, 'author_id' TEXT, 'genre' INTEGER, 'pages' INTEGER, PRIMARY KEY('id' AUTOINCREMENT)); ";
            }
        }

    }
}
