using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MyBook.Forms.StatystkiSubForms;

namespace MyBook.forms
{
    public partial class StatystykiScreen : Form
    {

        public StatystykiScreen()
        {
            InitializeComponent();
            EnableMonths();
        }

        private void EnableMonths()
        {
            string year = StatisticsYear.Text;
            List<string> months = new List<string>();

            Database databaseObject = new Database();
            SQLiteCommand checkMonth = new SQLiteCommand("SELECT strftime('%m', finish_date) FROM read_books WHERE strftime('%Y', finish_date) LIKE @finishYear", databaseObject.dbConnection);
            checkMonth.Parameters.AddWithValue("@finishYear", year);
            databaseObject.OpenConnection();
            SQLiteDataReader result = checkMonth.ExecuteReader();
            if (result.HasRows)
            {
                while(result.Read())
                {
                    months.Add(result[0].ToString());
                }
                WholeYearButton.Enabled = true;
            }
            else
            {
                WholeYearButton.Enabled = false;
            }
            result.Close();
            databaseObject.CloseConnection();


            if(months.Contains("01")){
                JanButton.Enabled = true;
            }
            else
            {
                JanButton.Enabled = false;
            }
            if(months.Contains("02")){
                FebButton.Enabled = true;
            }
            else
            {
                FebButton.Enabled = false;
            }
            if(months.Contains("03")){
                MarButton.Enabled = true;
            }
            else
            {
                MarButton.Enabled = false;
            }
            if(months.Contains("04")){
                AprButton.Enabled = true;
            }
            else
            {
                AprButton.Enabled = false;
            }
            if(months.Contains("05")){
                MayButton.Enabled = true;
            }
            else
            {
                MayButton.Enabled = false;
            }
            if(months.Contains("06")){
                JunButton.Enabled = true;
            }
            else
            {
                JunButton.Enabled = false;
            }
            if(months.Contains("07")){
                JulButton.Enabled = true;
            }
            else
            {
                JulButton.Enabled = false;
            }
            if(months.Contains("08")){
                AugButton.Enabled = true;
            }
            else
            {
                AugButton.Enabled = false;
            }
            if(months.Contains("09")){
                SepButton.Enabled = true;
            }
            else
            {
                SepButton.Enabled = false;
            }
            if(months.Contains("10")){
                OctButton.Enabled = true;
            }
            else
            {
                OctButton.Enabled = false;
            }
            if(months.Contains("11")){
                NovButton.Enabled = true;
            }
            else
            {
                NovButton.Enabled = false;
            }
            if(months.Contains("12")){
                DecButton.Enabled = true;
            }
            else
            {
                DecButton.Enabled = false;
            }

        }

        private void DecreaseYearButton_Click(object sender, EventArgs e)
        {
            int year = int.Parse(StatisticsYear.Text) - 1;
            StatisticsYear.Text = year.ToString();
            EnableMonths();
        }

        private void IncreaseYearButton_Click(object sender, EventArgs e)
        {
            int year = int.Parse(StatisticsYear.Text) + 1;
            StatisticsYear.Text = year.ToString();
            EnableMonths();
        }

        private void MonthButtonClick(object sender, EventArgs e)
        {
            MonthStatistics.statYear = StatisticsYear.Text;

            Button MonthButton = sender as Button;

            switch (MonthButton.Name.ToString())
            {
                case "JanButton":
                    MonthStatistics.statMonth = "01";
                    break;
                case "FebButton":
                    MonthStatistics.statMonth = "02";
                    break;
                case "MarButton":
                    MonthStatistics.statMonth = "03";
                    break;
                case "AprButton":
                    MonthStatistics.statMonth = "04";
                    break;
                case "MayButton":
                    MonthStatistics.statMonth = "05";
                    break;
                case "JunButton":
                    MonthStatistics.statMonth = "06";
                    break;
                case "JulButton":
                    MonthStatistics.statMonth = "07";
                    break;
                case "AugButton":
                    MonthStatistics.statMonth = "08";
                    break;
                case "SepButton":
                    MonthStatistics.statMonth = "09";
                    break;
                case "OctButton":
                    MonthStatistics.statMonth = "10";
                    break;
                case "NovButton":
                    MonthStatistics.statMonth = "11";
                    break;
                case "DecButton":
                    MonthStatistics.statMonth = "12";
                    break;
            }

            MonthStatistics monthStatistics = new MonthStatistics();
            monthStatistics.ShowDialog();
        }

        private void WholeYearButton_Click(object sender, EventArgs e)
        {
            YearStatistics.statYear = StatisticsYear.Text;
            YearStatistics yearStatistics = new YearStatistics();
            yearStatistics.ShowDialog();
        }
    }
}
