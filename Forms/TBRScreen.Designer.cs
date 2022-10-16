
namespace MyBook.forms
{
    partial class TBRScreen
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
            this.DecreaseYearButton = new System.Windows.Forms.Button();
            this.IncreaseYearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChallengeYearLabel = new System.Windows.Forms.Label();
            this.TBRGrid = new System.Windows.Forms.DataGridView();
            this.isRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBRGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DecreaseYearButton
            // 
            this.DecreaseYearButton.FlatAppearance.BorderSize = 0;
            this.DecreaseYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseYearButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DecreaseYearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.DecreaseYearButton.Location = new System.Drawing.Point(437, 12);
            this.DecreaseYearButton.Name = "DecreaseYearButton";
            this.DecreaseYearButton.Size = new System.Drawing.Size(30, 50);
            this.DecreaseYearButton.TabIndex = 7;
            this.DecreaseYearButton.Text = "<";
            this.DecreaseYearButton.UseVisualStyleBackColor = true;
            // 
            // IncreaseYearButton
            // 
            this.IncreaseYearButton.FlatAppearance.BorderSize = 0;
            this.IncreaseYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseYearButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncreaseYearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.IncreaseYearButton.Location = new System.Drawing.Point(627, 12);
            this.IncreaseYearButton.Name = "IncreaseYearButton";
            this.IncreaseYearButton.Size = new System.Drawing.Size(30, 50);
            this.IncreaseYearButton.TabIndex = 6;
            this.IncreaseYearButton.Text = ">";
            this.IncreaseYearButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.ChallengeYearLabel);
            this.panel1.Location = new System.Drawing.Point(470, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 50);
            this.panel1.TabIndex = 5;
            // 
            // ChallengeYearLabel
            // 
            this.ChallengeYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChallengeYearLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChallengeYearLabel.Location = new System.Drawing.Point(0, 0);
            this.ChallengeYearLabel.Name = "ChallengeYearLabel";
            this.ChallengeYearLabel.Size = new System.Drawing.Size(150, 50);
            this.ChallengeYearLabel.TabIndex = 0;
            this.ChallengeYearLabel.Text = "2022";
            this.ChallengeYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBRGrid
            // 
            this.TBRGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.TBRGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TBRGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TBRGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TBRGrid.ColumnHeadersVisible = false;
            this.TBRGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isRead,
            this.Title});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TBRGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TBRGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TBRGrid.EnableHeadersVisualStyles = false;
            this.TBRGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.TBRGrid.Location = new System.Drawing.Point(81, 110);
            this.TBRGrid.Name = "TBRGrid";
            this.TBRGrid.ReadOnly = true;
            this.TBRGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TBRGrid.RowHeadersVisible = false;
            this.TBRGrid.RowTemplate.Height = 100;
            this.TBRGrid.RowTemplate.ReadOnly = true;
            this.TBRGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TBRGrid.ShowCellErrors = false;
            this.TBRGrid.ShowCellToolTips = false;
            this.TBRGrid.ShowEditingIcon = false;
            this.TBRGrid.ShowRowErrors = false;
            this.TBRGrid.Size = new System.Drawing.Size(901, 678);
            this.TBRGrid.TabIndex = 8;
            // 
            // isRead
            // 
            this.isRead.HeaderText = "";
            this.isRead.Name = "isRead";
            this.isRead.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Tytuł";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 798;
            // 
            // TBRScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1090, 800);
            this.Controls.Add(this.TBRGrid);
            this.Controls.Add(this.DecreaseYearButton);
            this.Controls.Add(this.IncreaseYearButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TBRScreen";
            this.Text = "TBRScreen";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBRGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DecreaseYearButton;
        private System.Windows.Forms.Button IncreaseYearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ChallengeYearLabel;
        private System.Windows.Forms.DataGridView TBRGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}