using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MyBook.Forms.ChallengeSubForms
{
    public partial class SetChallenge : Form
    {
        public SetChallenge()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
            if (IsYearGood() && IsCountGood())
            {
                MessageBox.Show("2");
                Database databaseObject = new Database();
                MessageBox.Show("3");
                SQLiteCommand addChallenge = new SQLiteCommand("INSERT INTO challenges VALUES (@year, @count)", databaseObject.dbConnection);
                addChallenge.Parameters.AddWithValue("@year", YearNumeric.Value);
                addChallenge.Parameters.AddWithValue("@count", CountNumeric.Value);
                databaseObject.OpenConnection();
                MessageBox.Show("5");
                addChallenge.ExecuteNonQuery();
                MessageBox.Show("4");
                databaseObject.CloseConnection();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wprowadź poprawne wartości!");
            }

        }

        private bool IsYearGood()
        {
            if (YearNumeric.Value < 2000 || YearNumeric.Value > 3000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsCountGood()
        {
            if (CountNumeric.Value < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
