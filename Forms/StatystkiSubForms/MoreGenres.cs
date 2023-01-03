using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBook.Forms.StatystkiSubForms
{
    public partial class MoreGenres : Form
    {
        public static string fromWhere;
        public static string genreYear;
        public static string genreMonth;

        public MoreGenres()
        {
            InitializeComponent();
            FillTable();
            fromWhere = "";
        }

        private void FillTable()
        {
            SQLiteDataReader result = null;
            Database databaseObject = new Database();
            if(fromWhere == "month")
            {
                SQLiteCommand checkCount = new SQLiteCommand("SELECT genre, COUNT(*) as countBooks FROM (SELECT rb.book_id, b.genre FROM read_books rb LEFT JOIN books b ON rb.book_id = b.id WHERE strftime('%Y', finish_date) LIKE @finishYear AND strftime('%m', finish_date) LIKE @finishMonth) GROUP BY genre ORDER BY countBooks DESC", databaseObject.dbConnection);
                checkCount.Parameters.AddWithValue("@finishYear", genreYear);
                checkCount.Parameters.AddWithValue("@finishMonth", genreMonth);
                databaseObject.OpenConnection();
                result = checkCount.ExecuteReader();
            }
            else if(fromWhere == "year")
            {
                SQLiteCommand checkCount = new SQLiteCommand("SELECT genre, COUNT(*) as countBooks FROM (SELECT rb.book_id, b.genre FROM read_books rb LEFT JOIN books b ON rb.book_id = b.id WHERE strftime('%Y', finish_date) LIKE @finishYear) GROUP BY genre ORDER BY countBooks DESC", databaseObject.dbConnection);
                checkCount.Parameters.AddWithValue("@finishYear", genreYear);
                databaseObject.OpenConnection();
                result = checkCount.ExecuteReader();
            }

            if(result.HasRows)
            {
                while(result.Read())
                {
                    GenresGrid.Rows.Add(new object[]
                    {
                        result.GetValue(0),
                        result.GetValue(1)
                    });
                }
            }
            result.Close();
            databaseObject.CloseConnection();
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
