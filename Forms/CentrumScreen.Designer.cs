
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.AktualnieCzytanePanel = new System.Windows.Forms.Panel();
            this.AktualnieCzytaneGrid = new System.Windows.Forms.DataGridView();
            this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finish = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AktualnieCzytaneLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseMonthButton = new System.Windows.Forms.Button();
            this.TestFillDb = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
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
            this.AktualnieCzytaneGrid.AllowUserToAddRows = false;
            this.AktualnieCzytaneGrid.AllowUserToDeleteRows = false;
            this.AktualnieCzytaneGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.AktualnieCzytaneGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AktualnieCzytaneGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AktualnieCzytaneGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AktualnieCzytaneGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AktualnieCzytaneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AktualnieCzytaneGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleColumn,
            this.StartDateColumn,
            this.Finish,
            this.Delete,
            this.id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AktualnieCzytaneGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.AktualnieCzytaneGrid.EnableHeadersVisualStyles = false;
            this.AktualnieCzytaneGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.AktualnieCzytaneGrid.Location = new System.Drawing.Point(38, 56);
            this.AktualnieCzytaneGrid.Name = "AktualnieCzytaneGrid";
            this.AktualnieCzytaneGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AktualnieCzytaneGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AktualnieCzytaneGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AktualnieCzytaneGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.AktualnieCzytaneGrid.RowTemplate.Height = 50;
            this.AktualnieCzytaneGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AktualnieCzytaneGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AktualnieCzytaneGrid.Size = new System.Drawing.Size(1011, 373);
            this.AktualnieCzytaneGrid.TabIndex = 1;
            this.AktualnieCzytaneGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AktualnieCzytaneGrid_CellClick);
            this.AktualnieCzytaneGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AktualnieCzytaneGrid_CellDoubleClick);
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
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.StartDateColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartDateColumn.FillWeight = 99.49239F;
            this.StartDateColumn.HeaderText = "DATA ROZPOCZĘCIA";
            this.StartDateColumn.Name = "StartDateColumn";
            this.StartDateColumn.ReadOnly = true;
            this.StartDateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StartDateColumn.Width = 230;
            // 
            // Finish
            // 
            this.Finish.FillWeight = 99.49239F;
            this.Finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish.HeaderText = "ZAKOŃCZ";
            this.Finish.Name = "Finish";
            this.Finish.ReadOnly = true;
            this.Finish.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Finish.Width = 110;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 101.5228F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "USUŃ";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            this.TopPanel.Controls.Add(this.CloseMonthButton);
            this.TopPanel.Controls.Add(this.TestFillDb);
            this.TopPanel.Controls.Add(this.AddBookButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1090, 120);
            this.TopPanel.TabIndex = 0;
            // 
            // CloseMonthButton
            // 
            this.CloseMonthButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseMonthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CloseMonthButton.FlatAppearance.BorderSize = 0;
            this.CloseMonthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMonthButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseMonthButton.Location = new System.Drawing.Point(122, 37);
            this.CloseMonthButton.Name = "CloseMonthButton";
            this.CloseMonthButton.Size = new System.Drawing.Size(150, 50);
            this.CloseMonthButton.TabIndex = 2;
            this.CloseMonthButton.Text = "ZAMKNIJ MIESIĄC";
            this.CloseMonthButton.UseVisualStyleBackColor = false;
            this.CloseMonthButton.Click += new System.EventHandler(this.CloseMonthButton_Click);
            // 
            // TestFillDb
            // 
            this.TestFillDb.Location = new System.Drawing.Point(733, 44);
            this.TestFillDb.Name = "TestFillDb";
            this.TestFillDb.Size = new System.Drawing.Size(118, 46);
            this.TestFillDb.TabIndex = 1;
            this.TestFillDb.Text = "Test Fill DB";
            this.TestFillDb.UseVisualStyleBackColor = true;
            this.TestFillDb.Visible = false;
            this.TestFillDb.Click += new System.EventHandler(this.TestFillDb_Click);
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
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
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
        private System.Windows.Forms.Panel AktualnieCzytanePanel;
        private System.Windows.Forms.DataGridView AktualnieCzytaneGrid;
        private System.Windows.Forms.Label AktualnieCzytaneLabel;
        private System.Windows.Forms.Button TestFillDb;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button CloseMonthButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Finish;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}