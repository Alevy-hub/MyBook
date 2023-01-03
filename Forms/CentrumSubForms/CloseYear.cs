using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class CloseYear : Form
    {
        public static string yearToClose;
        public static string theWorstBookName = null;
        public static string theWorstBookId = null;
        List<Book> books = new List<Book>();
        List<Book> books2 = new List<Book>();

        public CloseYear()
        {
            InitializeComponent();
            GetBestBooks();
        }

        private void GetBestBooks()
        {
            Database databaseObject = new Database();
            SQLiteCommand GetBooks = new SQLiteCommand("SELECT ms.best_id, b.name FROM month_statistics ms LEFT JOIN books b ON ms.best_id = b.id WHERE ms.year LIKE @yearToClose", databaseObject.dbConnection);
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

        }

        private void CheckForOdd()
        {
            if(books.Count % 2 != 0)
            {
                TheWorstOfTheBest chooseWorstForm = new TheWorstOfTheBest();
                chooseWorstForm.FormClosed += chooseWorstForm_FormClosed;
                chooseWorstForm.ShowDialog();
            }
        }

        private void chooseWorstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Book theWorstBook = new Book(theWorstBookId, theWorstBookName);
            if(theWorstBook == null)
            {
                this.Close();
            }
            else
            {
                if (books.Any(worst => worst.id == theWorstBook.id))
                {
                    books.RemoveAll(worst => worst.id == theWorstBook.id);
                }
                else
                {
                    MessageBox.Show("Błąd id");
                    this.Close();
                }
            }
        }

        private void CloseYear_Paint(object sender, PaintEventArgs e)
        {
            CheckForOdd();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
