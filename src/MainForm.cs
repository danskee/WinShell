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
using System.IO;
using System.Net;
using System.Data;
using System.Linq;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace WinShell
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public string Folder = "";
        private bool allowVisible;
        public string newestver = "";
        WebClient wc = new WebClient();
        public bool checkforupdates = true;
        RunDialog RunDialog = new RunDialog();
        AboutDialog AboutDialog = new AboutDialog("1.0.0");
        LicenseAgreementDialog LicenseAgreementDialog = new LicenseAgreementDialog();
        RegistryKey Settings = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WinShell", true);

        public MainForm(string[] args)
        {
            InitializeComponent();

            // Copyright License
            if (Settings.GetValue("LicenseAccepted") != null)
            {
            }
            else
            {
                Settings.SetValue("LicenseAccepted", "False", RegistryValueKind.String);
            }

            if (Settings.GetValue("LicenseAccepted").ToString() == "False")
            {
                LicenseAgreementDialog.ShowDialog(this);
            }

            // Hotkey
            for (int i = 1; i < 6; i++)
            {
                TextBox textbox = Controls.Find("TextBoxHotkey" + i, true).FirstOrDefault() as TextBox;

                if (Settings.GetValue("Hotkey" + i) != null)
                {
                    textbox.Text = Settings.GetValue("Hotkey" + i).ToString();
                }
                else
                {
                    Settings.SetValue("Hotkey" + i, textbox.Text, RegistryValueKind.String);
                }

                RegisterHotkeys(textbox, i);
            }

            // Hotkey Enabled
            for (int i = 1; i < 6; i++)
            {
                CheckBox chkbox = Controls.Find("CheckBoxHotkey" + i, true).FirstOrDefault() as CheckBox;

                if (Settings.GetValue("Hotkey" + i + "Enabled") != null)
                {
                    if (Settings.GetValue("Hotkey" + i + "Enabled").ToString() == "True")
                    {
                        chkbox.Checked = true;
                    }
                    else if (Settings.GetValue("Hotkey" + i + "Enabled").ToString() == "False")
                    {
                        chkbox.Checked = false;
                    }

                }
                else
                {
                    chkbox.Checked = false;
                }

                DisableEnableHotkey(chkbox.Checked, i);
            }

            // Hotkey Action
            for (int i = 1; i < 6; i++)
            {
                ComboBox combobox = Controls.Find("ComboBoxAction" + i, true).FirstOrDefault() as ComboBox;

                if (Settings.GetValue("Hotkey" + i + "Action") != null)
                {
                    combobox.Text = Settings.GetValue("Hotkey" + i + "Action").ToString();
                }
                else
                {
                    combobox.Text = "Open the Run dialog";
                    Settings.SetValue("Hotkey" + i + "Enabled", combobox.Text, RegistryValueKind.String);
                }

                ActionSwitch(i);
            }

            // Processes to kill on startup
            if (Settings.GetValue("ProcessesToKillOnStartup") != null)
            {
                TextBoxProcessesToKillOnStartup.Text = Settings.GetValue("ProcessesToKillOnStartup").ToString();
            }
            else
            {
                TextBoxProcessesToKillOnStartup.Text = "";
            }

            // Process to start
            for (int i = 1; i < 6; i++)
            {
                TextBox textbox = Controls.Find("TextBoxProcess" + i, true).FirstOrDefault() as TextBox;

                if (Settings.GetValue("ProcessToStart" + i) != null)
                {
                    textbox.Text = Settings.GetValue("ProcessToStart" + i).ToString();
                }
                else
                {
                    textbox.Text = "";
                }
            }

            if (Settings.GetValue("FirstBoot") != null)
            {
                resize(false);
            }
            else
            {
                resize(true);
                MessageBox.Show("Use this GUI to configure settings. The next time you launch WinShell, this GUI won't pop up anymore unless you use the -settings argument.", "First startup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Settings.SetValue("FirstBoot", "False", RegistryValueKind.String);
            }

            string[] processes = TextBoxProcessesToKillOnStartup.Text.Split(',').Select(sValue => sValue.Trim()).ToArray();
            foreach (Process p in Process.GetProcesses())
            {
                foreach (string x in processes)
                {
                    if (x.Contains(p.ProcessName))
                    {
                        try
                        {
                            p.Kill();
                        }
                        catch
                        {
                        }
                    }
                }
            }

            foreach (Object o in args)
            {
                if (o.ToString() == "-settings")
                {
                    resize(true);
                }

                if (o.ToString() == "-noupdatechecks")
                {
                    checkforupdates = false;
                }
            }

            if (checkforupdates == true)
            {
                CheckForUpdates();
            }
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            Environment.Exit(0);
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutDialog.ShowDialog(this);
        }

        private void CheckBoxHotkey1_CheckedChanged(object sender, EventArgs e)
        {
            DisableEnableHotkey(CheckBoxHotkey1.Checked, 1);
        }

        private void CheckBoxHotkey2_CheckedChanged(object sender, EventArgs e)
        {
            DisableEnableHotkey(CheckBoxHotkey2.Checked, 2);
        }

        private void CheckBoxHotkey3_CheckedChanged(object sender, EventArgs e)
        {
            DisableEnableHotkey(CheckBoxHotkey3.Checked, 3);
        }

        private void CheckBoxHotkey4_CheckedChanged(object sender, EventArgs e)
        {
            DisableEnableHotkey(CheckBoxHotkey4.Checked, 4);
        }

        private void CheckBoxHotkey5_CheckedChanged(object sender, EventArgs e)
        {
            DisableEnableHotkey(CheckBoxHotkey5.Checked, 5);
        }

        private void TextBoxHotkey1_KeyDown(object sender, KeyEventArgs e)
        {
            RegisterHotkey(TextBoxHotkey1, 1, e);
        }

        private void TextBoxHotkey2_KeyDown(object sender, KeyEventArgs e)
        {
            RegisterHotkey(TextBoxHotkey2, 2, e);
        }

        private void TextBoxHotkey3_KeyDown(object sender, KeyEventArgs e)
        {
            RegisterHotkey(TextBoxHotkey3, 3, e);
        }

        private void TextBoxHotkey4_KeyDown(object sender, KeyEventArgs e)
        {
            RegisterHotkey(TextBoxHotkey4, 4, e);
        }

        private void TextBoxHotkey5_KeyDown(object sender, KeyEventArgs e)
        {
            RegisterHotkey(TextBoxHotkey5, 5, e);
        }

        private void ComboBoxAction1_TextChanged(object sender, EventArgs e)
        {
            ActionSwitch(1);
        }

        private void ComboBoxAction2_TextChanged(object sender, EventArgs e)
        {
            ActionSwitch(2);
        }

        private void ComboBoxAction3_TextChanged(object sender, EventArgs e)
        {
            ActionSwitch(3);
        }

        private void ComboBoxAction4_TextChanged(object sender, EventArgs e)
        {
            ActionSwitch(4);
        }

        private void ComboBoxAction5_TextChanged(object sender, EventArgs e)
        {
            ActionSwitch(5);
        }

        private void ComboBoxAction1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxAction2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxAction3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxAction4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ComboBoxAction5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ButtonBrowse1_Click(object sender, EventArgs e)
        {
            Browse(TextBoxProcess1, 1);
        }

        private void ButtonBrowse2_Click(object sender, EventArgs e)
        {
            Browse(TextBoxProcess2, 2);
        }

        private void ButtonBrowse3_Click(object sender, EventArgs e)
        {
            Browse(TextBoxProcess3, 3);
        }

        private void ButtonBrowse4_Click(object sender, EventArgs e)
        {
            Browse(TextBoxProcess4, 4);
        }

        private void ButtonBrowse5_Click(object sender, EventArgs e)
        {
            Browse(TextBoxProcess5, 5);
        }

        private void TextBoxProcess1_TextChanged(object sender, EventArgs e)
        {
            Settings.SetValue("ProcessToStart1", TextBoxProcess1.Text, RegistryValueKind.String);
        }

        private void TextBoxProcess2_TextChanged(object sender, EventArgs e)
        {
            Settings.SetValue("ProcessToStart2", TextBoxProcess2.Text, RegistryValueKind.String);
        }

        private void TextBoxProcess3_TextChanged(object sender, EventArgs e)
        {
            Settings.SetValue("ProcessToStart3", TextBoxProcess3.Text, RegistryValueKind.String);
        }

        private void TextBoxProcess4_TextChanged(object sender, EventArgs e)
        {
            Settings.SetValue("ProcessToStart4", TextBoxProcess4.Text, RegistryValueKind.String);
        }

        private void TextBoxProcess5_TextChanged(object sender, EventArgs e)
        {
            Settings.SetValue("ProcessToStart5", TextBoxProcess5.Text, RegistryValueKind.String);
        }

        private void TextBoxProcessesToKillOnStartup_TextChanged(object sender, EventArgs e)
        {
            Settings.SetValue("ProcessesToKillOnStartup", TextBoxProcessesToKillOnStartup.Text, RegistryValueKind.String);
        }

        private void ButtonResetSettings_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to reset all of the settings?", "WinShell", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    {
                        for (int i = 1; i < 6; i++)
                        {
                            CheckBox chkbox = Controls.Find("CheckBoxHotkey" + i, true).FirstOrDefault() as CheckBox;
                            TextBox textboxhk = Controls.Find("TextBoxHotkey" + i, true).FirstOrDefault() as TextBox;
                            ComboBox combobox = Controls.Find("ComboBoxAction" + i, true).FirstOrDefault() as ComboBox;
                            TextBox textboxp = Controls.Find("TextBoxProcess" + i, true).FirstOrDefault() as TextBox;
                            Button btnbrowse = Controls.Find("ButtonBrowse" + i, true).FirstOrDefault() as Button;

                            Settings.SetValue("Hotkey" + i + "Enabled", "True", RegistryValueKind.String);
                            Settings.SetValue("Hotkey" + i, "F" + i, RegistryValueKind.String);
                            Settings.SetValue("Hotkey" + i + "Action", "Open the Run dialog", RegistryValueKind.String);
                            Settings.SetValue("ProcessToStart" + i, "", RegistryValueKind.String);

                            chkbox.Checked = true;
                            textboxhk.Text = "F" + i;
                            textboxhk.Enabled = true;
                            combobox.Text = "Open the Run dialog";
                            combobox.Enabled = true;
                            textboxp.Text = "";
                            textboxp.Enabled = false;
                            btnbrowse.Enabled = false;
                            TextBoxProcessesToKillOnStartup.Text = "";

                            RegisterHotkeys(textboxhk, i);
                        }

                        break;
                    }
            }
        }

        private void ActionSwitch(int id)
        {
            TextBox textboxp = Controls.Find("TextBoxProcess" + id, true).FirstOrDefault() as TextBox;
            Button btnbrowse = Controls.Find("ButtonBrowse" + id, true).FirstOrDefault() as Button;
            ComboBox combobox = Controls.Find("ComboBoxAction" + id, true).FirstOrDefault() as ComboBox;

            switch (combobox.Text)
            {
                case "Open the Run dialog":
                    textboxp.Enabled = false;
                    btnbrowse.Enabled = false;
                    Settings.SetValue("Hotkey" + id + "Action", "Open the Run dialog", RegistryValueKind.String);
                    break;

                case "Start a custom process":
                    textboxp.Enabled = true;
                    btnbrowse.Enabled = true;
                    Settings.SetValue("Hotkey" + id + "Action", "Start a custom process", RegistryValueKind.String);
                    break;
            }
        }

        private void RegisterHotkeys(TextBox textbox, int i)
        {
            Keys a;

            Enum.TryParse(textbox.Text.Replace("Shift + ", "").Replace("Control + ", "").Replace("Alt + ", ""), out a);

            if (textbox.Text.Contains("Shift"))
            {
                UnregisterHotKey(this.Handle, i);
                RegisterHotKey(this.Handle, i, (int)4, a.GetHashCode());
            }
            else if (textbox.Text.Contains("Control"))
            {
                UnregisterHotKey(this.Handle, i);
                RegisterHotKey(this.Handle, i, (int)2, a.GetHashCode());
            }
            else if (textbox.Text.Contains("Alt"))
            {
                UnregisterHotKey(this.Handle, i);
                RegisterHotKey(this.Handle, i, (int)1, a.GetHashCode());
            }
            else
            {
                UnregisterHotKey(this.Handle, i);
                RegisterHotKey(this.Handle, i, (int)0, a.GetHashCode());
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        public void resize(bool maximize)
        {
            switch (maximize)
            {
                case true:
                    this.allowVisible = true;
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                    break;

                case false:
                    this.Hide();
                    this.WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void Browse(TextBox textbox, int id)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Browse for process";
            ofd.Filter = "Programs (*.exe)|*.exe|All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textbox.Text = ofd.FileName;
                Settings.SetValue("CustomProcess" + id, ofd.FileName, RegistryValueKind.String);
            }
        }

        private void RegisterHotkey(TextBox textbox, int id, KeyEventArgs e)
        {
            switch (Control.ModifierKeys)
            {
                case Keys.Shift:
                    if (e.KeyCode.ToString() == "ShiftKey")
                    {
                    }
                    else
                    {
                        UnregisterHotKey(this.Handle, id);
                        RegisterHotKey(this.Handle, id, (int)4, e.KeyCode.GetHashCode());
                        textbox.Text = "Shift + " + e.KeyCode.ToString();
                    }
                    break;

                case Keys.Control:
                    if (e.KeyCode.ToString() == "ControlKey")
                    {
                    }
                    else
                    {
                        UnregisterHotKey(this.Handle, id);
                        RegisterHotKey(this.Handle, id, (int)2, e.KeyCode.GetHashCode());
                        textbox.Text = "Control + " + e.KeyCode.ToString();
                    }
                    break;

                case Keys.Alt:
                    if (e.KeyCode.ToString() == "Menu")
                    {
                    }
                    else
                    {
                        UnregisterHotKey(this.Handle, id);
                        RegisterHotKey(this.Handle, id, (int)1, e.KeyCode.GetHashCode());
                        textbox.Text = "Alt + " + e.KeyCode.ToString();
                    }
                    break;

                default:
                    UnregisterHotKey(this.Handle, id);
                    RegisterHotKey(this.Handle, id, (int)0, e.KeyCode.GetHashCode());
                    textbox.Text = e.KeyCode.ToString();
                    break;
            }

            Settings.SetValue("Hotkey" + id, textbox.Text, RegistryValueKind.String);
        }

        private void DisableEnableHotkey(bool enabled, int id)
        {
            TextBox textboxhk = Controls.Find("TextBoxHotkey" + id, true).FirstOrDefault() as TextBox;
            ComboBox combobox = Controls.Find("ComboBoxAction" + id, true).FirstOrDefault() as ComboBox;
            TextBox textboxp = Controls.Find("TextBoxProcess" + id, true).FirstOrDefault() as TextBox;
            Button btn = Controls.Find("ButtonBrowse" + id, true).FirstOrDefault() as Button;

            switch (enabled)
            {
                case true:
                    switch (combobox.Text)
                    {
                        case "Open the Run dialog":
                            textboxp.Enabled = false;
                            btn.Enabled = false;
                            break;

                        case "Start a custom process":
                            textboxp.Enabled = true;
                            btn.Enabled = true;
                            break;
                    }

                    textboxhk.Enabled = true;
                    combobox.Enabled = true;
                    Settings.SetValue("Hotkey" + id + "Enabled", "True", RegistryValueKind.String);
                    RegisterHotkeys(textboxhk, id);
                    break;

                case false:
                    textboxhk.Enabled = false;
                    combobox.Enabled = false;
                    textboxp.Enabled = false;
                    btn.Enabled = false;
                    Settings.SetValue("Hotkey" + id + "Enabled", "False", RegistryValueKind.String);
                    UnregisterHotKey(this.Handle, id);
                    break;
            }
        }

        private void SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Folder = fbd.SelectedPath;
            }
            else if (fbd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Please select a folder where to download the newest version in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SelectFolder();
            }
        }

        private void CheckForUpdates()
        {
            int currentversion = Convert.ToInt32("1.0.0".Replace(".", ""));
            newestver = wc.DownloadString("https://raw.githubusercontent.com/danskee/WinShell/main/version").Replace("\n", "").Replace("\r", "");
            int newestversion = Convert.ToInt32(newestver.Replace(".", ""));

            if (currentversion < newestversion)
            {
                switch (MessageBox.Show("The version " + newestver + " is available. Download?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        DownloadNewestVersion();
                        break;
                }
            }
        }

        private void DownloadNewestVersion()
        {
            SelectFolder();

            try
            {
                wc.DownloadFile("https://github.com/danskee/WinShell/releases/download/v" + newestver + "/" + "WinShell-v" + newestver + ".zip", Folder + @"\" + "WinShell-v" + newestver + ".zip");
                ZipFile.ExtractToDirectory(Folder + @"\" + "WinShell-v" + newestver + ".zip", Folder);
                File.Delete(Folder + @"\" + "WinShell-v" + newestver + ".zip");
                MessageBox.Show("Succesfully downloaded the newest version in " + Folder + ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to download the newest version. Make sure you have a stable internet connection and that you're not trying to overwrite an already existing file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0x0312:
                    switch (m.WParam.ToInt32())
                    {
                        case 1:
                            ComboBox combobox1 = Controls.Find("ComboBoxAction" + m.WParam.ToInt32(), true).FirstOrDefault() as ComboBox;
                            TextBox txtboxp1 = Controls.Find("TextBoxProcess" + m.WParam.ToInt32(), true).FirstOrDefault() as TextBox;

                            switch (combobox1.Text)
                            {
                                case "Open the Run dialog":
                                    try
                                    {
                                        RunDialog.ShowDialog(this);
                                    }
                                    catch
                                    {
                                    }
                                    break;

                                case "Start a custom process":
                                    try
                                    {   
                                        Process.Start(txtboxp1.Text);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("WinShell cannot find '" + txtboxp1.Text + "'. Make sure you typed the name correctly, and then try again.", txtboxp1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                            }
                            break;

                        case 2:
                            ComboBox combobox2 = Controls.Find("ComboBoxAction" + m.WParam.ToInt32(), true).FirstOrDefault() as ComboBox;
                            TextBox txtboxp2 = Controls.Find("TextBoxProcess" + m.WParam.ToInt32(), true).FirstOrDefault() as TextBox;

                            switch (combobox2.Text)
                            {
                                case "Open the Run dialog":
                                    try
                                    {
                                        RunDialog.ShowDialog(this);
                                    }
                                    catch
                                    {
                                    }
                                    break;

                                case "Start a custom process":
                                    try
                                    {
                                        Process.Start(txtboxp2.Text);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("WinShell cannot find '" + txtboxp2.Text + "'. Make sure you typed the name correctly, and then try again.", txtboxp2.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                            }
                            break;

                        case 3:
                            ComboBox combobox3 = Controls.Find("ComboBoxAction" + m.WParam.ToInt32(), true).FirstOrDefault() as ComboBox;
                            TextBox txtboxp3 = Controls.Find("TextBoxProcess" + m.WParam.ToInt32(), true).FirstOrDefault() as TextBox;

                            switch (combobox3.Text)
                            {
                                case "Open the Run dialog":
                                    try
                                    {
                                        RunDialog.ShowDialog(this);
                                    }
                                    catch
                                    {
                                    }
                                    break;

                                case "Start a custom process":
                                    try
                                    {
                                        Process.Start(txtboxp3.Text);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("WinShell cannot find '" + txtboxp3.Text + "'. Make sure you typed the name correctly, and then try again.", txtboxp3.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                            }
                            break;

                        case 4:
                            ComboBox combobox4 = Controls.Find("ComboBoxAction" + m.WParam.ToInt32(), true).FirstOrDefault() as ComboBox;
                            TextBox txtboxp4 = Controls.Find("TextBoxProcess" + m.WParam.ToInt32(), true).FirstOrDefault() as TextBox;

                            switch (combobox4.Text)
                            {
                                case "Open the Run dialog":
                                    try
                                    {
                                        RunDialog.ShowDialog(this);
                                    }
                                    catch
                                    {
                                    }
                                    break;

                                case "Start a custom process":
                                    try
                                    {
                                        Process.Start(txtboxp4.Text);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("WinShell cannot find '" + txtboxp4.Text + "'. Make sure you typed the name correctly, and then try again.", txtboxp4.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                            }
                            break;

                        case 5:
                            ComboBox combobox5 = Controls.Find("ComboBoxAction" + m.WParam.ToInt32(), true).FirstOrDefault() as ComboBox;
                            TextBox txtboxp5 = Controls.Find("TextBoxProcess" + m.WParam.ToInt32(), true).FirstOrDefault() as TextBox;

                            switch (combobox5.Text)
                            {
                                case "Open the Run dialog":
                                    try
                                    {
                                        RunDialog.ShowDialog(this);
                                    }
                                    catch
                                    {
                                    }
                                    break;

                                case "Start a custom process":
                                    try
                                    {
                                        Process.Start(txtboxp5.Text);
                                    }
                                    catch
                                    {
                                        MessageBox.Show("WinShell cannot find '" + txtboxp5.Text + "'. Make sure you typed the name correctly, and then try again.", txtboxp5.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
    }
}
