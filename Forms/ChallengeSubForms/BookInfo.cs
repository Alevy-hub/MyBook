using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MyBook.forms;

namespace MyBook.Forms.ChallengeSubForms
{
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
            FillDetails();
        }

        private void FillDetails()
        {
            int bookId = 0;
            int authorId = 0;
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand checkReadDetails = new SQLiteCommand("SELECT book_id, start_date, finish_date, rating, form, comment FROM read_books WHERE id = @readId", databaseObject.dbConnection);
            checkReadDetails.Parameters.AddWithValue("@readId", ChallengeScreen.readBookId);
            SQLiteDataReader result = checkReadDetails.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    bookId = int.Parse(result["book_id"].ToString());
                    StartDateLabel.Text = result["start_date"].ToString();
                    EndDateLabel.Text = result["finish_date"].ToString();
                    RateLabel.Text = result["rating"].ToString();
                    FormLabel.Text = result["form"].ToString();
                    CommentBox.Text = result["comment"].ToString();
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
                    TitleLabel.Text = result["name"].ToString();
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
    }
}
