
namespace MyBook.Forms.CentrumSubForms
{
    partial class FinishBook
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
            this.FutureDateAlertLabel = new System.Windows.Forms.Label();
            this.DateAlertLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.RatingNumeric = new System.Windows.Forms.NumericUpDown();
            this.FinishDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumeric)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Controls.Add(this.FutureDateAlertLabel);
            this.Container.Controls.Add(this.DateAlertLabel);
            this.Container.Controls.Add(this.CancelButton);
            this.Container.Controls.Add(this.AddButton);
            this.Container.Controls.Add(this.RatingLabel);
            this.Container.Controls.Add(this.RatingNumeric);
            this.Container.Controls.Add(this.FinishDatePicker);
            this.Container.Controls.Add(this.StartDatePicker);
            this.Container.Controls.Add(this.label2);
            this.Container.Controls.Add(this.label3);
            this.Container.Controls.Add(this.BottomBar);
            this.Container.Controls.Add(this.TopBar);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(442, 344);
            this.Container.TabIndex = 0;
            // 
            // FutureDateAlertLabel
            // 
            this.FutureDateAlertLabel.AutoSize = true;
            this.FutureDateAlertLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FutureDateAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.FutureDateAlertLabel.Location = new System.Drawing.Point(119, 163);
            this.FutureDateAlertLabel.Name = "FutureDateAlertLabel";
            this.FutureDateAlertLabel.Size = new System.Drawing.Size(200, 17);
            this.FutureDateAlertLabel.TabIndex = 23;
            this.FutureDateAlertLabel.Text = "Data nie może być w przyszłości!";
            this.FutureDateAlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FutureDateAlertLabel.Visible = false;
            // 
            // DateAlertLabel
            // 
            this.DateAlertLabel.AutoSize = true;
            this.DateAlertLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.DateAlertLabel.Location = new System.Drawing.Point(21, 146);
            this.DateAlertLabel.Name = "DateAlertLabel";
            this.DateAlertLabel.Size = new System.Drawing.Size(395, 17);
            this.DateAlertLabel.TabIndex = 22;
            this.DateAlertLabel.Text = "Data zakończenia nie może być wcześniejsza niż data rozpoczęcia!";
            this.DateAlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateAlertLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(229, 258);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(199, 51);
            this.CancelButton.TabIndex = 21;
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
            this.AddButton.Location = new System.Drawing.Point(12, 258);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(199, 51);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "ZAPISZ";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.RatingLabel.Location = new System.Drawing.Point(174, 183);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(96, 32);
            this.RatingLabel.TabIndex = 19;
            this.RatingLabel.Text = "OCENA";
            this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingNumeric
            // 
            this.RatingNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.RatingNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RatingNumeric.DecimalPlaces = 2;
            this.RatingNumeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.RatingNumeric.Location = new System.Drawing.Point(184, 219);
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
            this.RatingNumeric.TabIndex = 18;
            this.RatingNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FinishDatePicker
            // 
            this.FinishDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishDatePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinishDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinishDatePicker.Location = new System.Drawing.Point(229, 110);
            this.FinishDatePicker.Name = "FinishDatePicker";
            this.FinishDatePicker.Size = new System.Drawing.Size(199, 33);
            this.FinishDatePicker.TabIndex = 16;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartDatePicker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(12, 110);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(199, 33);
            this.StartDatePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.label2.Location = new System.Drawing.Point(229, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "DATA ZAKOŃCZENIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "DATA ROZPOCZĘCIA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottomBar
            // 
            this.BottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 324);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(442, 20);
            this.BottomBar.TabIndex = 1;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.TopBar.Controls.Add(this.TitleLabel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(442, 68);
            this.TopBar.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(442, 68);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "ZAKOŃCZ KSIĄŻKĘ";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // FinishBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(442, 344);
            this.Controls.Add(this.Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinishBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FinishBook";
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingNumeric)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel BottomBar;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DateTimePicker FinishDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.NumericUpDown RatingNumeric;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label DateAlertLabel;
        private System.Windows.Forms.Label FutureDateAlertLabel;
    }
}