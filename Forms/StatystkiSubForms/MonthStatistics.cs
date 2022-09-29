using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MyBook.Forms.StatystkiSubForms
{
    public partial class MonthStatistics : Form
    {
		public static string statYear;
		public static string statMonth;
		int readCount;

		public MonthStatistics()
        {
            InitializeComponent();
			countRead();
			PrevMonthCount();

		}

        private void countRead()
        {
			Database databaseObject = new Database();
			SQLiteCommand checkCount = new SQLiteCommand("SELECT COUNT(*) FROM read_books WHERE strftime('%Y', finish_date) LIKE @finishYear AND strftime('%m', finish_date) LIKE @finishMonth", databaseObject.dbConnection);
			checkCount.Parameters.AddWithValue("@finishYear", statYear);
			checkCount.Parameters.AddWithValue("@finishMonth", statMonth);
			databaseObject.OpenConnection();
			SQLiteDataReader result = checkCount.ExecuteReader();
			if (result.HasRows)
			{
				if (result.Read())
				{
					readCount = int.Parse(result[0].ToString());
				}
			}
			result.Close();
			databaseObject.CloseConnection();

			if(readCount > 1 && readCount < 5)
            {
				BooksLabel.Text = "KSIĄŻKI";
            }
			else if(readCount == 1)
            {
				BooksLabel.Text = "KSIĄŻKĘ";
            }
            else
            {
				BooksLabel.Text = "KSIĄŻEK";
			}

			ReadCountLabel.Text = readCount.ToString();
		}

		private void PrevMonthCount()
        {
			int prevCount = 0;
			int prevMonth = int.Parse(statMonth)-1;
			string prevMonthText;
			string year;
			if(prevMonth < 10 && prevMonth > 0)
            {
				prevMonthText = "0" + prevMonth.ToString();
				year = statYear;
            }
			else if(prevMonth > 9)
            {
				prevMonthText = prevMonth.ToString();
				year = statYear;
			}
            else
            {
				prevMonthText = "12";
				int helpYear = int.Parse(statYear) - 1;
				year = helpYear.ToString();
			}

			MessageBox.Show(prevMonthText);


            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT COUNT(*) FROM read_books WHERE strftime('%Y', finish_date) LIKE @finishYear AND strftime('%m', finish_date) LIKE @prevMonth", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", prevMonthText);
            checkCount.Parameters.AddWithValue("@prevMonth", year);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    prevCount = int.Parse(result[0].ToString());
                }
            }
            result.Close();
            databaseObject.CloseConnection();

			prevCount = readCount - prevCount;

			if(prevCount < 0)
			{
				prevCount = -prevCount;
				MoreLessPrevLabel.Text = "MNIEJ NIŻ W POPRZEDNIM MIESIĄCU";
			}
			else
			{
				MoreLessPrevLabel.Text = "WIĘCEJ NIŻ W POPRZEDNIM MIESIĄCU";
			}

			PrevMonthLabel.Text = prevCount.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
