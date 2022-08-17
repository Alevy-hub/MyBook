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

        private void ChallengeColorPanel_Click(object sender, EventArgs e)
        {
            Panel colorPanel = sender as Panel;
            ColorDialog colorDialog = new ColorDialog();
            
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;
            }
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
