using MyBook.Forms.CentrumSubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace MyBook.forms
{
    public partial class TBRScreen : Form
    {
        public TBRScreen()
        {
            InitializeComponent();
            ShowChangeYearButtons();
            FillTBRGrid();         
        }

        private void ShowChangeYearButtons()
        {


            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand checkYears = new SQLiteCommand("SELECT year FROM tbr WHERE year > @year", databaseObject.dbConnection);
            checkYears.Parameters.AddWithValue("@year", int.Parse(YearLabel.Text));
            SQLiteDataReader result = checkYears.ExecuteReader();
            if (result.HasRows)
            {
                IncreaseYearButton.Visible = true;
            }
            else
            {
                IncreaseYearButton.Visible = false;
            }
            result.Close();
            databaseObject.CloseConnection();

            databaseObject.OpenConnection();
            checkYears = new SQLiteCommand("SELECT year FROM tbr WHERE year < @year", databaseObject.dbConnection);
            checkYears.Parameters.AddWithValue("@year", int.Parse(YearLabel.Text));
            result = checkYears.ExecuteReader();
            if (result.HasRows)
            {
                DecreaseYearButton.Visible = true;
            }
            else
            {
                DecreaseYearButton.Visible = false;
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void FillTBRGrid()
        {
            string read = "";
            TBRGrid.Rows.Clear();
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT name, is_read, id FROM books JOIN tbr on id = book_id WHERE year LIKE @year", databaseObject.dbConnection);
            FillGridQuery.Parameters.AddWithValue("@year", YearLabel.Text);
            SQLiteDataReader result = FillGridQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if(result[1].ToString() == "1")
                    {
                        read = "X";
                    }
                    else
                    {
                        read = "";
                    }

                    TBRGrid.Rows.Add(new object[]
                    {
                        read,
                        result.GetValue(0),
                        result.GetValue(2)
                    });
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void DecreaseYearButton_Click(object sender, EventArgs e)
        {
            YearLabel.Text = (int.Parse(YearLabel.Text) - 1).ToString();
            ShowChangeYearButtons();
            FillTBRGrid();
        }

        private void IncreaseYearButton_Click(object sender, EventArgs e)
        {
            YearLabel.Text = (int.Parse(YearLabel.Text) + 1).ToString();
            ShowChangeYearButtons();
            FillTBRGrid();
        }

        private void TBRGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string isRead = "";
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {

                if (TBRGrid.Rows[e.RowIndex].Cells[0].Value.ToString() == "X")
                {
                    isRead = "0";

                }
                else
                {
                    isRead = "1";
                    DialogResult dialogResult = MessageBox.Show("Czy chcesz dodać książkę jako przeczytaną?", "TBR", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AddBook.fromWhere = "tbr";
                        AddBook.bookId = TBRGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                        AddBook addBook = new AddBook();
                        addBook.ShowDialog();
                    }
                }

                Database databaseObject = new Database();
                SQLiteCommand updateReadBook = new SQLiteCommand("UPDATE tbr SET is_read = @isRead WHERE book_id = @bookId AND year = @year", databaseObject.dbConnection);
                updateReadBook.Parameters.AddWithValue("@isRead", isRead);
                updateReadBook.Parameters.AddWithValue("@bookId", TBRGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
                updateReadBook.Parameters.AddWithValue("@year", YearLabel.Text);
                databaseObject.OpenConnection();
                updateReadBook.ExecuteNonQuery();
                databaseObject.CloseConnection();

                FillTBRGrid();
            }
        }
    }
}
