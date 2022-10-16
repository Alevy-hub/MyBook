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
			StartDatePicker.Format = DateTimePickerFormat.Custom;
			StartDatePicker.CustomFormat = "dd.MM.yyyy";
			FinishDatePicker.Format = DateTimePickerFormat.Custom;
			FinishDatePicker.CustomFormat = "dd.MM.yyyy";
			NoRateCheckBox.Enabled = false;
			NoRateCheckBox.Visible = false;
			HoursNumeric.Visible = false;
			MinutesNumeric.Visible = false;
			TimeMiddleLabel.Visible = false;
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
				RatingNumeric.Enabled = false;
				NoRateCheckBox.Enabled = false;
				NoRateCheckBox.Visible = false;
                PagesCountNumeric.Enabled = true;
            }
			else if (TBRRadio.Checked == true)
			{
				StartDatePicker.Enabled = false;
				FinishDatePicker.Enabled = false;
				RatingNumeric.Enabled = false;
				NoRateCheckBox.Visible = false;
				PagesCountNumeric.Enabled = false;
			}
			else if (UkonczoneRadio.Checked)
			{
				StartDatePicker.Enabled = true;
				FinishDatePicker.Enabled = true;
				RatingNumeric.Enabled = true;
				NoRateCheckBox.Enabled = true;
				NoRateCheckBox.Visible = true;
                PagesCountNumeric.Enabled = true;
            }
			StatusAlertLabel.Visible = false;
		}

		private void FormRadio_CheckedChanged(object sender, EventArgs e)
		{
			FormAlertLabel.Visible = false;

			if(AudiobookRadio.Checked == true)
            {
				PagesCountNumeric.Visible = false;
				HoursNumeric.Visible = true;
				MinutesNumeric.Visible = true;
				TimeMiddleLabel.Visible = true;
				CountLabel.Text = "CZAS TRWANIA";
            }
            else
            {
				PagesCountNumeric.Visible = true;
				HoursNumeric.Visible = false;
				MinutesNumeric.Visible = false;
				TimeMiddleLabel.Visible = false;
				CountLabel.Text = "ILOŚĆ STRON";
			}
		}

		private bool CheckRadioButtons()
		{
			if (PapierRadio.Checked == false && EbookRadio.Checked == false && AudiobookRadio.Checked == false)
			{
				FormAlertLabel.Visible = true;
				return false;
			}

			if (CzytamRadio.Checked == false && TBRRadio.Checked == false && UkonczoneRadio.Checked == false)
			{
				StatusAlertLabel.Visible = true;
				return false;
			}
			return true;
		}

		private bool CheckDates()
		{
			if (UkonczoneRadio.Checked && StartDatePicker.Value.Day == FinishDatePicker.Value.Day)
			{
				DateAlertLabel.Visible = false;
				return true;
			}
			else if (UkonczoneRadio.Checked && StartDatePicker.Value > FinishDatePicker.Value)
			{
				DateAlertLabel.Visible = true;
				return false;
			}

			DateAlertLabel.Visible = false;
			return true;
		}

		private bool CheckComboBoxes()
		{
			if (TitleComboBox.Text == "" || TitleComboBox.Text == "Tytuł..." || AuthorComboBox.Text == "" || AuthorComboBox.Text == "Autor..." || GenreComboBox.Text == "" || GenreComboBox.Text == "Gatunek...")
			{
				EmptyComboBoxAlertLabel.Visible = true;
				return false;
			}
			EmptyComboBoxAlertLabel.Visible = false;
			return true;          
		}

		private void TitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand writeDetails = new SQLiteCommand("SELECT a.name, b.genre from authors a join books b on a.id = b.author_id where b.name = @bookName", databaseObject.dbConnection);
			writeDetails.Parameters.AddWithValue("@bookName", TitleComboBox.Text.ToString());
			SQLiteDataReader result = writeDetails.ExecuteReader();

			if (result.HasRows)
			{
				while (result.Read())
				{
					AuthorComboBox.Text = result["name"].ToString();
					GenreComboBox.Text = result["genre"].ToString();
				}
			}
			databaseObject.CloseConnection();
		}

		private void AddBookToDb()
		{
			int authorId = 0;
			int bookId = 0;
			Database databaseObject = new Database();
			SQLiteCommand addAuthor = new SQLiteCommand("INSERT or IGNORE INTO authors ('name') VALUES (@authorName)", databaseObject.dbConnection);
			addAuthor.Parameters.AddWithValue("@authorName", AuthorComboBox.Text.ToString());
			databaseObject.OpenConnection();
			addAuthor.ExecuteNonQuery();

			SQLiteCommand checkAuthorId = new SQLiteCommand("SELECT id FROM authors WHERE name = @authorName", databaseObject.dbConnection);
			checkAuthorId.Parameters.AddWithValue("@authorName", AuthorComboBox.Text.ToString());
			SQLiteDataReader result = checkAuthorId.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					authorId = (int)(long)result["id"];
				}
			}
			SQLiteCommand addBook = new SQLiteCommand("INSERT or IGNORE INTO books ('name', 'author_id', 'genre', 'pages', 'time') VALUES (@bookName, @bookAuthorId, @bookGenre, @bookPages, @time)", databaseObject.dbConnection);
			addBook.Parameters.AddWithValue("@bookName", TitleComboBox.Text.ToString());
			addBook.Parameters.AddWithValue("@bookAuthorId", authorId);
			addBook.Parameters.AddWithValue("@bookGenre", GenreComboBox.Text.ToString());
			addBook.Parameters.AddWithValue("@bookPages", (int)PagesCountNumeric.Value);

			if(HoursNumeric.Visible == true)
            {
				addBook.Parameters.AddWithValue("@time", (int)(HoursNumeric.Value * 60 + MinutesNumeric.Value));
				addBook.Parameters.AddWithValue("@bookPages", null);
			}
            else
            {	
				addBook.Parameters.AddWithValue("@time", null);
				addBook.Parameters.AddWithValue("@bookPages", (int)PagesCountNumeric.Value);
            }

			addBook.ExecuteNonQuery();
			

			SQLiteCommand checkBookId = new SQLiteCommand("SELECT id FROM books WHERE name = @bookName", databaseObject.dbConnection);
			checkBookId.Parameters.AddWithValue("@bookName", TitleComboBox.Text.ToString());
			result = checkBookId.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					bookId = (int)(long)result["id"];
				}
			}

			
			if (UkonczoneRadio.Checked == true)
			{
				SQLiteCommand addBookToRead = new SQLiteCommand("INSERT INTO read_books ('book_id', 'start_date', 'finish_date', 'rating', 'form', 'comment') VALUES (@bookId, @startDate, @finishDate, @rating, @form, @comment)", databaseObject.dbConnection);
				addBookToRead.Parameters.AddWithValue("@bookId", bookId);
				addBookToRead.Parameters.AddWithValue("@startDate", StartDatePicker.Value.ToString("yyyy-MM-dd"));
				addBookToRead.Parameters.AddWithValue("@finishDate", FinishDatePicker.Value.ToString("yyyy-MM-dd"));
				addBookToRead.Parameters.AddWithValue("@rating", (double)RatingNumeric.Value);
				addBookToRead.Parameters.AddWithValue("@comment", CommentTextBox.Text);
				if (EbookRadio.Checked == true)
				{
					addBookToRead.Parameters.AddWithValue("@form", "ebook");
				}
				else if (PapierRadio.Checked == true)
				{
					addBookToRead.Parameters.AddWithValue("@form", "papier");
				}
				else if (AudiobookRadio.Checked == true)
				{
					addBookToRead.Parameters.AddWithValue("@form", "audiobook");
				}
				addBookToRead.ExecuteNonQuery();

			}
			else if (CzytamRadio.Checked == true)
			{
				SQLiteCommand addBookToRead = new SQLiteCommand("INSERT INTO read_books ('book_id', 'start_date', 'form') VALUES (@bookId, @startDate, @form)", databaseObject.dbConnection);
				addBookToRead.Parameters.AddWithValue("@bookId", bookId);
				addBookToRead.Parameters.AddWithValue("@startDate", StartDatePicker.Value.ToString("yyyy-MM-dd"));
				if (EbookRadio.Checked == true)
				{
					addBookToRead.Parameters.AddWithValue("@form", "ebook");
				}
				else if (PapierRadio.Checked == true)
				{
					addBookToRead.Parameters.AddWithValue("@form", "papier");
				}
				else if (AudiobookRadio.Checked == true)
				{
					addBookToRead.Parameters.AddWithValue("@form", "audiobook");
				}
				addBookToRead.ExecuteNonQuery();
			}
			else if (TBRRadio.Checked == true)
			{
                SQLiteCommand addBookToRead = new SQLiteCommand("INSERT INTO tbr ('year', 'book_id') VALUES (@year, @bookId)", databaseObject.dbConnection);
                addBookToRead.Parameters.AddWithValue("@year", DateTime.Now.Year);
                addBookToRead.Parameters.AddWithValue("@bookId", bookId);
                addBookToRead.ExecuteNonQuery();
            }
			
			databaseObject.CloseConnection();
		}


		private void AddButton_Click(object sender, EventArgs e)
		{
			if (CheckComboBoxes() && CheckRadioButtons() && CheckDates())
			{
				AddBookToDb();
				this.Close();
			}			
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Container_Paint(object sender, PaintEventArgs e)
		{

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
