using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MyBook.forms;
using System.Runtime.InteropServices;

namespace MyBook.Forms.ChallengeSubForms
{
    public partial class BookInfo : Form
    {
        public static string fromWhere;
        public static string readBookId;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public BookInfo()
        {
            InitializeComponent();
            FillDetails();
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FillDetails()
        {
            int bookId = 0;
            int authorId = 0;
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand checkReadDetails = new SQLiteCommand("SELECT book_id, start_date, finish_date, rating, form, comment FROM read_books WHERE id = @readId", databaseObject.dbConnection);
            checkReadDetails.Parameters.AddWithValue("@readId", readBookId);
            SQLiteDataReader result = checkReadDetails.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    bookId = int.Parse(result["book_id"].ToString());
                    StartDateLabel.Text = DateTime.Parse(result["start_date"].ToString()).ToString("dd.MM.yyyy");
                    EndDateLabel.Text = DateTime.Parse(result["finish_date"].ToString()).ToString("dd.MM.yyyy");
                    FormLabel.Text = result["form"].ToString();
                    CommentBox.Text = result["comment"].ToString();
                    if (result["rating"].ToString() != "0")
                    {
                        RateLabel.Text = result["rating"].ToString();
                    }
                    else
                    {
                        RateLabel.Font = new Font("Segoe UI", 15);
                        RateLabel.Text = "Brak oceny";
                    }
                }
            }
            databaseObject.CloseConnection();

            databaseObject.OpenConnection();
            SQLiteCommand checkBookDetails = new SQLiteCommand("SELECT author_id, name, genre, pages FROM books WHERE id = @bookId", databaseObject.dbConnection);
            checkBookDetails.Parameters.AddWithValue("@bookId", bookId);
            result = checkBookDetails.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    authorId = int.Parse(result["author_id"].ToString());
                    if (result["name"].ToString().Length < 22)
                    {
                        TitleLabel.Text = result["name"].ToString();
                    }
                    else if (result["name"].ToString().Length < 63)
                    {
                        TitleLabel.Font = new Font("Segoe UI", 18);
                        TitleLabel.Text = result["name"].ToString();
                    }
                    else
                    {
                        TitleLabel.Font = new Font("Segoe UI", 14);
                        TitleLabel.Text = result["name"].ToString();
                    }
                    GenreLabel.Text = result["genre"].ToString();
                    PageCount.Text = result["pages"].ToString();
                }
            }
            databaseObject.CloseConnection();


            databaseObject.OpenConnection();
            SQLiteCommand checkAuthorDetails = new SQLiteCommand("SELECT name FROM authors WHERE id = @authorId", databaseObject.dbConnection);
            checkAuthorDetails.Parameters.AddWithValue("@authorId", authorId);
            result = checkAuthorDetails.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    AuthorLabel.Text = result["name"].ToString();
                }
            }
            databaseObject.CloseConnection();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommentBox_Enter(object sender, EventArgs e)
        {
            TitleLabel.Focus();
        }
    }
}
