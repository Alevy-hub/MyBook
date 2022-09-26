using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MyBook.Forms.CentrumSubForms;
using MyBook.Forms.ChallengeSubForms;

namespace MyBook.forms
{
	public partial class PrzeczytaneScreen : Form
	{
		public static string readBookId;

		public PrzeczytaneScreen()
		{
			InitializeComponent();
			FillReadBooksGrid();
		}

		public void FillReadBooksGrid()
		{
			ReadBooksGrid.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
			ReadBooksGrid.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT b.name, a.name, b.genre, rb.start_date, rb.finish_date, rb.rating FROM books b JOIN read_books rb ON b.id = rb.book_id JOIN authors a ON b.author_id = a.id WHERE rb.finish_date NOT NULL", databaseObject.dbConnection);
			SQLiteDataReader result = FillGridQuery.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					string rate = result.GetValue(5).ToString();
					if (rate == "0")
					{
						rate = "Brak";
					}

					ReadBooksGrid.Rows.Add(new object[]
					{
						result.GetValue(0),
						result.GetValue(1),
						result.GetValue(2),
						DateTime.ParseExact((string)result.GetValue(3), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
						DateTime.ParseExact((string)result.GetValue(4), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
						rate,
						"Usuń"
					});
				}
			}
			databaseObject.CloseConnection();
		}

		private void ReadBooksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string readId = "";
			if (e.ColumnIndex == 6)
			{
				Database databaseObject = new Database();
				databaseObject.OpenConnection();
				SQLiteCommand checkReadId = new SQLiteCommand("SELECT id FROM read_books WHERE book_id = (SELECT id FROM books where name = @bookName) and start_date = @startDate and finish_date = @finishDate", databaseObject.dbConnection);
				checkReadId.Parameters.AddWithValue("@bookName", ReadBooksGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
				DateTime startDate = (DateTime)ReadBooksGrid.Rows[e.RowIndex].Cells[3].Value;
				DateTime finishDate = (DateTime)ReadBooksGrid.Rows[e.RowIndex].Cells[4].Value;
				checkReadId.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
				checkReadId.Parameters.AddWithValue("@finishDate", finishDate.ToString("yyyy-MM-dd"));

				SQLiteDataReader result = checkReadId.ExecuteReader();
				if (result.HasRows)
				{
					while (result.Read())
					{
						readId = result.GetValue("id").ToString();
					}
				}
				databaseObject.CloseConnection();

				if (readId != "")
				{
					DialogResult dr = MessageBox.Show("Czy na pewno chcesz usunąć książkę?", "Usuń książkę", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							databaseObject.OpenConnection();
							SQLiteCommand deleteFromRead = new SQLiteCommand("DELETE FROM read_books WHERE id = @readBookId", databaseObject.dbConnection);
							deleteFromRead.Parameters.AddWithValue("@readBookId", readId);
							deleteFromRead.ExecuteNonQuery();
							databaseObject.CloseConnection();

							ReadBooksGrid.Rows.Clear();
							FillReadBooksGrid();
							break;
						case DialogResult.No:
							break;
					}
				}
			}
		}

        private void ReadBooksGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if(e.ColumnIndex != 6)
            {			
				Database databaseObject = new Database();
				databaseObject.OpenConnection();
				SQLiteCommand checkReadId = new SQLiteCommand("SELECT id FROM read_books WHERE book_id = (SELECT id FROM books where name = @bookName) and start_date = @startDate and finish_date = @finishDate", databaseObject.dbConnection);
				checkReadId.Parameters.AddWithValue("@bookName", ReadBooksGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
				DateTime startDate = (DateTime)ReadBooksGrid.Rows[e.RowIndex].Cells[3].Value;
				DateTime finishDate = (DateTime)ReadBooksGrid.Rows[e.RowIndex].Cells[4].Value;
				checkReadId.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
				checkReadId.Parameters.AddWithValue("@finishDate", finishDate.ToString("yyyy-MM-dd"));
				
				SQLiteDataReader result = checkReadId.ExecuteReader();
				if (result.HasRows)
				{
					while (result.Read())
					{
						BookInfo.readBookId = result.GetValue("id").ToString();
					}
				}
				databaseObject.CloseConnection();


				BookInfo bookInfo = new BookInfo();
				bookInfo.ShowDialog();
            }
		}

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
			ReadBooksGrid.Rows.Clear();
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT b.name, a.name, b.genre, rb.start_date, rb.finish_date, rb.rating FROM books b JOIN read_books rb ON b.id = rb.book_id JOIN authors a ON b.author_id = a.id WHERE rb.finish_date NOT NULL AND b.name LIKE @bookName AND a.name LIKE @authorName AND b.genre LIKE @bookGenre AND rb.rating LIKE @bookRate", databaseObject.dbConnection);
			FillGridQuery.Parameters.AddWithValue("@bookName", "%" + TitleSearchBox.Text + "%");
			FillGridQuery.Parameters.AddWithValue("@authorName", "%" + AuthorSearchBox.Text + "%");
			FillGridQuery.Parameters.AddWithValue("@bookGenre", "%" + GenreSearchBox.Text + "%");
			if(RateCheckBox.Checked == true)
            {
				FillGridQuery.Parameters.AddWithValue("@bookRate", "%" + RateSearchBox.Value.ToString() + "%");
            }
            else
            {
				FillGridQuery.Parameters.AddWithValue("@bookRate", "%%");
            }

			SQLiteDataReader result = FillGridQuery.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					string rate = result.GetValue(5).ToString();
					if (rate == "0")
					{
						rate = "Brak";
					}

                    ReadBooksGrid.Rows.Add(new object[]
                    {
                        result.GetValue(0),
                        result.GetValue(1),
                        result.GetValue(2),
                        DateTime.ParseExact((string)result.GetValue(3), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        DateTime.ParseExact((string)result.GetValue(4), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        rate,
                        "Usuń"
                    });

                }
			}
			databaseObject.CloseConnection();
		}
    }
}
