using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class CloseMonth : Form
    {
        string monthToClose;
        string year;

        ConsoleLog ConsoleLog = new ConsoleLog();

        public CloseMonth()
        {
            InitializeComponent();
            ChooseMonthToClose();
            FillBestBooksGrid();
        }

        private void ChooseMonthToClose()
        {
            Database databaseObject = new Database();
            SQLiteCommand checkYear = new SQLiteCommand("SELECT DISTINCT strftime('%Y', finish_date) AS year FROM read_books WHERE year NOT IN (SELECT DISTINCT year FROM year_statistics) ORDER BY year ASC LIMIT 1", databaseObject.dbConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkYear.ExecuteReader();
            if (result.HasRows)
            {
                while(result.Read())
                {
                    year = result[0].ToString();
                    ConsoleLog.Log(year);
                }
            }
            result.Close();
            databaseObject.CloseConnection();

            SQLiteCommand checkMonth = new SQLiteCommand("SELECT DISTINCT strftime('%m', finish_date) AS month FROM read_books WHERE month NOT IN (SELECT DISTINCT month FROM month_statistics WHERE year LIKE @year) AND strftime('%Y', finish_date) like @year ORDER BY month ASC LIMIT 1", databaseObject.dbConnection);
            checkMonth.Parameters.AddWithValue("@year", year);
            databaseObject.OpenConnection();
            result = checkMonth.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    monthToClose = result[0].ToString();
                    ConsoleLog.Log(monthToClose);
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void FillBestBooksGrid()
        {
            Database databaseObject = new Database();
            SQLiteCommand selectBestBooks = new SQLiteCommand("SELECT name FROM books WHERE id IN (SELECT book_id FROM read_books WHERE strftime('%Y', finish_date) LIKE @year AND strftime('%m', finish_date) like @month AND rating LIKE (SELECT MAX(rating) FROM read_books WHERE strftime('%Y', finish_date) LIKE @year AND strftime('%m', finish_date) like @month))", databaseObject.dbConnection);
            selectBestBooks.Parameters.AddWithValue("@year", year);
            selectBestBooks.Parameters.AddWithValue("@month", monthToClose);
            databaseObject.OpenConnection();
            SQLiteDataReader result = selectBestBooks.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    BestBooksGrid.Rows.Add(new object[]
                    {
                        result.GetValue(0),
                        "Wybierz"
                    });
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
