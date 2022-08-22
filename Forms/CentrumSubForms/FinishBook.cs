using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using MyBook.forms;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class FinishBook : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FinishBook()
        {
            InitializeComponent();
            StartDatePicker.Format = DateTimePickerFormat.Custom;
            StartDatePicker.CustomFormat = "dd.MM.yyyy";
            FinishDatePicker.Format = DateTimePickerFormat.Custom;
            FinishDatePicker.CustomFormat = "dd.MM.yyyy";
            FillStartDate();
        }

        private void FillStartDate()
        {
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand FillStartDate = new SQLiteCommand("SELECT start_date FROM read_books WHERE id = @readBookId", databaseObject.dbConnection);
            FillStartDate.Parameters.AddWithValue("@readBookId", CentrumScreen.readId);
            SQLiteDataReader result = FillStartDate.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    StartDatePicker.Value = DateTime.ParseExact((string)result["start_date"], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                }

            }
            databaseObject.CloseConnection();
        }

        private bool CheckDates()
        {
            if (StartDatePicker.Value > FinishDatePicker.Value)
            {
                DateAlertLabel.Visible = true;
                return false;
            }
            else
            {
                DateAlertLabel.Visible = false;
            }

            if (FinishDatePicker.Value > DateTime.Now || StartDatePicker.Value > DateTime.Now)
            {
                FutureDateAlertLabel.Visible = true;
                return false;
            }
            else
            {
                FutureDateAlertLabel.Visible = false;
            }

            return true;
        }

        private void UpdateBook()
        {
            Database databaseObject = new Database();
            SQLiteCommand updateReadBook = new SQLiteCommand("UPDATE read_books SET start_date = @startDate, finish_date = @finishDate, rating = @rating WHERE id = @readBookId", databaseObject.dbConnection);
            updateReadBook.Parameters.AddWithValue("@startDate", StartDatePicker.Value.ToString("yyyy-MM-dd"));
            updateReadBook.Parameters.AddWithValue("@finishDate", FinishDatePicker.Value.ToString("yyyy-MM-dd"));
            updateReadBook.Parameters.AddWithValue("@rating", (double)RatingNumeric.Value);
            updateReadBook.Parameters.AddWithValue("@readBookId", CentrumScreen.readId);
            databaseObject.OpenConnection();
            updateReadBook.ExecuteNonQuery();
            databaseObject.CloseConnection();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckDates())
            {
                UpdateBook();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void NoRateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRateCheckBox.Checked)
            {
                RatingNumeric.Enabled = false;
                RatingNumeric.Minimum = 0;
                RatingNumeric.Value = 0;
            }
            else
            {
                RatingNumeric.Enabled = true;
                RatingNumeric.Minimum = 1;
                RatingNumeric.Value = 1;
            }
        }
    }
}
