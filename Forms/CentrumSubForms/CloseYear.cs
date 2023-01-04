using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class CloseYear : Form
    {
        public static string yearToClose;
        public static string theWorstBookName = null;
        public static string theWorstBookId = null;
        string mode = "best";
        string button1ID = null;
        string button2ID = null;
        string button1Name = null;
        string button2Name= null;
        Book ChosenBook;
        Book UnchosenBook;
        bool isChosen = false;
        public static List<Book> books = new List<Book>();
        List<Book> books2 = new List<Book>();

        public CloseYear()
        {
            InitializeComponent();
            GetBestBooks();
        }

        private void GetBestBooks()
        {
            Database databaseObject = new Database();
            SQLiteCommand GetBooks = new SQLiteCommand("SELECT ms.best_id, b.name FROM month_statistics ms LEFT JOIN books b ON ms.best_id = b.id WHERE ms.year LIKE @yearToClose", databaseObject.dbConnection);
            GetBooks.Parameters.AddWithValue("@yearToClose", yearToClose);
            databaseObject.OpenConnection();
            SQLiteDataReader result = GetBooks.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    books.Add(new Book(result[0].ToString(), result[1].ToString()));
                }
            }
            result.Close();
            databaseObject.CloseConnection();

        }

        private void CheckForOdd()
        {
            if(books.Count % 2 != 0)
            {
                TheWorstOfTheBest chooseWorstForm = new TheWorstOfTheBest();
                chooseWorstForm.FormClosed += chooseWorstForm_FormClosed;
                chooseWorstForm.ShowDialog();
            }
            else
            {
                PerformTournament();
            }
        }

        private void chooseWorstForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Book theWorstBook = new Book(theWorstBookId, theWorstBookName);
            if(theWorstBookId == null)
            {
                this.Close();
            }
            else
            {
                if (books.Any(worst => worst.id == theWorstBook.id))
                {
                    books.RemoveAll(worst => worst.id == theWorstBook.id);
                    PerformTournament();
                }
                else
                {
                    MessageBox.Show("Błąd id");
                    this.Close();
                }
            }
        }

        private void PerformTournament()
        {
            int listID1 = -1;
            int listID2 = -1;
            if(books.Count % 2 == 0 && books.Count > 0)
            {
                var random = new Random();
                listID1 = random.Next(books.Count);
                if(listID1 != -1 && listID1 <= books.Count)
                {
                    button1ID = books[listID1].id;
                    button1Name = books[listID1].name;
                    Book1Button.Text = button1Name;
                }
                else
                {
                    MessageBox.Show("Błąd id");
                    this.Close();
                }

                do
                {
                    listID2 = random.Next(books.Count);

                } while (listID1 == listID2);

                if(listID2 != -1 && listID2 <= books.Count)
                {
                    button2Name = books[listID2].name;
                    button2ID = books[listID2].id;
                    Book2Button.Text = button2Name;
                }
                else
                {
                    MessageBox.Show("Błąd id");
                    this.Close();
                }          
            }
            else if(books.Count == 0 && books2.Count != 0)
            {
                books.AddRange(books2);
                books2.Clear();
                PerformTournament();
            }
        }

        private void CloseYear_Paint(object sender, PaintEventArgs e)
        {
            CheckForOdd();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookButton_Clicked(object sender, EventArgs e)
        {
            if(mode == "best")
            {
                Button ClickedButton = sender as Button;

                if(ClickedButton.Name == "Book1Button")
                {
                    ChosenBook = new Book(button1ID, button1Name);
                    UnchosenBook = new Book(button2ID, button2Name);
                    Book1Button.BackColor = Color.Green;
                    Book2Button.BackColor = Color.Red;
                }
                else if(ClickedButton.Name == "Book2Button")
                {
                    ChosenBook = new Book(button2ID, button2Name);
                    UnchosenBook = new Book(button1ID, button1Name);
                    Book1Button.BackColor = Color.Red;
                    Book2Button.BackColor = Color.Green;
                }
                isChosen = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(isChosen == true)
            {
                isChosen = false;

                books2.Add(ChosenBook);
                books.RemoveAll(choosen => choosen.id == ChosenBook.id);
                books.RemoveAll(unchosen => unchosen.id == UnchosenBook.id);
                Book1Button.BackColor = Color.FromArgb(255, 235, 201);
                Book2Button.BackColor = Color.FromArgb(255, 235, 201);

                PerformTournament();
            }
            else
            {
                MessageBox.Show("Musisz wybrać lepszą książkę");
            }
        }
    }
}
