using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MyBook.Forms.CentrumSubForms;

namespace MyBook.forms
{
    public partial class CentrumScreen : Form
    {

        public static string readId;
        public CentrumScreen()
        {
            InitializeComponent();
            FillAktualnieCzytaneGrid();
        }

        private void TestFillDb_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();
            string query = @"INSERT INTO authors ('name') VALUES ('Andrzej Sapkowski'), ('Stephen King'), ('J.K Rowling'), ('Dennis Lehane'), ('Hania Czaban');
                            INSERT INTO books ('name', 'author_id', 'genre', 'pages', 'time') VALUES ('Krew Elfów','1','Fantasy','400',null), ('Podpalaczka','2','Thriller','600','1530'), ('Harry Potter i Więzien Azkabanu','3','Fantasy','356',null), ('Wyspa Tajemnic','4','Thriller','340',null), ('Cały ten czas','5','Fantasy','532',null);
                            INSERT INTO read_books ('book_id', 'start_date', 'finish_date', 'rating', 'form') VALUES ('1','2022-01-22','2022-01-25','5','papier'), ('2','2022-03-03',NULL,NULL,'audiobook'), ('3','2022-04-14','2022-05-09','3.4','ebook'), ('4','2022-06-24',NULL,NULL,'ebook'), ('5','2022-07-04','2022-07-20','3.5','papier')";
            SQLiteCommand newQuery = new SQLiteCommand(query, databaseObject.dbConnection);
            databaseObject.OpenConnection();
            newQuery.ExecuteNonQuery();
            databaseObject.CloseConnection();
        }

        public void FillAktualnieCzytaneGrid()
        {
            AktualnieCzytaneGrid.Columns[1].DefaultCellStyle.Format = "dd.MM.yyyy";
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT b.name, rb.start_date from books b join read_books rb on b.id = rb.book_id where rb.start_date not null and rb.finish_date is null", databaseObject.dbConnection);
            SQLiteDataReader result = FillGridQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    AktualnieCzytaneGrid.Rows.Add(new object[]
                    {
                        result.GetValue(0),
                        DateTime.ParseExact((string)result.GetValue(1), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        "Zakończ",
                        "Usuń"
                    });
                }
            }
            databaseObject.CloseConnection();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            AddBook AddBookForm = new AddBook();
            AddBookForm.FormClosed += AddBookForm_FormClosed;
            AddBookForm.ShowDialog();
        }

        private void AddBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AktualnieCzytaneGrid.Rows.Clear();
            FillAktualnieCzytaneGrid();
        }

        private void AktualnieCzytaneGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                Database databaseObject = new Database();
                databaseObject.OpenConnection();
                SQLiteCommand checkReadId = new SQLiteCommand("SELECT id FROM read_books WHERE book_id = (SELECT id FROM books where name = @bookName) and start_date = @startDate", databaseObject.dbConnection);
                checkReadId.Parameters.AddWithValue("@bookName", AktualnieCzytaneGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                DateTime startDate = (DateTime)AktualnieCzytaneGrid.Rows[e.RowIndex].Cells[1].Value;
                checkReadId.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));

                SQLiteDataReader result = checkReadId.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        readId = result.GetValue("id").ToString();
                    }
                }
                databaseObject.CloseConnection();
            }

            if (e.ColumnIndex == 2)
            {

                FinishBook FinishBookForm = new FinishBook();
                FinishBookForm.FormClosed += AddBookForm_FormClosed;
                FinishBookForm.ShowDialog();
            }

            if (e.ColumnIndex == 3)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć książkę z aktualnie czytanych?", "Usuń książkę", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        Database databaseObject = new Database();
                        databaseObject.OpenConnection();
                        SQLiteCommand deleteFromRead = new SQLiteCommand("DELETE FROM read_books WHERE id = @readBookId", databaseObject.dbConnection);
                        deleteFromRead.Parameters.AddWithValue("@readBookId", readId);
                        deleteFromRead.ExecuteNonQuery();
                        databaseObject.CloseConnection();

                        AktualnieCzytaneGrid.Rows.Clear();
                        FillAktualnieCzytaneGrid();
                        break;
                    case DialogResult.No:
                        break;
                }
            }
        }
    }
}
