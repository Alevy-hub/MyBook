﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MyBook.Forms.StatystkiSubForms
{
    public partial class YearStatistics : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static string statYear;
        int readCount;
        double averageRateDouble = 0;

        public YearStatistics()
        {
            InitializeComponent();
            SetTitle();
            countRead();
            PrevYearCount();
            PercentOfChallenge();
            FormsOfBooks();
            PagesCount();
            HoursCount();
            RateAverage();
            PrevRateAverage();
            FavouriteGenre(); 
            BestBookLabel.Text = "NIE ZAIMPLEMENTOWANO";
            WorstBookLabel.Text = "NIE ZAIMPLEMENTOWANO";
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SetTitle()
        {
            TitleLabel.Text = "STATYSTYKI " + statYear;
        }

        private void countRead()
        {
            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT COUNT(*) FROM read_books WHERE strftime('%Y', finish_date) LIKE @finishYear", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    readCount = int.Parse(result[0].ToString());
                }
            }
            result.Close();
            databaseObject.CloseConnection();

            if (readCount > 1 && readCount < 5)
            {
                BooksLabel.Text = "KSIĄŻKI";
            }
            else if (readCount == 1)
            {
                BooksLabel.Text = "KSIĄŻKĘ";
            }
            else
            {
                BooksLabel.Text = "KSIĄŻEK";
            }

            ReadCountLabel.Text = readCount.ToString();
        }

        private void PrevYearCount()
        {
            int prevCount = 0;
            int prevYear = int.Parse(statYear) - 1;

            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT COUNT(*) FROM read_books WHERE strftime('%Y', finish_date) LIKE @finishYear", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", prevYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    prevCount = int.Parse(result[0].ToString());
                }
            }
            result.Close();
            databaseObject.CloseConnection();

            prevCount = readCount - prevCount;

            if (prevCount < 0)
            {
                prevCount = -prevCount;
                MoreLessPrevLabel.Text = "MNIEJ NIŻ W POPRZEDNIM ROKU";
            }
            else
            {
                MoreLessPrevLabel.Text = "WIĘCEJ NIŻ W POPRZEDNIM ROKU";
            }

            PrevYearLabel.Text = prevCount.ToString();
        }

        private void PercentOfChallenge()
        {
            double challengeCount = 0;
            double percentOfChallenge = 0;
            string percentOfChallengeString;
            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT count FROM challenges WHERE year LIKE @challengeYear", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@challengeYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    challengeCount = int.Parse(result[0].ToString());
                    percentOfChallenge = Math.Round(((double)readCount / challengeCount) * 100, 2);
                    percentOfChallengeString = percentOfChallenge.ToString() + "%";
                    ChallengePercentLabel.Text = percentOfChallengeString;
                }
            }
            else
            {
                ChallengePercentLabel.Text = "NIEDOSTĘPNE";
                SecondChallengePercentLabel.Text = "NIE USTAWIONO CHALLENGU";
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void FormsOfBooks()
        {
            PaperBooksLabel.Text = "0";
            EbookLabel.Text = "0";
            AudiobookLabel.Text = "0";

            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT form, COUNT(*) FROM read_books WHERE strftime('%Y', finish_date) LIKE @finishYear GROUP BY form", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (result[0].ToString() == "papier")
                    {
                        PaperBooksLabel.Text = result[1].ToString();
                    }
                    else if (result[0].ToString() == "ebook")
                    {
                        EbookLabel.Text = result[1].ToString();
                    }
                    else if (result[0].ToString() == "audiobook")
                    {
                        AudiobookLabel.Text = result[1].ToString();
                    }
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void PagesCount()
        {
            PagesLabel.Text = "0 STRON";
            string pagesCount = "";

            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT SUM(pages) FROM books WHERE id in (SELECT book_id FROM read_books WHERE (form LIKE 'papier' OR form LIKE 'ebook') AND strftime('%Y', finish_date) LIKE @finishYear)", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    pagesCount = result[0].ToString();
                }
            }
            result.Close();
            databaseObject.CloseConnection();

            PagesLabel.Text = pagesCount + " STRON";
        }

        private void HoursCount()
        {
            HoursLabel.Text = "0:00 GODZIN";
            int minutesCountInt = 0;
            string hoursCount = "0";
            string minutesCount = "00";

            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT SUM(time) FROM books WHERE id in (SELECT book_id FROM read_books WHERE form LIKE 'audiobook' AND strftime('%Y', finish_date) LIKE @finishYear)", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    if (result[0].ToString() != "")
                    {
                        minutesCountInt = int.Parse(result[0].ToString());

                        hoursCount = (minutesCountInt / 60).ToString();
                        minutesCount = (minutesCountInt % 60).ToString();

                        if (minutesCountInt % 60 < 10)
                        {
                            minutesCount = "0" + minutesCount;
                        }

                        HoursLabel.Text = hoursCount + ":" + minutesCount + " GODZIN";
                    }
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void RateAverage()
        {
            AverageRateLabel.Text = "BRAK OCEN";

            string averageRate = "";
            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT ROUND(AVG(rating), 2) FROM read_books WHERE rating NOT NULL AND strftime('%Y', finish_date) LIKE @finishYear", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    averageRate = result[0].ToString();
                    AverageRateLabel.Text = averageRate;
                    if (averageRate != "")
                    {
                        averageRateDouble = double.Parse(averageRate);
                    }
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void PrevRateAverage()
        {
            string prevAverageRate = "0.00";
            double diffAverage = 0;
            string prevYear = (int.Parse(statYear) - 1).ToString();

            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT AVG(rating) FROM read_books WHERE rating NOT NULL AND strftime('%Y', finish_date) LIKE @finishYear", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", prevYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    prevAverageRate = result[0].ToString();
                    if (prevAverageRate != "")
                    {
                        diffAverage = double.Parse(prevAverageRate) - averageRateDouble;
                        diffAverage = Math.Round(diffAverage, 2);

                        if (diffAverage > 0)
                        {
                            PrevRateUnderLabel.Text = "NIŻSZA NIŻ W POPRZEDNIM ROKU";
                        }
                        else
                        {
                            diffAverage = diffAverage * -1;
                            PrevRateUnderLabel.Text = "WYŻSZA NIŻ W POPRZEDNIM ROKU";
                        }
                        PrevAverageLabel.Text = diffAverage.ToString();
                    }
                    else
                    {
                        PrevAverageRateTop.Visible = false;
                        PrevAverageLabel.Text = "BRAK OCEN";
                        PrevRateUnderLabel.Visible = false;
                    }
                }
            }
            result.Close();
            databaseObject.CloseConnection();
        }

        private void FavouriteGenre()
        {
            string favouriteGenre = "";
            Database databaseObject = new Database();
            SQLiteCommand checkCount = new SQLiteCommand("SELECT genre, COUNT(*) as countBooks FROM (SELECT rb.book_id, b.genre FROM read_books rb LEFT JOIN books b ON rb.book_id = b.id WHERE strftime('%Y', finish_date) LIKE @finishYear) GROUP BY genre ORDER BY countBooks DESC LIMIT 1", databaseObject.dbConnection);
            checkCount.Parameters.AddWithValue("@finishYear", statYear);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkCount.ExecuteReader();
            if (result.HasRows)
            {
                if (result.Read())
                {
                    favouriteGenre = result[0].ToString();
                }
            }
            result.Close();
            databaseObject.CloseConnection();

            FavGenreLabel.Text = favouriteGenre;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
