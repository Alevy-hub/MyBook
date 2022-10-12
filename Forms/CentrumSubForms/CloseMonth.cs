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
        bool bestChosed = false;
        bool worstChosed = false;
        Book bestBook;
        Book worstBook;
        bool warningShowed = false;
        

        ConsoleLog ConsoleLog = new ConsoleLog();

        public CloseMonth()
        {
            InitializeComponent();
            ChooseMonthToClose();
            FillBestBooksGrid();
            FillWorstBooksGrid();
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
            SQLiteCommand selectBestBooks = new SQLiteCommand("SELECT id, name FROM books WHERE id IN (SELECT book_id FROM read_books WHERE strftime('%Y', finish_date) LIKE @year AND strftime('%m', finish_date) like @month AND rating LIKE (SELECT MAX(rating) FROM read_books WHERE strftime('%Y', finish_date) LIKE @year AND strftime('%m', finish_date) like @month))", databaseObject.dbConnection);
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
                        result.GetValue(1),
                        "Wybierz"
                    });
                    
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void FillWorstBooksGrid()
        {
            Database databaseObject = new Database();
            SQLiteCommand worstBestBooks = new SQLiteCommand("SELECT id, name FROM books WHERE id IN (SELECT book_id FROM read_books WHERE strftime('%Y', finish_date) LIKE @year AND strftime('%m', finish_date) like @month AND rating LIKE (SELECT MIN(rating) FROM read_books WHERE strftime('%Y', finish_date) LIKE @year AND strftime('%m', finish_date) like @month))", databaseObject.dbConnection);
            worstBestBooks.Parameters.AddWithValue("@year", year);
            worstBestBooks.Parameters.AddWithValue("@month", monthToClose);
            databaseObject.OpenConnection();
            SQLiteDataReader result = worstBestBooks.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    WorstBooksGrid.Rows.Add(new object[]
                    {
                        result.GetValue(0),
                        result.GetValue(1),
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

        private void BooksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView Grid = sender as DataGridView;

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                warningShowed = false;
                if (Grid.Name == "BestBooksGrid")
                {
                    if(bestChosed == false)
                    {
                        bestBook = new Book(Grid.Rows[e.RowIndex].Cells[0].Value.ToString(), Grid.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Grid.Rows.Clear();
                        Grid.Rows.Add(new object[]
                        {
                            bestBook.id,
                            bestBook.name,
                            "Zmień"
                        });
                        BestBooksLabel.Text = "WYBRANA NAJLEPSZA KSIĄŻKA";
                        Grid.DefaultCellStyle.BackColor = Color.FromArgb(176, 109, 84);
                        Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(176, 109, 84);
                        bestChosed = true;
                    }
                    else
                    {
                        BestBooksLabel.Text = "NAJLEPSZE KSIĄŻKI";
                        Grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 201);
                        Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 235, 201);
                        bestChosed = false;
                        Grid.Rows.Clear();
                        FillBestBooksGrid();
                    }

                }
                else if (Grid.Name == "WorstBooksGrid")
                {
                    if(worstChosed == false)
                    {
                        worstBook = new Book(Grid.Rows[e.RowIndex].Cells[0].Value.ToString(), Grid.Rows[e.RowIndex].Cells[1].Value.ToString());
                        Grid.Rows.Clear();
                        Grid.Rows.Add(new object[]
                        {
                            worstBook.id,
                            worstBook.name,
                            "Zmień"
                        });
                        WorstBooksLabel.Text = "WYBRANA NAJGORSZA KSIĄŻKA";
                        Grid.DefaultCellStyle.BackColor = Color.FromArgb(176, 109, 84);
                        Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(176, 109, 84);
                        worstChosed = true;

                    }
                    else
                    {
                        WorstBooksLabel.Text = "NAJGORSZE KSIĄŻKI";
                        Grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 201);
                        Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 235, 201);
                        worstChosed = false;
                        Grid.Rows.Clear();
                        FillWorstBooksGrid();
                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(bestChosed == true && worstChosed == true && warningShowed == true)
            {
                Database databaseObject = new Database();
                SQLiteCommand addBestWorstBooks = new SQLiteCommand("INSERT INTO month_statistics ('month', 'year', 'best_id', 'worst_id') VALUES (@month, @year, @best_id, @worst_id)", databaseObject.dbConnection);
                addBestWorstBooks.Parameters.AddWithValue("@month", monthToClose);
                addBestWorstBooks.Parameters.AddWithValue("@year", year);
                addBestWorstBooks.Parameters.AddWithValue("@best_id", bestBook.id);
                addBestWorstBooks.Parameters.AddWithValue("@worst_id", worstBook.id);
                databaseObject.OpenConnection();
                addBestWorstBooks.ExecuteNonQuery();
                this.Close();
            }
            else if(bestChosed == true && worstChosed == true && warningShowed == false)
            {
                MessageBox.Show("Upewnij się, że wybrano odpowiednie książki. Nie będzie możliwości zmiany w przyszłości!");
                warningShowed = true;
            }
            else
            {
                MessageBox.Show("Musisz wybrać najlepszą oraz najgorszą książkę w miesiącu!");
            }
        }
    }
}
