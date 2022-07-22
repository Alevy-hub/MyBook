﻿
namespace MyBook.Forms.CentrumSubForms
{
    partial class AddBook
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
            this.Container = new System.Windows.Forms.Panel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.RatingNumeric = new System.Windows.Forms.NumericUpDown();
            this.PagesCountNumeric = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FinishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusAlertLabel = new System.Windows.Forms.Label();
            this.UkonczoneRadio = new System.Windows.Forms.RadioButton();
            this.TBRRadio = new System.Windows.Forms.RadioButton();
            this.CzytamRadio = new System.Windows.Forms.RadioButton();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.FormAlertLabel = new System.Windows.Forms.Label();
            this.AudiobookRadio = new System.Windows.Forms.RadioButton();
            this.EbookRadio = new System.Windows.Forms.RadioButton();
            this.PapierRadio = new System.Windows.Forms.RadioButton();
            this.FormaLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesCountNumeric)).BeginInit();
            this.StatusPanel.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.AutoSize = true;
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.Container.Controls.Add(this.RatingLabel);
            this.Container.Controls.Add(this.CountLabel);
            this.Container.Controls.Add(this.RatingNumeric);
            this.Container.Controls.Add(this.PagesCountNumeric);
            this.Container.Controls.Add(this.CancelButton);
            this.Container.Controls.Add(this.AddButton);
            this.Container.Controls.Add(this.FinishDatePicker);
            this.Container.Controls.Add(this.StartDatePicker);
            this.Container.Controls.Add(this.label2);
            this.Container.Controls.Add(this.label1);
            this.Container.Controls.Add(this.StatusPanel);
            this.Container.Controls.Add(this.FormPanel);
            this.Container.Controls.Add(this.GenreComboBox);
            this.Container.Controls.Add(this.AuthorComboBox);
            this.Container.Controls.Add(this.TitleComboBox);
            this.Container.Controls.Add(this.BottomBar);
            this.Container.Controls.Add(this.TopBar);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(600, 706);
            this.Container.TabIndex = 0;
            this.Container.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Paint);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CountLabel.Location = new System.Drawing.Point(72, 412);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(166, 32);
            this.CountLabel.TabIndex = 5;
            this.CountLabel.Text = "ILOŚĆ STRON";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingNumeric
            // 
            this.RatingNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.RatingNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RatingNumeric.DecimalPlaces = 2;
            this.RatingNumeric.Enabled = false;
            this.RatingNumeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingNumeric.Location = new System.Drawing.Point(387, 457);
            this.RatingNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.RatingNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RatingNumeric.Name = "RatingNumeric";
            this.RatingNumeric.Size = new System.Drawing.Size(75, 29);
            this.RatingNumeric.TabIndex = 16;
            this.RatingNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PagesCountNumeric
            // 
            this.PagesCountNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.PagesCountNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PagesCountNumeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PagesCountNumeric.Location = new System.Drawing.Point(113, 457);
            this.PagesCountNumeric.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PagesCountNumeric.Name = "PagesCountNumeric";
            this.PagesCountNumeric.Size = new System.Drawing.Size(75, 29);
            this.PagesCountNumeric.TabIndex = 15;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(311, 603);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(199, 51);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "ANULUJ";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(94, 603);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(199, 51);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "DODAJ";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FinishDatePicker
            // 
            this.FinishDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishDatePicker.Enabled = false;
            this.FinishDatePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinishDatePicker.Location = new System.Drawing.Point(311, 537);
            this.FinishDatePicker.Name = "FinishDatePicker";
            this.FinishDatePicker.Size = new System.Drawing.Size(199, 33);
            this.FinishDatePicker.TabIndex = 12;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartDatePicker.Enabled = false;
            this.StartDatePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(94, 537);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(199, 33);
            this.StartDatePicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(311, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "DATA ZAKOŃCZENIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(98, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATA ROZPOCZĘCIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.StatusAlertLabel);
            this.StatusPanel.Controls.Add(this.UkonczoneRadio);
            this.StatusPanel.Controls.Add(this.TBRRadio);
            this.StatusPanel.Controls.Add(this.CzytamRadio);
            this.StatusPanel.Controls.Add(this.StatusLabel);
            this.StatusPanel.Location = new System.Drawing.Point(300, 224);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(300, 168);
            this.StatusPanel.TabIndex = 9;
            // 
            // StatusAlertLabel
            // 
            this.StatusAlertLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusAlertLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusAlertLabel.Location = new System.Drawing.Point(0, 153);
            this.StatusAlertLabel.Name = "StatusAlertLabel";
            this.StatusAlertLabel.Size = new System.Drawing.Size(300, 15);
            this.StatusAlertLabel.TabIndex = 5;
            this.StatusAlertLabel.Text = "Musisz wybrać status!";
            this.StatusAlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusAlertLabel.Visible = false;
            // 
            // UkonczoneRadio
            // 
            this.UkonczoneRadio.AutoSize = true;
            this.UkonczoneRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UkonczoneRadio.Cursor = System.Windows.Forms.Cursors.Default;
            this.UkonczoneRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.UkonczoneRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UkonczoneRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UkonczoneRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.UkonczoneRadio.Location = new System.Drawing.Point(66, 115);
            this.UkonczoneRadio.Name = "UkonczoneRadio";
            this.UkonczoneRadio.Size = new System.Drawing.Size(144, 29);
            this.UkonczoneRadio.TabIndex = 6;
            this.UkonczoneRadio.TabStop = true;
            this.UkonczoneRadio.Text = "UKOŃCZONE";
            this.UkonczoneRadio.UseVisualStyleBackColor = true;
            this.UkonczoneRadio.CheckedChanged += new System.EventHandler(this.StatusRadio_CheckedChanged);
            // 
            // TBRRadio
            // 
            this.TBRRadio.AutoSize = true;
            this.TBRRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TBRRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TBRRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TBRRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBRRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TBRRadio.Location = new System.Drawing.Point(148, 80);
            this.TBRRadio.Name = "TBRRadio";
            this.TBRRadio.Size = new System.Drawing.Size(62, 29);
            this.TBRRadio.TabIndex = 5;
            this.TBRRadio.TabStop = true;
            this.TBRRadio.Text = "TBR";
            this.TBRRadio.UseVisualStyleBackColor = true;
            this.TBRRadio.CheckedChanged += new System.EventHandler(this.StatusRadio_CheckedChanged);
            // 
            // CzytamRadio
            // 
            this.CzytamRadio.AutoSize = true;
            this.CzytamRadio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CzytamRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CzytamRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CzytamRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CzytamRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CzytamRadio.Location = new System.Drawing.Point(107, 45);
            this.CzytamRadio.Name = "CzytamRadio";
            this.CzytamRadio.Size = new System.Drawing.Size(103, 29);
            this.CzytamRadio.TabIndex = 4;
            this.CzytamRadio.TabStop = true;
            this.CzytamRadio.Text = "CZYTAM";
            this.CzytamRadio.UseVisualStyleBackColor = true;
            this.CzytamRadio.CheckedChanged += new System.EventHandler(this.StatusRadio_CheckedChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.StatusLabel.Location = new System.Drawing.Point(0, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(300, 32);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "STATUS";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.FormAlertLabel);
            this.FormPanel.Controls.Add(this.AudiobookRadio);
            this.FormPanel.Controls.Add(this.EbookRadio);
            this.FormPanel.Controls.Add(this.PapierRadio);
            this.FormPanel.Controls.Add(this.FormaLabel);
            this.FormPanel.Location = new System.Drawing.Point(0, 224);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(300, 168);
            this.FormPanel.TabIndex = 8;
            // 
            // FormAlertLabel
            // 
            this.FormAlertLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FormAlertLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.FormAlertLabel.Location = new System.Drawing.Point(0, 153);
            this.FormAlertLabel.Name = "FormAlertLabel";
            this.FormAlertLabel.Size = new System.Drawing.Size(300, 15);
            this.FormAlertLabel.TabIndex = 4;
            this.FormAlertLabel.Text = "Musisz wybrać formę!";
            this.FormAlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FormAlertLabel.Visible = false;
            // 
            // AudiobookRadio
            // 
            this.AudiobookRadio.AutoSize = true;
            this.AudiobookRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.AudiobookRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudiobookRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AudiobookRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.AudiobookRadio.Location = new System.Drawing.Point(98, 115);
            this.AudiobookRadio.Name = "AudiobookRadio";
            this.AudiobookRadio.Size = new System.Drawing.Size(140, 29);
            this.AudiobookRadio.TabIndex = 3;
            this.AudiobookRadio.TabStop = true;
            this.AudiobookRadio.Text = "AUDIOBOOK";
            this.AudiobookRadio.UseVisualStyleBackColor = true;
            this.AudiobookRadio.CheckedChanged += new System.EventHandler(this.FormRadio_CheckedChanged);
            // 
            // EbookRadio
            // 
            this.EbookRadio.AutoSize = true;
            this.EbookRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.EbookRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EbookRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EbookRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.EbookRadio.Location = new System.Drawing.Point(98, 80);
            this.EbookRadio.Name = "EbookRadio";
            this.EbookRadio.Size = new System.Drawing.Size(90, 29);
            this.EbookRadio.TabIndex = 2;
            this.EbookRadio.TabStop = true;
            this.EbookRadio.Text = "EBOOK";
            this.EbookRadio.UseVisualStyleBackColor = true;
            this.EbookRadio.CheckedChanged += new System.EventHandler(this.FormRadio_CheckedChanged);
            // 
            // PapierRadio
            // 
            this.PapierRadio.AutoSize = true;
            this.PapierRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.PapierRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PapierRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PapierRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.PapierRadio.Location = new System.Drawing.Point(98, 45);
            this.PapierRadio.Name = "PapierRadio";
            this.PapierRadio.Size = new System.Drawing.Size(91, 29);
            this.PapierRadio.TabIndex = 1;
            this.PapierRadio.TabStop = true;
            this.PapierRadio.Text = "PAPIER";
            this.PapierRadio.UseVisualStyleBackColor = true;
            this.PapierRadio.CheckedChanged += new System.EventHandler(this.FormRadio_CheckedChanged);
            // 
            // FormaLabel
            // 
            this.FormaLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormaLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.FormaLabel.Location = new System.Drawing.Point(0, 0);
            this.FormaLabel.Name = "FormaLabel";
            this.FormaLabel.Size = new System.Drawing.Size(300, 32);
            this.FormaLabel.TabIndex = 0;
            this.FormaLabel.Text = "FORMA";
            this.FormaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.GenreComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GenreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.GenreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(98, 180);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(400, 38);
            this.GenreComboBox.TabIndex = 7;
            this.GenreComboBox.Text = "Gatunek...";
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.AuthorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AuthorComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.AuthorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(98, 136);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(400, 38);
            this.AuthorComboBox.TabIndex = 6;
            this.AuthorComboBox.Text = "Autor...";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TitleComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TitleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TitleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(98, 92);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(400, 38);
            this.TitleComboBox.TabIndex = 5;
            this.TitleComboBox.Text = "Tytuł...";
            this.TitleComboBox.SelectedIndexChanged += new System.EventHandler(this.TitleComboBox_SelectedIndexChanged);
            // 
            // BottomBar
            // 
            this.BottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 681);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(600, 25);
            this.BottomBar.TabIndex = 1;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.TopBar.Controls.Add(this.TitleLabel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(600, 70);
            this.TopBar.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(600, 70);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "DODAJ KSIĄŻKĘ";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.RatingLabel.Location = new System.Drawing.Point(377, 412);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(96, 32);
            this.RatingLabel.TabIndex = 17;
            this.RatingLabel.Text = "OCENA";
            this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 706);
            this.Controls.Add(this.Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagesCountNumeric)).EndInit();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel BottomBar;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.RadioButton PapierRadio;
        private System.Windows.Forms.Label FormaLabel;
        private System.Windows.Forms.RadioButton AudiobookRadio;
        private System.Windows.Forms.RadioButton EbookRadio;
        private System.Windows.Forms.RadioButton UkonczoneRadio;
        private System.Windows.Forms.RadioButton TBRRadio;
        private System.Windows.Forms.RadioButton CzytamRadio;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FinishDatePicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label StatusAlertLabel;
        private System.Windows.Forms.Label FormAlertLabel;
        private System.Windows.Forms.NumericUpDown PagesCountNumeric;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.NumericUpDown RatingNumeric;
        private System.Windows.Forms.Label RatingLabel;
    }
}