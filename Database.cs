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
				Console.WriteLine("{0}: No database", DateTime.Now.ToLongTimeString());
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
								CREATE TABLE 'year_statistics' (
									'year'	INTEGER,
									'best_id'	INTEGER NOT NULL,
									'worst_id'	INTEGER NOT NULL,
									FOREIGN KEY('best_id') REFERENCES 'read_books'('id'),
									FOREIGN KEY('worst_id') REFERENCES 'read_books'('id'),
									PRIMARY KEY('year')
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
								CREATE TABLE 'tbr'(
									'year' INTEGER NOT NULL,
									'book_id' INTEGER NOT NULL,
									PRIMARY KEY('year','book_id')
								);
								";

				SQLiteCommand createDB = new SQLiteCommand(query, databaseObject.dbConnection);
				databaseObject.OpenConnection();
				createDB.ExecuteNonQuery();
				databaseObject.CloseConnection();

				dbConnection = new SQLiteConnection("Data Source = database.db");
				if (!File.Exists("./database.db"))
				{
					Console.WriteLine("{0}: Unable to create database", DateTime.Now.ToLongTimeString());
				}
                else
                {
					Console.WriteLine("{0}: Database created", DateTime.Now.ToLongTimeString());
                }
			}
		}

		public void OpenConnection()
		{
			if (dbConnection.State != System.Data.ConnectionState.Open)
			{
				Console.WriteLine("{0}: Trying to open connection to database", DateTime.Now.ToLongTimeString());
				dbConnection.Open();

				if (dbConnection.State == System.Data.ConnectionState.Open)
                {
					Console.WriteLine("{0}: Opened connection to database", DateTime.Now.ToLongTimeString());
                }
                else
                {
					Console.WriteLine("{0}: Unable open connection to database", DateTime.Now.ToLongTimeString());
                }
			}
		}

		public void CloseConnection()
		{
			while (dbConnection.State != System.Data.ConnectionState.Closed)
			{
				Console.WriteLine("{0}: Trying to close connection to database", DateTime.Now.ToLongTimeString());
				dbConnection.Close();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				SQLiteConnection.ClearAllPools();

				if (dbConnection.State == System.Data.ConnectionState.Closed)
				{
					Console.WriteLine("{0}: Closed connection to database", DateTime.Now.ToLongTimeString());
				}
				else
				{
					Console.WriteLine("{0}: Unable to close connection to database", DateTime.Now.ToLongTimeString());
				}
			}
		}

	}
}
