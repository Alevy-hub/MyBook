using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBook.forms
{
    public partial class UstawieniaScreen : Form
    {

        public UstawieniaScreen()
        {
            InitializeComponent();
        }


        private void UstawieniaScreen_Load(object sender, EventArgs e)
        {
            ChallengeColor1Panel.BackColor = Properties.Settings.Default.color1;
            ChallengeColor2Panel.BackColor = Properties.Settings.Default.color2;
            ChallengeColor3Panel.BackColor = Properties.Settings.Default.color3;
            ChallengeColor4Panel.BackColor = Properties.Settings.Default.color4;
            ChallengeColor5Panel.BackColor = Properties.Settings.Default.color5;
        }

        private void ChallengeColor1Panel_Click(object sender, EventArgs e)
        {
            ColorDialog color1dialog = new ColorDialog();
            color1dialog.ShowDialog();
            ChallengeColor1Panel.BackColor = color1dialog.Color;
        }

        private void ChallengeColor2Panel_Click(object sender, EventArgs e)
        {
            ColorDialog color2dialog = new ColorDialog();
            color2dialog.ShowDialog();
            ChallengeColor2Panel.BackColor = color2dialog.Color;
        }

        private void ChallengeColor3Panel_Click(object sender, EventArgs e)
        {
            ColorDialog color3dialog = new ColorDialog();
            color3dialog.ShowDialog();
            ChallengeColor3Panel.BackColor = color3dialog.Color;
        }

        private void ChallengeColor4Panel_Click(object sender, EventArgs e)
        {
            ColorDialog color4dialog = new ColorDialog();
            color4dialog.ShowDialog();
            ChallengeColor4Panel.BackColor = color4dialog.Color;
        }

        private void ChallengeColor5Panel_Click(object sender, EventArgs e)
        {
            ColorDialog color5dialog = new ColorDialog();
            color5dialog.ShowDialog();
            ChallengeColor5Panel.BackColor = color5dialog.Color;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.color1 = ChallengeColor1Panel.BackColor;
            Properties.Settings.Default.color2 = ChallengeColor2Panel.BackColor;
            Properties.Settings.Default.color3 = ChallengeColor3Panel.BackColor;
            Properties.Settings.Default.color4 = ChallengeColor4Panel.BackColor;
            Properties.Settings.Default.color5 = ChallengeColor5Panel.BackColor;
            Properties.Settings.Default.Save();
        }

    }
}
