﻿
namespace MyBook.forms
{
    partial class CentrumScreen
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
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.AktualnieCzytanePanel = new System.Windows.Forms.Panel();
            this.AktualnieCzytaneGrid = new System.Windows.Forms.DataGridView();
            this.AktualnieCzytaneLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finish = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ContainerPanel.SuspendLayout();
            this.AktualnieCzytanePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AktualnieCzytaneGrid)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.AktualnieCzytanePanel);
            this.ContainerPanel.Controls.Add(this.TopPanel);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(1090, 800);
            this.ContainerPanel.TabIndex = 0;
            // 
            // AktualnieCzytanePanel
            // 
            this.AktualnieCzytanePanel.Controls.Add(this.AktualnieCzytaneGrid);
            this.AktualnieCzytanePanel.Controls.Add(this.AktualnieCzytaneLabel);
            this.AktualnieCzytanePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AktualnieCzytanePanel.Location = new System.Drawing.Point(0, 120);
            this.AktualnieCzytanePanel.Name = "AktualnieCzytanePanel";
            this.AktualnieCzytanePanel.Size = new System.Drawing.Size(1090, 429);
            this.AktualnieCzytanePanel.TabIndex = 1;
            // 
            // AktualnieCzytaneGrid
            // 
            this.AktualnieCzytaneGrid.AllowUserToDeleteRows = false;
            this.AktualnieCzytaneGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.AktualnieCzytaneGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AktualnieCzytaneGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AktualnieCzytaneGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AktualnieCzytaneGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AktualnieCzytaneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AktualnieCzytaneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.StartDateColumn,
            this.Finish,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AktualnieCzytaneGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.AktualnieCzytaneGrid.Location = new System.Drawing.Point(12, 56);
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
            this.AktualnieCzytaneGrid.Size = new System.Drawing.Size(1066, 373);
            this.AktualnieCzytaneGrid.TabIndex = 1;
            // 
            // AktualnieCzytaneLabel
            // 
            this.AktualnieCzytaneLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AktualnieCzytaneLabel.Location = new System.Drawing.Point(0, 3);
            this.AktualnieCzytaneLabel.Name = "AktualnieCzytaneLabel";
            this.AktualnieCzytaneLabel.Size = new System.Drawing.Size(1090, 50);
            this.AktualnieCzytaneLabel.TabIndex = 0;
            this.AktualnieCzytaneLabel.Text = "AKTUALNIE CZYTANE";
            this.AktualnieCzytaneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.AddBookButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1090, 120);
            this.TopPanel.TabIndex = 0;
            // 
            // AddBookButton
            // 
            this.AddBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.AddBookButton.FlatAppearance.BorderSize = 0;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBookButton.Location = new System.Drawing.Point(394, 10);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(300, 100);
            this.AddBookButton.TabIndex = 0;
            this.AddBookButton.Text = "DODAJ KSIĄŻKĘ";
            this.AddBookButton.UseVisualStyleBackColor = false;
            // 
            // TitleColumn
            // 
            this.TitleColumn.FillWeight = 99.49239F;
            this.TitleColumn.HeaderText = "TYTUŁ";
            this.TitleColumn.Name = "TitleColumn";
            this.TitleColumn.ReadOnly = true;
            this.TitleColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TitleColumn.Width = 550;
            // 
            // StartDateColumn
            // 
            this.StartDateColumn.FillWeight = 99.49239F;
            this.StartDateColumn.HeaderText = "DATA ROZPOCZĘCIA";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            this.StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartDateColumn.Width = 250;
            // 
            // Finish
            // 
            this.Finish.FillWeight = 99.49239F;
            this.Finish.HeaderText = "ZAKOŃCZ";
            this.Finish.Name = "Finish";
            this.Finish.ReadOnly = true;
            this.Finish.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Finish.Width = 130;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 101.5228F;
            this.Delete.HeaderText = "USUŃ";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 130;
            // 
            // CentrumScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1090, 800);
            this.ControlBox = false;
            this.Controls.Add(this.ContainerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CentrumScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CentrumScreen";
            this.ContainerPanel.ResumeLayout(false);
            this.AktualnieCzytanePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AktualnieCzytaneGrid)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Panel AktualnieCzytanePanel;
        private System.Windows.Forms.DataGridView AktualnieCzytaneGrid;
        private System.Windows.Forms.Label AktualnieCzytaneLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Finish;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}