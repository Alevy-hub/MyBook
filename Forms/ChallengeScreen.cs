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
			ChangeYearButtonShow();
			FillReadBooks();
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
			bool hasRows = false;
			Database databaseObject = new Database();
			SQLiteCommand checkChallenge = new SQLiteCommand("SELECT year FROM challenges WHERE year = @challengeYear", databaseObject.dbConnection);
			checkChallenge.Parameters.AddWithValue("@challengeYear", int.Parse(ChallengeYearLabel.Text.ToString()));
			databaseObject.OpenConnection();
			SQLiteDataReader result = checkChallenge.ExecuteReader();
			if (result.HasRows)
			{
				hasRows = true;
			}

			databaseObject.CloseConnection();



			if (hasRows == true)
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
			SetChallenge SetChallengeForm = new SetChallenge();
			SetChallengeForm.FormClosed += SetChallengeForm_FormClosed;
			SetChallengeForm.ShowDialog();
		}

		private void SetChallengeForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ShowSetChallengeButton();
			FillChallengeScreenBlank();
		}

		private int CheckChallengeCount()
		{
			int count = 0;
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand checkChallenge = new SQLiteCommand("SELECT count FROM challenges WHERE year = @challengeYear", databaseObject.dbConnection);
			checkChallenge.Parameters.AddWithValue("@challengeYear", int.Parse(ChallengeYearLabel.Text.ToString()));
			SQLiteDataReader result = checkChallenge.ExecuteReader();
			if (result.HasRows)
			{
				if (result.Read())
				{
					count = int.Parse(result["count"].ToString());
				}
			}
			return count; 
		}

		private void FillChallengeScreenBlank()
		{
			if (CheckIfChallengeSet())
			{
				int count = CheckChallengeCount();
				if (count != 0)
				{
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
						Book.Name = "BookBox" + i.ToString();

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
				ChallengeBoxesContainer.AutoScroll = true;
			}
		}

		private void FillReadBooks()
        {
			int readCount = 0;
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand checkCount = new SQLiteCommand("SELECT COUNT(*) FROM read_books WHERE substr(finish_date, 7) LIKE @finishYear", databaseObject.dbConnection);
			checkCount.Parameters.AddWithValue("@finishYear", int.Parse(ChallengeYearLabel.Text.ToString()));
			SQLiteDataReader result = checkCount.ExecuteReader();
			if (result.HasRows)
            {
                if (result.Read())
                {
					readCount = int.Parse(result[0].ToString());
				}
            }
			int[] rates = new int[readCount];

			SQLiteCommand checkRating = new SQLiteCommand("SELECT cast(rating as int) FROM read_books WHERE substr(finish_date, 7) LIKE @finishYear", databaseObject.dbConnection);
			checkRating.Parameters.AddWithValue("@finishYear", int.Parse(ChallengeYearLabel.Text.ToString()));
			result = checkRating.ExecuteReader();
			if (result.HasRows)
			{
				int i = 0;
				while (result.Read() && i < readCount)
				{
					rates[i] = int.Parse(result[0].ToString());
					i++;
				}
			}


			databaseObject.CloseConnection();

			int challengeCount = CheckChallengeCount();

			if(challengeCount >= readCount)
            {
				int i = 0;
				foreach(Control c in ChallengeBoxesContainer.Controls)
                {
					if(c.Name == "BookBox" + i.ToString() && i < readCount)
                    {
						int rate = rates[i];
						i++;
						if (rate == 1)
                        {
							c.BackColor = Properties.Settings.Default.color1;							
						}
						else if (rate == 2)
                        {
							c.BackColor = Properties.Settings.Default.color2;
						}
						else if (rate == 3)
                        {
							c.BackColor = Properties.Settings.Default.color3;
						}
						else if (rate == 4)
                        {
							c.BackColor = Properties.Settings.Default.color4;
						}
						else if (rate == 5)
                           {
							c.BackColor = Properties.Settings.Default.color5;
						}
                    }
                }
            }
		}

		private void ChangeYearButtonShow()
        {
			if (int.Parse(ChallengeYearLabel.Text) > DateTime.Now.Year)
			{
				IncreaseYearButton.Visible = false;
			}
			else
			{
				IncreaseYearButton.Visible = true;
			}

			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand checkYear = new SQLiteCommand("SELECT year FROM challenges WHERE year = @challengeYear", databaseObject.dbConnection);
			checkYear.Parameters.AddWithValue("@challengeYear", int.Parse(ChallengeYearLabel.Text) - 1);
			SQLiteDataReader result = checkYear.ExecuteReader();
			if (result.HasRows)
			{
				DecreaseYearButton.Visible = true;
			}
            else
            {
				DecreaseYearButton.Visible = false;
            }
			databaseObject.CloseConnection();
		}

		private void IncreaseYearButton_Click(object sender, EventArgs e)
		{
			int year = int.Parse(ChallengeYearLabel.Text) + 1;
			ChallengeYearLabel.Text = year.ToString();

			ChangeYearButtonShow();
			ClearPanel();
			FillChallengeScreenBlank();
			ShowSetChallengeButton();
		}

        private void DecreaseYearButton_Click(object sender, EventArgs e)
        {
			int year = int.Parse(ChallengeYearLabel.Text) - 1;
			ChallengeYearLabel.Text = year.ToString();

			ChangeYearButtonShow();
			ShowSetChallengeButton();
			ClearPanel();
			FillChallengeScreenBlank();
		}
    }
}
