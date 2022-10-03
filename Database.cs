using System;
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
				string query = @"CREATE TABLE 'authors' (
									'id'	INTEGER,
									'name'	TEXT NOT NULL UNIQUE,
									PRIMARY KEY('id' AUTOINCREMENT)
								);
								CREATE TABLE 'books' (
									'id'	INTEGER,
									'name'	TEXT NOT NULL UNIQUE,
									'author_id'	INTEGER,
									'genre'	TEXT NOT NULL,
									'pages'	INTEGER,
									'time'	INTEGER,
									FOREIGN KEY('author_id') REFERENCES 'authors'('id'),
									PRIMARY KEY('id' AUTOINCREMENT)
								);
								CREATE TABLE 'month_statistics' (
									'month'	INTEGER,
									'year'	INTEGER,
									'best_id'	INTEGER NOT NULL,
									'worst_id'	INTEGER NOT NULL,
									FOREIGN KEY('best_id') REFERENCES 'read_books'('id'),
									FOREIGN KEY('worst_id') REFERENCES 'read_books'('id'),
									PRIMARY KEY('month','year')
								);
								CREATE TABLE 'read_books' (
									'id'	INTEGER,
									'book_id'	INTEGER NOT NULL,
									'start_date'	TEXT NOT NULL,
									'finish_date'	TEXT,
									'rating'	REAL,
									'form'	TEXT NOT NULL,
									'comment' TEXT,
									FOREIGN KEY('book_id') REFERENCES 'books'('id'),
									PRIMARY KEY('id' AUTOINCREMENT)
								);
								CREATE TABLE 'challenges'(
									'year'	INTEGER NOT NULL,
									'count' INTEGER NOT NULL,
									PRIMARY KEY('year')
								);
								";

				SQLiteCommand createDB = new SQLiteCommand(query, databaseObject.dbConnection);
				databaseObject.OpenConnection();
				createDB.ExecuteNonQuery();
				databaseObject.CloseConnection();
			}
		}

		public void OpenConnection()
		{
			if (dbConnection.State != System.Data.ConnectionState.Open)
			{
				dbConnection.Open();
			}
		}

		public void CloseConnection()
		{
			while (dbConnection.State != System.Data.ConnectionState.Closed)
			{
				dbConnection.Close();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				SQLiteConnection.ClearAllPools();
				
			}
		}

	}
}
