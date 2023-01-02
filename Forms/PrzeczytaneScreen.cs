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
using System.Data.SqlClient;

namespace MyBook.forms
{
	public partial class PrzeczytaneScreen : Form
	{
		public static string readBookId;

		public PrzeczytaneScreen()
		{
			InitializeComponent();
			FillReadBooksGrid();
			FillGenreSearchBox();
		}

		public void FillReadBooksGrid()
		{
			ReadBooksGrid.Columns[4].DefaultCellStyle.Format = "dd.MM.yyyy";
			ReadBooksGrid.Columns[5].DefaultCellStyle.Format = "dd.MM.yyyy";
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT rb.id, b.name, a.name, b.genre, rb.start_date, rb.finish_date, rb.rating FROM books b JOIN read_books rb ON b.id = rb.book_id JOIN authors a ON b.author_id = a.id WHERE rb.finish_date NOT NULL", databaseObject.dbConnection);
			SQLiteDataReader result = FillGridQuery.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
                    double rateDoub = double.Parse(result.GetValue(6).ToString());
                    string rate = rateDoub.ToString("N2");
                    if (rate == "0,00")
					{
						rate = "Brak";
					}

					ReadBooksGrid.Rows.Add(new object[]
					{
						result.GetValue(0),
						result.GetValue(1),
						result.GetValue(2),
						result.GetValue(3),
						DateTime.ParseExact((string)result.GetValue(4), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
						DateTime.ParseExact((string)result.GetValue(5), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
						rate
					});
				}
			}
			databaseObject.CloseConnection();
		}

		private void FillGenreSearchBox()
        {
			Database databaseObject = new Database();
			databaseObject.OpenConnection();
			SQLiteCommand FillGenreSearchBox = new SQLiteCommand("SELECT DISTINCT genre from books", databaseObject.dbConnection);
			SQLiteDataReader result = FillGenreSearchBox.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					GenreSearchBox.Items.Add(

						result.GetValue(0)
					);
				}
			}

