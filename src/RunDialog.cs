/*
    WinShell

    Copyright (C) 2021 Danske

    This file is part of WinShell

    WinShell is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    WinShell is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with WinShell. If not, see <https://www.gnu.org/licenses/>.
*/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinShell
{
    public partial class RunDialog : Form
    {
        public RunDialog()
        {
            InitializeComponent();
        }

        private void RunDialog_Load(object sender, EventArgs e)
        {
            TextBoxFile.Focus();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(TextBoxFile.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("WinShell cannot find '" + TextBoxFile.Text + "'. Make sure you typed the name correctly, and then try again.", TextBoxFile.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Browse for process";
            ofd.Filter = "Programs (*.exe)|*.exe|All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxFile.Text = "\"" + ofd.FileName + "\"";
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            KeyEventArgs a = new KeyEventArgs(keyData);
            if (a.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
