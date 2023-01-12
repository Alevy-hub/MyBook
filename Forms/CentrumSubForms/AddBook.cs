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

		public static string fromWhere;
		public static string readId;
		public static string bookId;
		string startingAutor;
		int authorSupport;

		public AddBook()
		{
			InitializeComponent();
			FillComboBoxes();
			StartDatePicker.Format = DateTimePickerFormat.Custom;
			StartDatePicker.CustomFormat = "dd.MM.yyyy";
			FinishDatePicker.Format = DateTimePickerFormat.Custom;
			FinishDatePicker.CustomFormat = "dd.MM.yyyy";
			SetControlsStatus();
			LoadData();
		}

		private void SetControlsStatus()
		{
			if(fromWhere == "edit")
			{
				TitleLabel.Text = "EDYTUJ KSIĄŻKĘ";
				AddButton.Text = "ZAPISZ";
			}
			else
			{
				TitleLabel.Text = "DODAJ KSIĄŻKĘ";
				NoRateCheckBox.Enabled = false;
				NoRateCheckBox.Visible = false;
				HoursNumeric.Visible = false;
				MinutesNumeric.Visible = false;
				TimeMiddleLabel.Visible = false;
				AddButton.Text = "DODAJ";
			}
		}

		private void LoadData()
		{
			if (fromWhere == "edit")
			{
				Database databaseObject = new Database();
				databaseObject.OpenConnection();
				SQLiteCommand LoadData = new SQLiteCommand("SELECT b.name, rb.start_date, rb.finish_date, rb.rating, rb.form, rb.comment, COALESCE(b.pages, 0), COALESCE(b.time, 0) FROM books b JOIN read_books rb ON rb.book_id = b.id WHERE rb.id LIKE @readId", databaseObject.dbConnection);
				LoadData.Parameters.AddWithValue("readId", readId);
				SQLiteDataReader result = LoadData.ExecuteReader();
				if (result.HasRows)
				{
					if (result.Read())
					{
						TitleComboBox.Text = result[0].ToString();
						StartDatePicker.Value = DateTime.Parse(result[1].ToString());
						FinishDatePicker.Value = DateTime.Parse(result[2].ToString());
						CommentTextBox.Text = result[5].ToString();
						UkonczoneRadio.Checked = true;

						if (result[3].ToString() == "0")
						{
							NoRateCheckBox.Checked = true;
						}
						else
						{
							NoRateCheckBox.Checked = false;
							RatingNumeric.Value = decimal.Parse(result[3].ToString());
						}

						if (result[4].ToString() == "papier")
						{
							PapierRadio.Checked = true;
							PagesCountNumeric.Value = int.Parse(result[6].ToString());
						}
						else if (result[4].ToString() == "ebook")
						{
							EbookRadio.Checked = true;
							PagesCountNumeric.Value = int.Parse(result[6].ToString());
						}
						else if (result[4].ToString() == "audiobook")
						{
							AudiobookRadio.Checked = true;
							HoursNumeric.Value = int.Parse(result[7].ToString()) / 60;
							MinutesNumeric.Value = int.Parse(result[7].ToString()) % 60;
						}


						startingAutor = AuthorComboBox.Text;
					}
				}
				result.Close();
				databaseObject.CloseConnection();
			}
			else if (fromWhere == "tbr")
			{
				Database databaseObject = new Database();
				databaseObject.OpenConnection();
				SQLiteCommand LoadData = new SQLiteCommand("SELECT name FROM books WHERE id LIKE @bookId", databaseObject.dbConnection);
				LoadData.Parameters.AddWithValue("bookId", bookId);
				SQLiteDataReader result = LoadData.ExecuteReader();
				if (result.HasRows)
				{
					if (result.Read())
					{
						TitleComboBox.Text = result[0].ToString();
					}
				}
				result.Close();
				databaseObject.CloseConnection();
			}
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
                PapierRadio.Visible = true;
                EbookRadio.Visible = true;
                AudiobookRadio.Visible = true;
                FormaLabel.Text = "FORMA";
                TBRYear.Visible = false;
            }
			else if (TBRRadio.Checked == true)
			{
				StartDatePicker.Enabled = false;
				FinishDatePicker.Enabled = false;
				RatingNumeric.Enabled = false;
				NoRateCheckBox.Visible = false;
				PagesCountNumeric.Enabled = false;
				PapierRadio.Visible = false;
				EbookRadio.Visible = false;
				AudiobookRadio.Visible = false;
				FormaLabel.Text = "ROK TBR";
				TBRYear.Value = int.Parse(DateTime.Now.Year.ToString());
				TBRYear.Visible = true;
			}
			else if (UkonczoneRadio.Checked)
			{
				StartDatePicker.Enabled = true;
				FinishDatePicker.Enabled = true;
				RatingNumeric.Enabled = true;
				NoRateCheckBox.Enabled = true;
				NoRateCheckBox.Visible = true;
				PagesCountNumeric.Enabled = true;
                PapierRadio.Visible = true;
                EbookRadio.Visible = true;
                AudiobookRadio.Visible = true;
                FormaLabel.Text = "FORMA";
                TBRYear.Visible = false;
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
			if (TBRRadio.Checked == false && PapierRadio.Checked == false && EbookRadio.Checked == false && AudiobookRadio.Checked == false)
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

		private bool CheckEditRadioButtons()
		{
            if (EditRadioButton.Visible == true && EditRadioButton.Checked != true && ChangeRadioButton.Checked != true)
            {
                MessageBox.Show("Musisz wybrać tryb edycji autora. Jeśli nie wiesz co to oznacza naciśnij przycisk info");
				return false;
            }
			else
			{
				return true;
			}
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
				SQLiteCommand addBookToRead = new SQLiteCommand("INSERT INTO tbr ('year', 'book_id', is_read) VALUES (@year, @bookId, @is_read)", databaseObject.dbConnection);
				addBookToRead.Parameters.AddWithValue("@year", TBRYear.Value.ToString());
				addBookToRead.Parameters.AddWithValue("@bookId", bookId);
				addBookToRead.Parameters.AddWithValue("@is_read", "0");
				addBookToRead.ExecuteNonQuery();
			}
			
			databaseObject.CloseConnection();
		}

		private void EditBook()
		{
            string authorId = null;
            string bookId = null;
            Database databaseObject = new Database();

			databaseObject.OpenConnection();
            SQLiteCommand checkAuthorId = new SQLiteCommand("SELECT id FROM authors WHERE name = @oldAuthorName", databaseObject.dbConnection);
            checkAuthorId.Parameters.AddWithValue("@oldAuthorName", startingAutor);
            SQLiteDataReader result = checkAuthorId.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    authorId = result["id"].ToString();
                }
            }

            SQLiteCommand addAuthor;
			databaseObject.OpenConnection();
			if(ChangeRadioButton.Checked == true)
			{
                addAuthor = new SQLiteCommand("INSERT or IGNORE INTO authors ('name') VALUES (@authorName)", databaseObject.dbConnection);
				addAuthor.Parameters.AddWithValue("@authorName", AuthorComboBox.Text.ToString());
				addAuthor.ExecuteNonQuery();
            }
			else if(EditRadioButton.Checked == true)
			{
                addAuthor = new SQLiteCommand("UPDATE authors SET name = @authorName WHERE id = @oldAuthorId", databaseObject.dbConnection);
				addAuthor.Parameters.AddWithValue("@authorName", AuthorComboBox.Text.ToString());
				addAuthor.Parameters.AddWithValue("@oldAuthorId", authorId);
				int i = addAuthor.ExecuteNonQuery();
			} 
            databaseObject.OpenConnection();

            checkAuthorId = new SQLiteCommand("SELECT id FROM authors WHERE name = @authorName", databaseObject.dbConnection);
            checkAuthorId.Parameters.AddWithValue("@authorName", AuthorComboBox.Text.ToString());
            result = checkAuthorId.ExecuteReader();
            if (result.HasRows)
            {
                if(result.Read())
                {
                    authorId = result["id"].ToString();
                }
            }

			//Books

            SQLiteCommand addBook = new SQLiteCommand("UPDATE books SET 'name' = @bookName, 'author_id' = @bookAuthorId, 'genre' = @bookGenre, 'pages' = @bookPages, 'time' = @time WHERE id = @rbId", databaseObject.dbConnection);
            addBook.Parameters.AddWithValue("@bookName", TitleComboBox.Text.ToString());
            addBook.Parameters.AddWithValue("@bookAuthorId", authorId);
            addBook.Parameters.AddWithValue("@bookGenre", GenreComboBox.Text.ToString());
            addBook.Parameters.AddWithValue("@bookPages", (int)PagesCountNumeric.Value);
            addBook.Parameters.AddWithValue("@rbId", readId);

            if (HoursNumeric.Visible == true)
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
                    bookId = result["id"].ToString();
                }
            }

            //Read Books

            if (UkonczoneRadio.Checked == true)
            {
                SQLiteCommand addBookToRead = new SQLiteCommand("UPDATE read_books SET 'book_id' = @bookId, 'start_date' = @startDate, 'finish_date' = @finishDate, 'rating' = @rating, 'form' = @form, 'comment' = @comment WHERE id = @rbId", databaseObject.dbConnection);
                addBookToRead.Parameters.AddWithValue("@bookId", bookId);
                addBookToRead.Parameters.AddWithValue("@startDate", StartDatePicker.Value.ToString("yyyy-MM-dd"));
                addBookToRead.Parameters.AddWithValue("@finishDate", FinishDatePicker.Value.ToString("yyyy-MM-dd"));
                addBookToRead.Parameters.AddWithValue("@rating", (double)RatingNumeric.Value);
                addBookToRead.Parameters.AddWithValue("@comment", CommentTextBox.Text);
                addBookToRead.Parameters.AddWithValue("@rbId", readId);
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
                SQLiteCommand addBookToRead = new SQLiteCommand("UPDATE read_books SET 'book_id' = @bookId, 'start_date' = @startDate, 'finish_date' = @finishDate, 'form' = @form WHERE id = @rbId", databaseObject.dbConnection);
                addBookToRead.Parameters.AddWithValue("@bookId", bookId);
                addBookToRead.Parameters.AddWithValue("@startDate", StartDatePicker.Value.ToString("yyyy-MM-dd"));
                addBookToRead.Parameters.AddWithValue("@finishDate", null);
                addBookToRead.Parameters.AddWithValue("@rbId", readId);
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
            //else if (TBRRadio.Checked == true)
            //{
            //    SQLiteCommand addBookToRead = new SQLiteCommand("UPDATE tbr SET 'year' = @year, 'book_id' = @bookId ", databaseObject.dbConnection);
            //    addBookToRead.Parameters.AddWithValue("@year", DateTime.Now.Year);
            //    addBookToRead.Parameters.AddWithValue("@bookId", bookId);
            //    addBookToRead.ExecuteNonQuery();
            //}

            databaseObject.CloseConnection();

        }

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (fromWhere != "edit" && CheckComboBoxes() && CheckRadioButtons() && CheckDates())
			{
				AddBookToDb();
				fromWhere = "";
				this.Close();
			}
			else if(fromWhere == "edit" && CheckComboBoxes() && CheckRadioButtons() && CheckDates() && CheckEditRadioButtons())
			{
				EditBook();
				fromWhere = "";
				this.Close();
			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			fromWhere = "";
			this.Close();
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

		private void InfoButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Wybierając opcję 'Zmiana', dokonasz zmiany autora dla tej książki.\nWybierając opcję 'Edycja' zmienisz nazwę autora dla wszystkich książek, do których został przypisany.");
		}

		private void AuthorComboBox_TextChanged(object sender, EventArgs e)
		{
			if(authorSupport > 0 && fromWhere == "edit")
			{
				if(AuthorComboBox.Text != startingAutor)
				{
					InfoButton.Visible = true;
					EditRadioButton.Visible = true;
					ChangeRadioButton.Visible = true;
				}
				else
				{
					InfoButton.Visible = false;
					EditRadioButton.Visible = false;
					ChangeRadioButton.Visible = false;
				}
			}
			authorSupport++;
		}
	}
}
