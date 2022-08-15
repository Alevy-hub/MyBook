using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

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
            checkChallenge.Parameters.AddWithValue("@challengeYear", int.Parse(ChallengeYearLabel.ToString()));
            SQLiteDataReader result = checkChallenge.ExecuteReader();
            if (result.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void SetChallengeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
