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
    public partial class TheWorstOfTheBest : Form
    {
        bool worstChosed = false;
        Book worstBook;

        public TheWorstOfTheBest()
        {
            InitializeComponent();
            CloseYear.theWorstBookId = null;
            CloseYear.theWorstBookName = null;
            FillBestBooksGrid();
        }

        private void FillBestBooksGrid()
        {
            Database databaseObject = new Database();
            SQLiteCommand GetBooks = new SQLiteCommand("SELECT ms.best_id, b.name FROM month_statistics ms LEFT JOIN books b ON ms.best_id = b.id WHERE ms.year LIKE @yearToClose", databaseObject.dbConnection);
            GetBooks.Parameters.AddWithValue("@yearToClose", CloseYear.yearToClose);
            databaseObject.OpenConnection();
            SQLiteDataReader result = GetBooks.ExecuteReader();
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

        private void BestBooksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView Grid = sender as DataGridView;

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                if (worstChosed == false)
                {
                    worstBook = new Book(Grid.Rows[e.RowIndex].Cells[0].Value.ToString(), Grid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Grid.Rows.Clear();
                    Grid.Rows.Add(new object[]
                    {
                        worstBook.id,
                        worstBook.name,
                        "Zmień"
                    });
                    topLabel.Text = "WYBRANA NAJGORSZA KSIĄŻKA";
                    Grid.DefaultCellStyle.BackColor = Color.FromArgb(176, 109, 84);
                    Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(176, 109, 84);
                    worstChosed = true;
                }
                else
                {
                    topLabel.Text = "WYBIERZ NAJGORSZĄ KSIĄŻKĘ";
                    Grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 201);
                    Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 235, 201);
                    worstChosed = false;
                    Grid.Rows.Clear();
                    FillBestBooksGrid();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(worstChosed == true)
            {
                CloseYear.theWorstBookId = worstBook.id;
                CloseYear.theWorstBookName = worstBook.name;
                this.Close();
            }
            else
            {
                MessageBox.Show("Musisz najpierw wybrać najgorszą książkę");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
