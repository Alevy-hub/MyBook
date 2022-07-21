﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MyBook.forms
{
    public partial class CentrumScreen : Form
    {
        public CentrumScreen()
        {
            InitializeComponent();
        }

        private void TestFillDb_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();
            string query = @"INSERT INTO authors ('name') VALUES ('Andrzej Sapkowski'), ('Stephen King'), ('J.K Rowling'), ('Dennis Lehane'), ('Hania Czaban');
                            INSERT INTO books ('name', 'author_id', 'genre', 'pages') VALUES ('Krew Elfów','1','Fantasy','400'), ('Podpalaczka','2','Thriller','600'), ('Harry Potter i Więzien Azkabanu','3','Fantasy','356'), ('Wyspa Tajemnic','4','Thriller','340'), ('Cały ten czas','5','Fantasy','532');
                            INSERT INTO read_books ('book_id', 'start_date', 'finish_date', 'rating', 'form') VALUES ('1','11-01-2022','25-01-2022','5','Papier'), ('2','03-03-2022',NULL,NULL,'Audiobook'), ('3','14-04-2022','09-05-2022','3.4','Ebook'), ('4','24-06-2022',NULL,NULL,'Ebook'), ('5','04-07-2022','20-07-2022','3.5','Papier')";
            SQLiteCommand newQuery = new SQLiteCommand(query, databaseObject.dbConnection);
            databaseObject.OpenConnection();
            newQuery.ExecuteNonQuery();
            databaseObject.CloseConnection();
        }
    }
}
