﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Reflection;
using System.Windows.Forms;

namespace GitUI
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://sourceforge.net/donate/index.php?group_id=246547");
        }

    }
}
