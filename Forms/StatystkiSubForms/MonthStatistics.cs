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

		public MonthStatistics()
        {
            InitializeComponent();
			countRead();
        }

        private void countRead()
        {
			int count = 0;
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
					count = int.Parse(result[0].ToString());
				}
			}
			result.Close();
			databaseObject.CloseConnection();
			MessageBox.Show(count.ToString());
		}

        private void CloseButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
