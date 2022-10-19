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
            checkYears.Parameters.AddWithValue("@year", int.Parse(ChallengeYearLabel.Text));
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
            checkYears.Parameters.AddWithValue("@year", int.Parse(ChallengeYearLabel.Text));
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
            TBRGrid.Rows.Clear();
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT name FROM books JOIN tbr on id = book_id WHERE year LIKE @year", databaseObject.dbConnection);
            FillGridQuery.Parameters.AddWithValue("@year", ChallengeYearLabel.Text);
            SQLiteDataReader result = FillGridQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    TBRGrid.Rows.Add(new object[]
                    {
                        "",
                        result.GetValue(0),
                    });
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void DecreaseYearButton_Click(object sender, EventArgs e)
        {
            ChallengeYearLabel.Text = (int.Parse(ChallengeYearLabel.Text) - 1).ToString();
            ShowChangeYearButtons();
            FillTBRGrid();
        }

        private void IncreaseYearButton_Click(object sender, EventArgs e)
        {
            ChallengeYearLabel.Text = (int.Parse(ChallengeYearLabel.Text) + 1).ToString();
            ShowChangeYearButtons();
            FillTBRGrid();
        }
    }
}
