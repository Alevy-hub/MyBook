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
        }

        private void DecreaseYearButton_Click(object sender, EventArgs e)
        {
            int year = int.Parse(StatisticsYear.Text) - 1;
            StatisticsYear.Text = year.ToString();
        }

        private void IncreaseYearButton_Click(object sender, EventArgs e)
        {
            int year = int.Parse(StatisticsYear.Text) + 1;
            StatisticsYear.Text = year.ToString();
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
            }

            MonthStatistics monthStatistics = new MonthStatistics();
            monthStatistics.ShowDialog();
        }
    }
}
