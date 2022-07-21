using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class AddBook : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public AddBook()
        {
            InitializeComponent();
            FillComboBoxes();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FillComboBoxes()
        {
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand FillComboBoxQuery = new SQLiteCommand("SELECT name from books", databaseObject.dbConnection);
            SQLiteDataReader result = FillComboBoxQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    TitleComboBox.Items.Add(
                    
                        result.GetValue(0)
                    );
                }
            }

            FillComboBoxQuery = new SQLiteCommand("SELECT name from authors", databaseObject.dbConnection);
            result = FillComboBoxQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    AuthorComboBox.Items.Add(

                        result.GetValue(0)
                    );
                }
            }

            FillComboBoxQuery = new SQLiteCommand("SELECT DISTINCT genre from books", databaseObject.dbConnection);
            result = FillComboBoxQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    GenreComboBox.Items.Add(

                        result.GetValue(0)
                    );
                }
            }

            databaseObject.CloseConnection();
        }

        private void StatusRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (CzytamRadio.Checked == true)
            {
                StartDatePicker.Enabled = true;
                FinishDatePicker.Enabled = false;
            }
            else if (TBRRadio.Checked == true)
            {
                StartDatePicker.Enabled = false;
                FinishDatePicker.Enabled = false;
            }
            else if (UkonczoneRadio.Checked)
            {
                StartDatePicker.Enabled = true;
                FinishDatePicker.Enabled = true;
            }
            StatusAlertLabel.Visible = false;
        }

        private void FormRadio_CheckedChanged(object sender, EventArgs e)
        {
            FormAlertLabel.Visible = false;
        }

        private void CheckRadioButtons()
        {
            if (PapierRadio.Checked == false && EbookRadio.Checked == false && AudiobookRadio.Checked == false)
            {
                FormAlertLabel.Visible = true;
            }

            if (CzytamRadio.Checked == false && TBRRadio.Checked == false && UkonczoneRadio.Checked == false)
            {
                StatusAlertLabel.Visible = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CheckRadioButtons();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
