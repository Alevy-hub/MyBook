using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MyBook.Forms.ChallengeSubForms;

namespace MyBook.forms
{
    public partial class ChallengeScreen : Form
    {
        public ChallengeScreen()
        {
            InitializeComponent();
        }

        private void ChallengeScreen_Load(object sender, EventArgs e)
        {
            ShowSetChallengeButton();
            FillChallengeScreenBlank();
        }

        private void ShowSetChallengeButton()
        {
            if (CheckIfChallengeSet())
            {
                SetChallengeButton.Visible = false;
            }
            else
            {
                SetChallengeButton.Visible = true;
            }
        }

        private bool CheckIfChallengeSet()
        {
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand checkChallenge = new SQLiteCommand("SELECT year FROM challenges WHERE year = @challengeYear", databaseObject.dbConnection);
            checkChallenge.Parameters.AddWithValue("@challengeYear", int.Parse(ChallengeYearLabel.Text.ToString()));
            SQLiteDataReader result = checkChallenge.ExecuteReader();
            if (result.HasRows)
            {
                databaseObject.CloseConnection();
                return true;
            }
            else
            {
                databaseObject.CloseConnection();
                return false;
            }
        }

        private void SetChallengeButton_Click(object sender, EventArgs e)
        {
            SetChallenge SetChallengeForm = new SetChallenge();
            SetChallengeForm.ShowDialog();
        }

        private void FillChallengeScreenBlank()
        {
            if (CheckIfChallengeSet())
            {
                Database databaseObject = new Database();
                databaseObject.OpenConnection();
                SQLiteCommand checkChallenge = new SQLiteCommand("SELECT count FROM challenges WHERE year = @challengeYear", databaseObject.dbConnection);
                checkChallenge.Parameters.AddWithValue("@challengeYear", int.Parse(ChallengeYearLabel.Text.ToString()));
                SQLiteDataReader result = checkChallenge.ExecuteReader();
                if (result.HasRows)
                {
                    int count = 0;
                    //MessageBox.Show("t");
                    if (result.Read())
                    {
                        count = int.Parse(result["count"].ToString());
                    }

                    int row = 0;
                    int column = 0;
                    for (int i = 0; i < count; i++)
                    {
                        Panel Book = new Panel();
                        ChallengeBoxesContainer.Controls.Add(Book);
                        Book.Top = row * 105;
                        Book.Left = column * 105;
                        Book.BorderStyle = BorderStyle.FixedSingle;
                        Book.Height = 100;
                        Book.Width = 100;

                        column++;
                        if (column == 10)
                        {
                            column = 0;
                            row++;
                        }
                    }
                }
                databaseObject.CloseConnection();
            }
        }
    }
}
