
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
            this.AktualnieCzytaneGrid = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AktualnieCzytaneGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AktualnieCzytaneGrid
            // 
            this.AktualnieCzytaneGrid.AllowUserToAddRows = false;
            this.AktualnieCzytaneGrid.AllowUserToDeleteRows = false;
            this.AktualnieCzytaneGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.AktualnieCzytaneGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AktualnieCzytaneGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AktualnieCzytaneGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AktualnieCzytaneGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AktualnieCzytaneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AktualnieCzytaneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.AuthorColumn,
            this.GenreColumn,
            this.StartDateColumn,
            this.FinishDateColumn,
            this.RateColumn,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AktualnieCzytaneGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AktualnieCzytaneGrid.Location = new System.Drawing.Point(0, 37);
            this.AktualnieCzytaneGrid.Name = "AktualnieCzytaneGrid";
            this.AktualnieCzytaneGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AktualnieCzytaneGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AktualnieCzytaneGrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AktualnieCzytaneGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AktualnieCzytaneGrid.RowTemplate.Height = 50;
            this.AktualnieCzytaneGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AktualnieCzytaneGrid.Size = new System.Drawing.Size(1090, 763);
            this.AktualnieCzytaneGrid.TabIndex = 2;
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
            this.AuthorColumn.Width = 300;
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
            this.RateColumn.Width = 70;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 101.5228F;
            this.Delete.HeaderText = "USUŃ";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 70;
            // 
            // PrzeczytaneScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1090, 800);
            this.Controls.Add(this.AktualnieCzytaneGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrzeczytaneScreen";
            this.Text = "PrzeczytaneScreen";
            ((System.ComponentModel.ISupportInitialize)(this.AktualnieCzytaneGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AktualnieCzytaneGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}