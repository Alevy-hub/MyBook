
namespace MyBook
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.UstawieniaButton = new System.Windows.Forms.Button();
            this.TBRButton = new System.Windows.Forms.Button();
            this.StatystykiButton = new System.Windows.Forms.Button();
            this.PrzeczytaneButton = new System.Windows.Forms.Button();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.CentrumButton = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.LeftPanel.Controls.Add(this.MenuPanel);
            this.LeftPanel.Controls.Add(this.LogoPanel);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(350, 900);
            this.LeftPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.UstawieniaButton);
            this.MenuPanel.Controls.Add(this.TBRButton);
            this.MenuPanel.Controls.Add(this.StatystykiButton);
            this.MenuPanel.Controls.Add(this.PrzeczytaneButton);
            this.MenuPanel.Controls.Add(this.ChallengeButton);
            this.MenuPanel.Controls.Add(this.CentrumButton);
            this.MenuPanel.Location = new System.Drawing.Point(0, 100);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(350, 800);
            this.MenuPanel.TabIndex = 1;
            // 
            // UstawieniaButton
            // 
            this.UstawieniaButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UstawieniaButton.FlatAppearance.BorderSize = 0;
            this.UstawieniaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UstawieniaButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UstawieniaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.UstawieniaButton.Location = new System.Drawing.Point(0, 665);
            this.UstawieniaButton.Name = "UstawieniaButton";
            this.UstawieniaButton.Size = new System.Drawing.Size(350, 133);
            this.UstawieniaButton.TabIndex = 5;
            this.UstawieniaButton.Text = "USTAWIENIA";
            this.UstawieniaButton.UseVisualStyleBackColor = true;
            this.UstawieniaButton.Click += new System.EventHandler(this.UstawieniaButton_Click);
            // 
            // TBRButton
            // 
            this.TBRButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TBRButton.FlatAppearance.BorderSize = 0;
            this.TBRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TBRButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBRButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TBRButton.Location = new System.Drawing.Point(0, 532);
            this.TBRButton.Name = "TBRButton";
            this.TBRButton.Size = new System.Drawing.Size(350, 133);
            this.TBRButton.TabIndex = 4;
            this.TBRButton.Text = "TBR";
            this.TBRButton.UseVisualStyleBackColor = true;
            this.TBRButton.Click += new System.EventHandler(this.TBRButton_Click);
            // 
            // StatystykiButton
            // 
            this.StatystykiButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatystykiButton.FlatAppearance.BorderSize = 0;
            this.StatystykiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatystykiButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatystykiButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.StatystykiButton.Location = new System.Drawing.Point(0, 399);
            this.StatystykiButton.Name = "StatystykiButton";
            this.StatystykiButton.Size = new System.Drawing.Size(350, 133);
            this.StatystykiButton.TabIndex = 3;
            this.StatystykiButton.Text = "STATYSTYKI";
            this.StatystykiButton.UseVisualStyleBackColor = true;
            this.StatystykiButton.Click += new System.EventHandler(this.StatystykiButton_Click);
            // 
            // PrzeczytaneButton
            // 
            this.PrzeczytaneButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrzeczytaneButton.FlatAppearance.BorderSize = 0;
            this.PrzeczytaneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrzeczytaneButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrzeczytaneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.PrzeczytaneButton.Location = new System.Drawing.Point(0, 266);
            this.PrzeczytaneButton.Name = "PrzeczytaneButton";
            this.PrzeczytaneButton.Size = new System.Drawing.Size(350, 133);
            this.PrzeczytaneButton.TabIndex = 2;
            this.PrzeczytaneButton.Text = "PRZECZYTANE";
            this.PrzeczytaneButton.UseVisualStyleBackColor = true;
            this.PrzeczytaneButton.Click += new System.EventHandler(this.PrzeczytaneButton_Click);
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChallengeButton.FlatAppearance.BorderSize = 0;
            this.ChallengeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChallengeButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChallengeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.ChallengeButton.Location = new System.Drawing.Point(0, 133);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(350, 133);
            this.ChallengeButton.TabIndex = 1;
            this.ChallengeButton.Text = "CHALLENGE";
            this.ChallengeButton.UseVisualStyleBackColor = true;
            this.ChallengeButton.Click += new System.EventHandler(this.ChallengeButton_Click);
            // 
            // CentrumButton
            // 
            this.CentrumButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CentrumButton.FlatAppearance.BorderSize = 0;
            this.CentrumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CentrumButton.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CentrumButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.CentrumButton.Location = new System.Drawing.Point(0, 0);
            this.CentrumButton.Name = "CentrumButton";
            this.CentrumButton.Size = new System.Drawing.Size(350, 133);
            this.CentrumButton.TabIndex = 0;
            this.CentrumButton.Text = "CENTRUM";
            this.CentrumButton.UseVisualStyleBackColor = true;
            this.CentrumButton.Click += new System.EventHandler(this.CentrumButton_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(350, 100);
            this.LogoPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.TopBarPanel.Controls.Add(this.label1);
            this.TopBarPanel.Controls.Add(this.ExitButton);
            this.TopBarPanel.Controls.Add(this.TitleLabel);
            this.TopBarPanel.Location = new System.Drawing.Point(350, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(1090, 100);
            this.TopBarPanel.TabIndex = 1;
            this.TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBarPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.label1.Location = new System.Drawing.Point(949, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "MyBook PreAlpha 0.0.3";
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.ExitButton.Location = new System.Drawing.Point(1057, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 42);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.TitleLabel.Location = new System.Drawing.Point(0, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1090, 86);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = " CENTRUM";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDown);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(151)))), ((int)(((byte)(113)))));
            this.MainPanel.Location = new System.Drawing.Point(350, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1090, 800);
            this.MainPanel.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopBarPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.LeftPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopBarPanel.ResumeLayout(false);
            this.TopBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopBarPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button UstawieniaButton;
        private System.Windows.Forms.Button TBRButton;
        private System.Windows.Forms.Button StatystykiButton;
        private System.Windows.Forms.Button PrzeczytaneButton;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Button CentrumButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}