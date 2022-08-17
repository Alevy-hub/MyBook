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

			ChallengeYearLabel.Text = DateTime.Now.Year.ToString();
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

		private void ClearPanel()
        {
			int count = 1;

            while (count > 0)
            {
				foreach(Control item in ChallengeBoxesContainer.Controls)
				{
					if(item.GetType() != typeof(Button))
                    {
						item.Dispose();
                    }
				}
				count = 0;
				foreach (Control item in ChallengeBoxesContainer.Controls)
				{
					if (item.GetType() != typeof(Button))
					{
						count++;
					}
				}
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
			SetChallengeForm.FormClosed += SetChallengeForm_FormClosed;
			SetChallengeForm.ShowDialog();
		}

		private void SetChallengeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ShowSetChallengeButton();
			FillChallengeScreenBlank();
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
						Book.Left = column * 105 + 20;
						Book.BorderStyle = BorderStyle.FixedSingle;
						Book.Height = 100;
						Book.Width = 100;

						Label Number = new Label();
						Book.Controls.Add(Number);
						Number.Dock = DockStyle.Fill;
						int countForLabel = i + 1;
						Number.Text = countForLabel.ToString();
						Number.TextAlign = ContentAlignment.MiddleCenter;
						Number.Font = new Font("Segoe UI", 30, FontStyle.Bold);


						column++;
						if (column == 10)
						{
							column = 0;
							row++;
						}
					}
				}
				databaseObject.CloseConnection();
				ChallengeBoxesContainer.AutoScroll = true;
			}
		}

		private void IncreaseYearButton_Click(object sender, EventArgs e)
		{
			int year = int.Parse(ChallengeYearLabel.Text) + 1;
			if(year > DateTime.Now.Year)
			{
				IncreaseYearButton.Visible = false;
			}
			else
			{
				IncreaseYearButton.Visible = true;
			}
			ChallengeYearLabel.Text = year.ToString();
			ClearPanel();
			FillChallengeScreenBlank();
			ShowSetChallengeButton();
		}

        private void DecreaseYearButton_Click(object sender, EventArgs e)
        {
			int year = int.Parse(ChallengeYearLabel.Text) - 1;

			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand checkYear = new SQLiteCommand("SELECT year FROM challenges WHERE year = @challengeYear", databaseObject.dbConnection);
			checkYear.Parameters.AddWithValue("@challengeYear", year);
			SQLiteDataReader result = checkYear.ExecuteReader();
			if (result.HasRows)
            {
				ChallengeYearLabel.Text = year.ToString();
			}

		}
    }
}
