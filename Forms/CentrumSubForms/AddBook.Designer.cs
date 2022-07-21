
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
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.TopBar = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.Container.Controls.Add(this.GenreComboBox);
            this.Container.Controls.Add(this.AuthorComboBox);
            this.Container.Controls.Add(this.TitleComboBox);
            this.Container.Controls.Add(this.BottomBar);
            this.Container.Controls.Add(this.TopBar);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(600, 660);
            this.Container.TabIndex = 0;
            // 
            // GenreComboBox
            // 
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
            this.TitleComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TitleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleComboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(98, 92);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(400, 38);
            this.TitleComboBox.TabIndex = 5;
            this.TitleComboBox.Text = "Tytuł...";
            // 
            // BottomBar
            // 
            this.BottomBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 635);
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
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 660);
            this.Controls.Add(this.Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Container.ResumeLayout(false);
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Panel BottomBar;
        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
    }
}