using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBook.Forms.CentrumSubForms
{
    public partial class TheWorstOfTheBest : Form
    {
        bool worstChosed = false;
        Book worstBook;
        string choosedBook = "";
        string chooseBook = "";
        string message = "";


        public TheWorstOfTheBest()
        {
            InitializeComponent();
            SetStrings();
            CloseYear.theWorstBookId = null;
            CloseYear.theWorstBookName = null;
            FillBestBooksGrid();
        }

        private void SetStrings()
        {
            if(CloseYear.mode == "best")
            {
                chooseBook = "WYBIERZ NAJGORSZĄ KSIĄŻKĘ";
                choosedBook = "WYBRANA NAJGORSZA KSIĄŻKA";
                message = "Musisz najpierw wybrać najgorszą książkę";
            }
            else if(CloseYear.mode == "worst")
            {
                chooseBook = "WYBIERZ NAJEPSZĄ KSIĄŻKĘ";
                choosedBook = "WYBRANA NAJLEPSZA KSIĄŻKA";
                message = "Musisz najpierw wybrać najlepszą książkę";
            }
            topLabel.Text = chooseBook;
        }

        private void FillBestBooksGrid()
        {
            foreach(Book book in CloseYear.books)
            {
                BestBooksGrid.Rows.Add(new object[]
                {
                    book.id,
                    book.name,
                    "Wybierz"
                });
            }
        }

        private void BestBooksGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView Grid = sender as DataGridView;

            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                if (worstChosed == false)
                {
                    worstBook = new Book(Grid.Rows[e.RowIndex].Cells[0].Value.ToString(), Grid.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Grid.Rows.Clear();
                    Grid.Rows.Add(new object[]
                    {
                        worstBook.id,
                        worstBook.name,
                        "Zmień"
                    });
                    topLabel.Text = choosedBook;
                    Grid.DefaultCellStyle.BackColor = Color.FromArgb(176, 109, 84);
                    Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(176, 109, 84);
                    worstChosed = true;
                }
                else
                {
                    topLabel.Text = chooseBook;
                    Grid.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 201);
                    Grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 235, 201);
                    worstChosed = false;
                    Grid.Rows.Clear();
                    FillBestBooksGrid();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(worstChosed == true)
            {
                CloseYear.theWorstBookId = worstBook.id;
                CloseYear.theWorstBookName = worstBook.name;
                this.Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
