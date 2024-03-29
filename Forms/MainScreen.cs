﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace MyBook
{
    public partial class MainScreen : Form
    {

        private Button currentButton;
        private Form activeForm;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public MainScreen()
        {
            InitializeComponent();
            OpenChildForm(new forms.CentrumScreen(), CentrumButton);
            Database databaseObject = new Database();
            
        }

        private void TopBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SelectedButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    UnselectButton();
                    currentButton = (Button)btnSender;
                    Button btn = btnSender as Button;
                    btn.BackColor = ColorTranslator.FromHtml("#B05B3B");
                    TitleLabel.Text = btn.Text;
                }
            }
        }

        private void UnselectButton()
        {
            foreach (Control prevoriousBtn in MenuPanel.Controls)
            {
                if (prevoriousBtn.GetType() == typeof(Button))
                {
                    prevoriousBtn.BackColor = ColorTranslator.FromHtml("#753422");
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            SelectedButton(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(childForm);
            this.MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Button btn = btnSender as Button;
            childForm.Text = btn.Text;

        }

        private void CentrumButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.CentrumScreen(), sender);
        }

        private void ChallengeButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.ChallengeScreen(), sender);
        }

        private void PrzeczytaneButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.PrzeczytaneScreen(), sender);
        }

        private void StatystykiButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.StatystykiScreen(), sender);
        }

        private void TBRButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.TBRScreen(), sender);
        }

        private void UstawieniaButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new forms.UstawieniaScreen(), sender);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("dd.MM.yyyy.HH.mm.ss");
            Directory.CreateDirectory(@"./databaseBackup");
            File.Copy(@".\database.db", @".\databaseBackup\database" + time + ".db", true);
            this.Close();
        }
    }
}