			databaseObject.CloseConnection();
		}

		private void ReadBooksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string readId = "";
			string monthStatistics = "";
			string yearStatistics = "";
			if(e.ColumnIndex == 7)
			{
                readId = ReadBooksGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
				if(readId != "")
				{
                    Database databaseObject = new Database();
                    databaseObject.OpenConnection();
                    SQLiteCommand checkBestWorstMonth = new SQLiteCommand("SELECT count(*) FROM month_statistics WHERE best_id = @bookId OR worst_id = @bookId", databaseObject.dbConnection);
                    checkBestWorstMonth.Parameters.AddWithValue("@bookId", readId);
                    SQLiteDataReader result = checkBestWorstMonth.ExecuteReader();
                    if (result.HasRows)
                    {
                        if (result.Read())
                        {
                            monthStatistics = result[0].ToString();
                        }
                    }
                    result.Close();
                    databaseObject.CloseConnection();

                    databaseObject.OpenConnection();
                    SQLiteCommand checkBestWorstYear = new SQLiteCommand("SELECT count(*) FROM year_statistics WHERE best_id = @bookId OR worst_id = @bookId", databaseObject.dbConnection);
                    checkBestWorstYear.Parameters.AddWithValue("@bookId", readId);
                    result = checkBestWorstYear.ExecuteReader();
                    if (result.HasRows)
                    {
                        if (result.Read())
                        {
                            yearStatistics = result[0].ToString();
                        }
                    }
                    result.Close();
                    databaseObject.CloseConnection();

                    if (monthStatistics != "0" || yearStatistics != "0")
                    {
                        MessageBox.Show("Nie można edytować książki, która została wybrana najlepszą lub najgorszą!");
                        return;
                    }

					AddBook.readId = readId;
					AddBook.fromWhere = "edit";
					AddBook addBookForm = new AddBook();
					addBookForm.ShowDialog();
                }
            }
			else if (e.ColumnIndex == 8)
			{
				readId = ReadBooksGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
				if (readId != "")
				{
					MessageBox.Show(readId);
					Database databaseObject = new Database();
					databaseObject.OpenConnection();
					SQLiteCommand checkBestWorstMonth = new SQLiteCommand("SELECT count(*) FROM month_statistics WHERE best_id = @bookId OR worst_id = @bookId", databaseObject.dbConnection);
					checkBestWorstMonth.Parameters.AddWithValue("@bookId", readId);
					SQLiteDataReader result = checkBestWorstMonth.ExecuteReader();
					if (result.HasRows)
					{
						if (result.Read())
						{
							monthStatistics = result[0].ToString();
						}
					}
					result.Close();
					databaseObject.CloseConnection();

                    databaseObject.OpenConnection();
                    SQLiteCommand checkBestWorstYear = new SQLiteCommand("SELECT count(*) FROM year_statistics WHERE best_id = @bookId OR worst_id = @bookId", databaseObject.dbConnection);
                    checkBestWorstYear.Parameters.AddWithValue("@bookId", readId);
                    result = checkBestWorstYear.ExecuteReader();
                    if (result.HasRows)
                    {
                        if (result.Read())
                        {
                            yearStatistics = result[0].ToString();
                        }
                    }
                    result.Close();
                    databaseObject.CloseConnection();

                    if (monthStatistics != "0" || yearStatistics != "0")
					{
						MessageBox.Show("Nie można usunąć książki, która została wybrana najlepszą lub najgorszą!");
						return;
					}

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
			if(e.ColumnIndex != 7 && e.ColumnIndex != 8 && e.RowIndex != -1)
            {			
				Database databaseObject = new Database();
				databaseObject.OpenConnection();
				SQLiteCommand checkReadId = new SQLiteCommand("SELECT id FROM read_books WHERE book_id = (SELECT id FROM books where name = @bookName) and start_date = @startDate and finish_date = @finishDate", databaseObject.dbConnection);
				checkReadId.Parameters.AddWithValue("@bookName", ReadBooksGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
				DateTime startDate = (DateTime)ReadBooksGrid.Rows[e.RowIndex].Cells[4].Value;
				DateTime finishDate = (DateTime)ReadBooksGrid.Rows[e.RowIndex].Cells[5].Value;
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
			SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT rb.id, b.name, a.name, b.genre, rb.start_date, rb.finish_date, rb.rating FROM books b JOIN read_books rb ON b.id = rb.book_id JOIN authors a ON b.author_id = a.id WHERE rb.finish_date NOT NULL AND b.name LIKE @bookName AND a.name LIKE @authorName AND b.genre LIKE @bookGenre AND rb.rating LIKE @bookRate", databaseObject.dbConnection);
			FillGridQuery.Parameters.AddWithValue("@bookName", "%" + TitleSearchBox.Text + "%");
			FillGridQuery.Parameters.AddWithValue("@authorName", "%" + AuthorSearchBox.Text + "%");
			FillGridQuery.Parameters.AddWithValue("@bookGenre", "%" + GenreSearchBox.Text + "%");
			if(RateCheckBox.Checked == true)
            {
				string rateNumericString = RateSearchBox.Value.ToString();
				rateNumericString = rateNumericString.Replace(",", ".");
				FillGridQuery.Parameters.AddWithValue("@bookRate", "%" + rateNumericString + "%");
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
					double rateDoub = double.Parse(result.GetValue(6).ToString());
					string rate = rateDoub.ToString("N2");
					if (rate == "0,00")
					{
						rate = "Brak";
					}

                    ReadBooksGrid.Rows.Add(new object[]
                    {
                        result.GetValue(0),
                        result.GetValue(1),
                        result.GetValue(2),
                        result.GetValue(3),
                        DateTime.ParseExact((string)result.GetValue(4), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        DateTime.ParseExact((string)result.GetValue(5), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture),
                        rate,
                    });

                }
			}
			result.Close();
			databaseObject.CloseConnection();
		}

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
			TitleSearchBox.Clear();
			AuthorSearchBox.Clear();
			GenreSearchBox.Text = "";
			RateSearchBox.Value = 0;
			RateCheckBox.Checked = false;
			ReadBooksGrid.Rows.Clear();
			FillReadBooksGrid();

        }
    }
}
