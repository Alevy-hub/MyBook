using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class CloseYear : Form
    {
        public static string yearToClose;

        public CloseYear()
        {
            InitializeComponent();
            CloseYearLadder();
        }

        private void CloseYearLadder()
        {
            List<Book> books = new List<Book>();
            List<Book> books2 = new List<Book>();

            Database databaseObject = new Database();
            SQLiteCommand GetBooks = new SQLiteCommand("SELECT ms.best_id, b.name FROM month_statistics ms JOIN books b WHERE ms.year LIKE @yearToClose", databaseObject.dbConnection);
            GetBooks.Parameters.AddWithValue("@yearToClose", yearToClose);
            databaseObject.OpenConnection();
            SQLiteDataReader result = GetBooks.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    books.Add(new Book(result[0].ToString(), result[1].ToString()));
                }
            }
            result.Close();
            databaseObject.CloseConnection();

            Book1Button.Text = books[1].name.ToString();
            Book2Button.Text = books[2].name.ToString();
        }
    }
}
