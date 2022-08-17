
namespace MyBook.forms
{
    partial class ChallengeScreen
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
            this.SetChallengeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChallengeYearLabel = new System.Windows.Forms.Label();
            this.IncreaseYearButton = new System.Windows.Forms.Button();
            this.DecreaseYearButton = new System.Windows.Forms.Button();
            this.ChallengeBoxesContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.ChallengeBoxesContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetChallengeButton
            // 
            this.SetChallengeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetChallengeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.SetChallengeButton.FlatAppearance.BorderSize = 0;
            this.SetChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetChallengeButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetChallengeButton.Location = new System.Drawing.Point(395, 300);
            this.SetChallengeButton.Name = "SetChallengeButton";
            this.SetChallengeButton.Size = new System.Drawing.Size(300, 100);
            this.SetChallengeButton.TabIndex = 1;
            this.SetChallengeButton.Text = "UTWÓRZ CHALLENGE";
            this.SetChallengeButton.UseVisualStyleBackColor = false;
            this.SetChallengeButton.Visible = false;
            this.SetChallengeButton.Click += new System.EventHandler(this.SetChallengeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.ChallengeYearLabel);
            this.panel1.Location = new System.Drawing.Point(470, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 50);
            this.panel1.TabIndex = 2;
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
            // IncreaseYearButton
            // 
            this.IncreaseYearButton.FlatAppearance.BorderSize = 0;
            this.IncreaseYearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseYearButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncreaseYearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.IncreaseYearButton.Location = new System.Drawing.Point(627, 12);
            this.IncreaseYearButton.Name = "IncreaseYearButton";
            this.IncreaseYearButton.Size = new System.Drawing.Size(30, 50);
            this.IncreaseYearButton.TabIndex = 3;
            this.IncreaseYearButton.Text = ">";
            this.IncreaseYearButton.UseVisualStyleBackColor = true;
            this.IncreaseYearButton.Click += new System.EventHandler(this.IncreaseYearButton_Click);
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
            this.DecreaseYearButton.TabIndex = 4;
            this.DecreaseYearButton.Text = "<";
            this.DecreaseYearButton.UseVisualStyleBackColor = true;
            this.DecreaseYearButton.Click += new System.EventHandler(this.DecreaseYearButton_Click);
            // 
            // ChallengeBoxesContainer
            // 
            this.ChallengeBoxesContainer.Controls.Add(this.SetChallengeButton);
            this.ChallengeBoxesContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChallengeBoxesContainer.Location = new System.Drawing.Point(0, 77);
            this.ChallengeBoxesContainer.Name = "ChallengeBoxesContainer";
            this.ChallengeBoxesContainer.Size = new System.Drawing.Size(1090, 723);
            this.ChallengeBoxesContainer.TabIndex = 5;
            // 
            // ChallengeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1090, 800);
            this.Controls.Add(this.ChallengeBoxesContainer);
            this.Controls.Add(this.DecreaseYearButton);
            this.Controls.Add(this.IncreaseYearButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChallengeScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ChallengeScreen";
            this.Load += new System.EventHandler(this.ChallengeScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ChallengeBoxesContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetChallengeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ChallengeYearLabel;
        private System.Windows.Forms.Button IncreaseYearButton;
        private System.Windows.Forms.Button DecreaseYearButton;
        private System.Windows.Forms.Panel ChallengeBoxesContainer;
    }
}