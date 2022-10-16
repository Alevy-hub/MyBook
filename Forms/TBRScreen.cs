using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace MyBook.forms
{
    public partial class TBRScreen : Form
    {
        public TBRScreen()
        {
            InitializeComponent();
            FillTBRGrid();
        }

       private void FillTBRGrid()
        {
            Database databaseObject = new Database();
            databaseObject.OpenConnection();
            SQLiteCommand FillGridQuery = new SQLiteCommand("SELECT name FROM books JOIN tbr on id = book_id", databaseObject.dbConnection);
            SQLiteDataReader result = FillGridQuery.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    TBRGrid.Rows.Add(new object[]
                    {
                        "",
                        result.GetValue(0),
                    });
                }
            }
            databaseObject.CloseConnection();
        }
    }
}
