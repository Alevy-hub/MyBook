
namespace MyBook.forms
{
    partial class PrzeczytaneScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ReadBooksGrid = new System.Windows.Forms.DataGridView();
            this.TitleSearchBox = new System.Windows.Forms.TextBox();
            this.AuthorSearchBox = new System.Windows.Forms.TextBox();
            this.GenreSearchBox = new System.Windows.Forms.ComboBox();
            this.RateSearchBox = new System.Windows.Forms.NumericUpDown();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RateCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReadBooksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateSearchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadBooksGrid
            // 
            this.ReadBooksGrid.AllowUserToAddRows = false;
            this.ReadBooksGrid.AllowUserToDeleteRows = false;
            this.ReadBooksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ReadBooksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReadBooksGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.ReadBooksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadBooksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReadBooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReadBooksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TitleColumn,
            this.AuthorColumn,
            this.GenreColumn,
            this.StartDateColumn,
            this.FinishDateColumn,
            this.RateColumn,
            this.EditColumn,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReadBooksGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReadBooksGrid.EnableHeadersVisualStyles = false;
            this.ReadBooksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.ReadBooksGrid.Location = new System.Drawing.Point(0, 74);
            this.ReadBooksGrid.Name = "ReadBooksGrid";
            this.ReadBooksGrid.ReadOnly = true;
            this.ReadBooksGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReadBooksGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ReadBooksGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadBooksGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReadBooksGrid.RowTemplate.Height = 30;
            this.ReadBooksGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReadBooksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReadBooksGrid.Size = new System.Drawing.Size(1090, 726);
            this.ReadBooksGrid.TabIndex = 2;
            this.ReadBooksGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReadBooksGrid_CellClick);
            this.ReadBooksGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReadBooksGrid_CellDoubleClick);
            // 
            // TitleSearchBox
            // 
            this.TitleSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TitleSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleSearchBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleSearchBox.Location = new System.Drawing.Point(12, 40);
            this.TitleSearchBox.Name = "TitleSearchBox";
            this.TitleSearchBox.Size = new System.Drawing.Size(180, 27);
            this.TitleSearchBox.TabIndex = 3;
            this.TitleSearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // AuthorSearchBox
            // 
            this.AuthorSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.AuthorSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorSearchBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorSearchBox.Location = new System.Drawing.Point(198, 40);
            this.AuthorSearchBox.Name = "AuthorSearchBox";
            this.AuthorSearchBox.Size = new System.Drawing.Size(180, 27);
            this.AuthorSearchBox.TabIndex = 4;
            this.AuthorSearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // GenreSearchBox
            // 
            this.GenreSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.GenreSearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreSearchBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreSearchBox.FormattingEnabled = true;
            this.GenreSearchBox.Location = new System.Drawing.Point(384, 40);
            this.GenreSearchBox.Name = "GenreSearchBox";
            this.GenreSearchBox.Size = new System.Drawing.Size(180, 28);
            this.GenreSearchBox.TabIndex = 5;
            this.GenreSearchBox.SelectedIndexChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // RateSearchBox
            // 
            this.RateSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.RateSearchBox.DecimalPlaces = 2;
            this.RateSearchBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RateSearchBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.RateSearchBox.Location = new System.Drawing.Point(570, 40);
            this.RateSearchBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RateSearchBox.Name = "RateSearchBox";
            this.RateSearchBox.Size = new System.Drawing.Size(70, 27);
            this.RateSearchBox.TabIndex = 6;
            this.RateSearchBox.ValueChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(12, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(180, 23);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Nazwa";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Autor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(384, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gatunek";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(570, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ocena";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RateCheckBox
            // 
            this.RateCheckBox.AutoSize = true;
            this.RateCheckBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RateCheckBox.ForeColor = System.Drawing.Color.Black;
            this.RateCheckBox.Location = new System.Drawing.Point(645, 47);
            this.RateCheckBox.Name = "RateCheckBox";
            this.RateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.RateCheckBox.TabIndex = 11;
            this.RateCheckBox.UseVisualStyleBackColor = true;
            this.RateCheckBox.CheckedChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.FlatAppearance.BorderSize = 0;
            this.ClearSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearSearchButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearSearchButton.ForeColor = System.Drawing.Color.Firebrick;
            this.ClearSearchButton.Location = new System.Drawing.Point(984, 32);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(26, 36);
            this.ClearSearchButton.TabIndex = 12;
            this.ClearSearchButton.Text = "X";
            this.ClearSearchButton.UseVisualStyleBackColor = true;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(915, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Anuluj wyszukiwanie";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TitleColumn
            // 
            this.TitleColumn.FillWeight = 99.49239F;
            this.TitleColumn.HeaderText = "TYTUŁ";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TitleColumn.Width = 300;
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.HeaderText = "AUTOR";
            this.AuthorColumn.Name = "AuthorColumn";
            this.AuthorColumn.ReadOnly = true;
            this.AuthorColumn.Width = 280;
            // 
            // GenreColumn
            // 
            this.GenreColumn.HeaderText = "GATUNEK";
            this.GenreColumn.Name = "GenreColumn";
            this.GenreColumn.ReadOnly = true;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.FillWeight = 99.49239F;
            this.StartDateColumn.HeaderText = "DATA ROZPOCZĘCIA";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            this.StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartDateColumn.Width = 120;
            // 
            // FinishDateColumn
            // 
            this.FinishDateColumn.HeaderText = "DATA ZAKOŃCZENIA";
            this.FinishDateColumn.Name = "FinishDateColumn";
            this.FinishDateColumn.ReadOnly = true;
            this.FinishDateColumn.Width = 120;
            // 
            // RateColumn
            // 
            this.RateColumn.HeaderText = "OCENA";
            this.RateColumn.Name = "RateColumn";
            this.RateColumn.ReadOnly = true;
            this.RateColumn.Width = 80;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "";
            this.EditColumn.Image = global::MyBook.Properties.Resources.editing;
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditColumn.Width = 35;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 101.5228F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::MyBook.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 35;
            // 
            // PrzeczytaneScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1090, 800);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearSearchButton);
            this.Controls.Add(this.RateCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RateSearchBox);
            this.Controls.Add(this.GenreSearchBox);
            this.Controls.Add(this.AuthorSearchBox);
            this.Controls.Add(this.TitleSearchBox);
            this.Controls.Add(this.ReadBooksGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrzeczytaneScreen";
            this.Text = "PrzeczytaneScreen";
            ((System.ComponentModel.ISupportInitialize)(this.ReadBooksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RateSearchBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReadBooksGrid;
        private System.Windows.Forms.TextBox TitleSearchBox;
        private System.Windows.Forms.TextBox AuthorSearchBox;
        private System.Windows.Forms.ComboBox GenreSearchBox;
        private System.Windows.Forms.NumericUpDown RateSearchBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox RateCheckBox;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}