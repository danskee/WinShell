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

namespace WinShell
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextBoxHotkey1 = new System.Windows.Forms.TextBox();
            this.LabelAction1 = new System.Windows.Forms.Label();
            this.ComboBoxAction1 = new System.Windows.Forms.ComboBox();
            this.LabelProcess1 = new System.Windows.Forms.Label();
            this.TextBoxProcess1 = new System.Windows.Forms.TextBox();
            this.ButtonBrowse1 = new System.Windows.Forms.Button();
            this.ButtonBrowse2 = new System.Windows.Forms.Button();
            this.TextBoxProcess2 = new System.Windows.Forms.TextBox();
            this.LabelProcess2 = new System.Windows.Forms.Label();
            this.ComboBoxAction2 = new System.Windows.Forms.ComboBox();
            this.LabelAction2 = new System.Windows.Forms.Label();
            this.TextBoxHotkey2 = new System.Windows.Forms.TextBox();
            this.ButtonBrowse3 = new System.Windows.Forms.Button();
            this.TextBoxProcess3 = new System.Windows.Forms.TextBox();
            this.LabelProcess3 = new System.Windows.Forms.Label();
            this.ComboBoxAction3 = new System.Windows.Forms.ComboBox();
            this.LabelAction3 = new System.Windows.Forms.Label();
            this.TextBoxHotkey3 = new System.Windows.Forms.TextBox();
            this.ButtonBrowse4 = new System.Windows.Forms.Button();
            this.TextBoxProcess4 = new System.Windows.Forms.TextBox();
            this.LabelProcess4 = new System.Windows.Forms.Label();
            this.ComboBoxAction4 = new System.Windows.Forms.ComboBox();
            this.LabelAction4 = new System.Windows.Forms.Label();
            this.TextBoxHotkey4 = new System.Windows.Forms.TextBox();
            this.ButtonBrowse5 = new System.Windows.Forms.Button();
            this.TextBoxProcess5 = new System.Windows.Forms.TextBox();
            this.LabelProcess5 = new System.Windows.Forms.Label();
            this.ComboBoxAction5 = new System.Windows.Forms.ComboBox();
            this.LabelAction5 = new System.Windows.Forms.Label();
            this.TextBoxHotkey5 = new System.Windows.Forms.TextBox();
            this.LabelProcessesToKillOnStartup = new System.Windows.Forms.Label();
            this.TextBoxProcessesToKillOnStartup = new System.Windows.Forms.TextBox();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.menustrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckBoxHotkey1 = new System.Windows.Forms.CheckBox();
            this.CheckBoxHotkey3 = new System.Windows.Forms.CheckBox();
            this.CheckBoxHotkey2 = new System.Windows.Forms.CheckBox();
            this.CheckBoxHotkey4 = new System.Windows.Forms.CheckBox();
            this.CheckBoxHotkey5 = new System.Windows.Forms.CheckBox();
            this.ButtonResetSettings = new System.Windows.Forms.Button();
            this.menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxHotkey1
            // 
            this.TextBoxHotkey1.Location = new System.Drawing.Point(96, 41);
            this.TextBoxHotkey1.Name = "TextBoxHotkey1";
            this.TextBoxHotkey1.ReadOnly = true;
            this.TextBoxHotkey1.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHotkey1.TabIndex = 1;
            this.TextBoxHotkey1.Text = "F1";
            this.TextBoxHotkey1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHotkey1_KeyDown);
            // 
            // LabelAction1
            // 
            this.LabelAction1.AutoSize = true;
            this.LabelAction1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelAction1.Location = new System.Drawing.Point(199, 24);
            this.LabelAction1.Name = "LabelAction1";
            this.LabelAction1.Size = new System.Drawing.Size(40, 13);
            this.LabelAction1.TabIndex = 2;
            this.LabelAction1.Text = "Action:";
            // 
            // ComboBoxAction1
            // 
            this.ComboBoxAction1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxAction1.FormattingEnabled = true;
            this.ComboBoxAction1.Items.AddRange(new object[] {
            "Open the Run dialog",
            "Start a custom process"});
            this.ComboBoxAction1.Location = new System.Drawing.Point(202, 40);
            this.ComboBoxAction1.Name = "ComboBoxAction1";
            this.ComboBoxAction1.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxAction1.TabIndex = 3;
            this.ComboBoxAction1.Text = "Open the Run dialog";
            this.ComboBoxAction1.TextChanged += new System.EventHandler(this.ComboBoxAction1_TextChanged);
            this.ComboBoxAction1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxAction1_KeyPress);
            // 
            // LabelProcess1
            // 
            this.LabelProcess1.AutoSize = true;
            this.LabelProcess1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelProcess1.Location = new System.Drawing.Point(345, 24);
            this.LabelProcess1.Name = "LabelProcess1";
            this.LabelProcess1.Size = new System.Drawing.Size(83, 13);
            this.LabelProcess1.TabIndex = 4;
            this.LabelProcess1.Text = "Process to start:";
            // 
            // TextBoxProcess1
            // 
            this.TextBoxProcess1.Enabled = false;
            this.TextBoxProcess1.Location = new System.Drawing.Point(348, 40);
            this.TextBoxProcess1.Name = "TextBoxProcess1";
            this.TextBoxProcess1.Size = new System.Drawing.Size(282, 20);
            this.TextBoxProcess1.TabIndex = 5;
            this.TextBoxProcess1.TextChanged += new System.EventHandler(this.TextBoxProcess1_TextChanged);
            // 
            // ButtonBrowse1
            // 
            this.ButtonBrowse1.Enabled = false;
            this.ButtonBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse1.Location = new System.Drawing.Point(636, 40);
            this.ButtonBrowse1.Name = "ButtonBrowse1";
            this.ButtonBrowse1.Size = new System.Drawing.Size(75, 20);
            this.ButtonBrowse1.TabIndex = 6;
            this.ButtonBrowse1.Text = "Browse..";
            this.ButtonBrowse1.UseVisualStyleBackColor = true;
            this.ButtonBrowse1.Click += new System.EventHandler(this.ButtonBrowse1_Click);
            // 
            // ButtonBrowse2
            // 
            this.ButtonBrowse2.Enabled = false;
            this.ButtonBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse2.Location = new System.Drawing.Point(636, 84);
            this.ButtonBrowse2.Name = "ButtonBrowse2";
            this.ButtonBrowse2.Size = new System.Drawing.Size(75, 20);
            this.ButtonBrowse2.TabIndex = 13;
            this.ButtonBrowse2.Text = "Browse..";
            this.ButtonBrowse2.UseVisualStyleBackColor = true;
            this.ButtonBrowse2.Click += new System.EventHandler(this.ButtonBrowse2_Click);
            // 
            // TextBoxProcess2
            // 
            this.TextBoxProcess2.Enabled = false;
            this.TextBoxProcess2.Location = new System.Drawing.Point(348, 85);
            this.TextBoxProcess2.Name = "TextBoxProcess2";
            this.TextBoxProcess2.Size = new System.Drawing.Size(282, 20);
            this.TextBoxProcess2.TabIndex = 12;
            this.TextBoxProcess2.TextChanged += new System.EventHandler(this.TextBoxProcess2_TextChanged);
            // 
            // LabelProcess2
            // 
            this.LabelProcess2.AutoSize = true;
            this.LabelProcess2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelProcess2.Location = new System.Drawing.Point(345, 69);
            this.LabelProcess2.Name = "LabelProcess2";
            this.LabelProcess2.Size = new System.Drawing.Size(83, 13);
            this.LabelProcess2.TabIndex = 11;
            this.LabelProcess2.Text = "Process to start:";
            // 
            // ComboBoxAction2
            // 
            this.ComboBoxAction2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxAction2.FormattingEnabled = true;
            this.ComboBoxAction2.Items.AddRange(new object[] {
            "Open the Run dialog",
            "Start a custom process"});
            this.ComboBoxAction2.Location = new System.Drawing.Point(202, 84);
            this.ComboBoxAction2.Name = "ComboBoxAction2";
            this.ComboBoxAction2.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxAction2.TabIndex = 10;
            this.ComboBoxAction2.Text = "Open the Run dialog";
            this.ComboBoxAction2.TextChanged += new System.EventHandler(this.ComboBoxAction2_TextChanged);
            this.ComboBoxAction2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxAction2_KeyPress);
            // 
            // LabelAction2
            // 
            this.LabelAction2.AutoSize = true;
            this.LabelAction2.Location = new System.Drawing.Point(199, 68);
            this.LabelAction2.Name = "LabelAction2";
            this.LabelAction2.Size = new System.Drawing.Size(40, 13);
            this.LabelAction2.TabIndex = 9;
            this.LabelAction2.Text = "Action:";
            // 
            // TextBoxHotkey2
            // 
            this.TextBoxHotkey2.Location = new System.Drawing.Point(96, 84);
            this.TextBoxHotkey2.Name = "TextBoxHotkey2";
            this.TextBoxHotkey2.ReadOnly = true;
            this.TextBoxHotkey2.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHotkey2.TabIndex = 8;
            this.TextBoxHotkey2.Text = "F2";
            this.TextBoxHotkey2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHotkey2_KeyDown);
            // 
            // ButtonBrowse3
            // 
            this.ButtonBrowse3.Enabled = false;
            this.ButtonBrowse3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse3.Location = new System.Drawing.Point(636, 130);
            this.ButtonBrowse3.Name = "ButtonBrowse3";
            this.ButtonBrowse3.Size = new System.Drawing.Size(75, 20);
            this.ButtonBrowse3.TabIndex = 20;
            this.ButtonBrowse3.Text = "Browse..";
            this.ButtonBrowse3.UseVisualStyleBackColor = true;
            this.ButtonBrowse3.Click += new System.EventHandler(this.ButtonBrowse3_Click);
            // 
            // TextBoxProcess3
            // 
            this.TextBoxProcess3.Enabled = false;
            this.TextBoxProcess3.Location = new System.Drawing.Point(348, 130);
            this.TextBoxProcess3.Name = "TextBoxProcess3";
            this.TextBoxProcess3.Size = new System.Drawing.Size(282, 20);
            this.TextBoxProcess3.TabIndex = 19;
            this.TextBoxProcess3.TextChanged += new System.EventHandler(this.TextBoxProcess3_TextChanged);
            // 
            // LabelProcess3
            // 
            this.LabelProcess3.AutoSize = true;
            this.LabelProcess3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelProcess3.Location = new System.Drawing.Point(345, 114);
            this.LabelProcess3.Name = "LabelProcess3";
            this.LabelProcess3.Size = new System.Drawing.Size(83, 13);
            this.LabelProcess3.TabIndex = 18;
            this.LabelProcess3.Text = "Process to start:";
            // 
            // ComboBoxAction3
            // 
            this.ComboBoxAction3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxAction3.FormattingEnabled = true;
            this.ComboBoxAction3.Items.AddRange(new object[] {
            "Open the Run dialog",
            "Start a custom process"});
            this.ComboBoxAction3.Location = new System.Drawing.Point(202, 129);
            this.ComboBoxAction3.Name = "ComboBoxAction3";
            this.ComboBoxAction3.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxAction3.TabIndex = 17;
            this.ComboBoxAction3.Text = "Open the Run dialog";
            this.ComboBoxAction3.TextChanged += new System.EventHandler(this.ComboBoxAction3_TextChanged);
            this.ComboBoxAction3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxAction3_KeyPress);
            // 
            // LabelAction3
            // 
            this.LabelAction3.AutoSize = true;
            this.LabelAction3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelAction3.Location = new System.Drawing.Point(199, 114);
            this.LabelAction3.Name = "LabelAction3";
            this.LabelAction3.Size = new System.Drawing.Size(40, 13);
            this.LabelAction3.TabIndex = 16;
            this.LabelAction3.Text = "Action:";
            // 
            // TextBoxHotkey3
            // 
            this.TextBoxHotkey3.Location = new System.Drawing.Point(96, 130);
            this.TextBoxHotkey3.Name = "TextBoxHotkey3";
            this.TextBoxHotkey3.ReadOnly = true;
            this.TextBoxHotkey3.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHotkey3.TabIndex = 15;
            this.TextBoxHotkey3.Text = "F3";
            this.TextBoxHotkey3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHotkey3_KeyDown);
            // 
            // ButtonBrowse4
            // 
            this.ButtonBrowse4.Enabled = false;
            this.ButtonBrowse4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse4.Location = new System.Drawing.Point(636, 175);
            this.ButtonBrowse4.Name = "ButtonBrowse4";
            this.ButtonBrowse4.Size = new System.Drawing.Size(75, 20);
            this.ButtonBrowse4.TabIndex = 27;
            this.ButtonBrowse4.Text = "Browse..";
            this.ButtonBrowse4.UseVisualStyleBackColor = true;
            this.ButtonBrowse4.Click += new System.EventHandler(this.ButtonBrowse4_Click);
            // 
            // TextBoxProcess4
            // 
            this.TextBoxProcess4.Enabled = false;
            this.TextBoxProcess4.Location = new System.Drawing.Point(348, 175);
            this.TextBoxProcess4.Name = "TextBoxProcess4";
            this.TextBoxProcess4.Size = new System.Drawing.Size(282, 20);
            this.TextBoxProcess4.TabIndex = 26;
            this.TextBoxProcess4.TextChanged += new System.EventHandler(this.TextBoxProcess4_TextChanged);
            // 
            // LabelProcess4
            // 
            this.LabelProcess4.AutoSize = true;
            this.LabelProcess4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelProcess4.Location = new System.Drawing.Point(345, 159);
            this.LabelProcess4.Name = "LabelProcess4";
            this.LabelProcess4.Size = new System.Drawing.Size(83, 13);
            this.LabelProcess4.TabIndex = 25;
            this.LabelProcess4.Text = "Process to start:";
            // 
            // ComboBoxAction4
            // 
            this.ComboBoxAction4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxAction4.FormattingEnabled = true;
            this.ComboBoxAction4.Items.AddRange(new object[] {
            "Open the Run dialog",
            "Start a custom process"});
            this.ComboBoxAction4.Location = new System.Drawing.Point(202, 175);
            this.ComboBoxAction4.Name = "ComboBoxAction4";
            this.ComboBoxAction4.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxAction4.TabIndex = 24;
            this.ComboBoxAction4.Text = "Open the Run dialog";
            this.ComboBoxAction4.TextChanged += new System.EventHandler(this.ComboBoxAction4_TextChanged);
            this.ComboBoxAction4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxAction4_KeyPress);
            // 
            // LabelAction4
            // 
            this.LabelAction4.AutoSize = true;
            this.LabelAction4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelAction4.Location = new System.Drawing.Point(199, 159);
            this.LabelAction4.Name = "LabelAction4";
            this.LabelAction4.Size = new System.Drawing.Size(40, 13);
            this.LabelAction4.TabIndex = 23;
            this.LabelAction4.Text = "Action:";
            // 
            // TextBoxHotkey4
            // 
            this.TextBoxHotkey4.Location = new System.Drawing.Point(96, 176);
            this.TextBoxHotkey4.Name = "TextBoxHotkey4";
            this.TextBoxHotkey4.ReadOnly = true;
            this.TextBoxHotkey4.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHotkey4.TabIndex = 22;
            this.TextBoxHotkey4.Text = "F4";
            this.TextBoxHotkey4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHotkey4_KeyDown);
            // 
            // ButtonBrowse5
            // 
            this.ButtonBrowse5.Enabled = false;
            this.ButtonBrowse5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonBrowse5.Location = new System.Drawing.Point(636, 221);
            this.ButtonBrowse5.Name = "ButtonBrowse5";
            this.ButtonBrowse5.Size = new System.Drawing.Size(75, 20);
            this.ButtonBrowse5.TabIndex = 34;
            this.ButtonBrowse5.Text = "Browse..";
            this.ButtonBrowse5.UseVisualStyleBackColor = true;
            this.ButtonBrowse5.Click += new System.EventHandler(this.ButtonBrowse5_Click);
            // 
            // TextBoxProcess5
            // 
            this.TextBoxProcess5.Enabled = false;
            this.TextBoxProcess5.Location = new System.Drawing.Point(348, 221);
            this.TextBoxProcess5.Name = "TextBoxProcess5";
            this.TextBoxProcess5.Size = new System.Drawing.Size(282, 20);
            this.TextBoxProcess5.TabIndex = 33;
            this.TextBoxProcess5.TextChanged += new System.EventHandler(this.TextBoxProcess5_TextChanged);
            // 
            // LabelProcess5
            // 
            this.LabelProcess5.AutoSize = true;
            this.LabelProcess5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelProcess5.Location = new System.Drawing.Point(345, 205);
            this.LabelProcess5.Name = "LabelProcess5";
            this.LabelProcess5.Size = new System.Drawing.Size(83, 13);
            this.LabelProcess5.TabIndex = 32;
            this.LabelProcess5.Text = "Process to start:";
            // 
            // ComboBoxAction5
            // 
            this.ComboBoxAction5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ComboBoxAction5.FormattingEnabled = true;
            this.ComboBoxAction5.Items.AddRange(new object[] {
            "Open the Run dialog",
            "Start a custom process"});
            this.ComboBoxAction5.Location = new System.Drawing.Point(202, 219);
            this.ComboBoxAction5.Name = "ComboBoxAction5";
            this.ComboBoxAction5.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxAction5.TabIndex = 31;
            this.ComboBoxAction5.Text = "Open the Run dialog";
            this.ComboBoxAction5.TextChanged += new System.EventHandler(this.ComboBoxAction5_TextChanged);
            // 
            // LabelAction5
            // 
            this.LabelAction5.AutoSize = true;
            this.LabelAction5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelAction5.Location = new System.Drawing.Point(199, 203);
            this.LabelAction5.Name = "LabelAction5";
            this.LabelAction5.Size = new System.Drawing.Size(40, 13);
            this.LabelAction5.TabIndex = 30;
            this.LabelAction5.Text = "Action:";
            // 
            // TextBoxHotkey5
            // 
            this.TextBoxHotkey5.Location = new System.Drawing.Point(96, 220);
            this.TextBoxHotkey5.Name = "TextBoxHotkey5";
            this.TextBoxHotkey5.ReadOnly = true;
            this.TextBoxHotkey5.Size = new System.Drawing.Size(100, 20);
            this.TextBoxHotkey5.TabIndex = 29;
            this.TextBoxHotkey5.Text = "F5";
            this.TextBoxHotkey5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxHotkey5_KeyDown);
            // 
            // LabelProcessesToKillOnStartup
            // 
            this.LabelProcessesToKillOnStartup.AutoSize = true;
            this.LabelProcessesToKillOnStartup.Location = new System.Drawing.Point(9, 256);
            this.LabelProcessesToKillOnStartup.Name = "LabelProcessesToKillOnStartup";
            this.LabelProcessesToKillOnStartup.Size = new System.Drawing.Size(136, 13);
            this.LabelProcessesToKillOnStartup.TabIndex = 35;
            this.LabelProcessesToKillOnStartup.Text = "Processes to kill on startup:";
            this.tooltip.SetToolTip(this.LabelProcessesToKillOnStartup, "The processes to kill on startup of WinShell.\r\nSeperate with a comma ( , ). Examp" +
        "le:\r\nexplorer, sppsvc");
            // 
            // TextBoxProcessesToKillOnStartup
            // 
            this.TextBoxProcessesToKillOnStartup.Location = new System.Drawing.Point(12, 272);
            this.TextBoxProcessesToKillOnStartup.Multiline = true;
            this.TextBoxProcessesToKillOnStartup.Name = "TextBoxProcessesToKillOnStartup";
            this.TextBoxProcessesToKillOnStartup.Size = new System.Drawing.Size(699, 93);
            this.TextBoxProcessesToKillOnStartup.TabIndex = 36;
            this.TextBoxProcessesToKillOnStartup.TextChanged += new System.EventHandler(this.TextBoxProcessesToKillOnStartup_TextChanged);
            // 
            // menustrip
            // 
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(727, 24);
            this.menustrip.TabIndex = 37;
            this.menustrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(92, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "Help";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuItemAbout.Text = "About";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // CheckBoxHotkey1
            // 
            this.CheckBoxHotkey1.AutoSize = true;
            this.CheckBoxHotkey1.Checked = true;
            this.CheckBoxHotkey1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHotkey1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxHotkey1.Location = new System.Drawing.Point(12, 41);
            this.CheckBoxHotkey1.Name = "CheckBoxHotkey1";
            this.CheckBoxHotkey1.Size = new System.Drawing.Size(78, 18);
            this.CheckBoxHotkey1.TabIndex = 38;
            this.CheckBoxHotkey1.Text = "Hotkey 1:";
            this.CheckBoxHotkey1.UseVisualStyleBackColor = true;
            this.CheckBoxHotkey1.CheckedChanged += new System.EventHandler(this.CheckBoxHotkey1_CheckedChanged);
            // 
            // CheckBoxHotkey3
            // 
            this.CheckBoxHotkey3.AutoSize = true;
            this.CheckBoxHotkey3.Checked = true;
            this.CheckBoxHotkey3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHotkey3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxHotkey3.Location = new System.Drawing.Point(12, 130);
            this.CheckBoxHotkey3.Name = "CheckBoxHotkey3";
            this.CheckBoxHotkey3.Size = new System.Drawing.Size(78, 18);
            this.CheckBoxHotkey3.TabIndex = 39;
            this.CheckBoxHotkey3.Text = "Hotkey 3:";
            this.CheckBoxHotkey3.UseVisualStyleBackColor = true;
            this.CheckBoxHotkey3.CheckedChanged += new System.EventHandler(this.CheckBoxHotkey3_CheckedChanged);
            // 
            // CheckBoxHotkey2
            // 
            this.CheckBoxHotkey2.AutoSize = true;
            this.CheckBoxHotkey2.Checked = true;
            this.CheckBoxHotkey2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHotkey2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxHotkey2.Location = new System.Drawing.Point(12, 85);
            this.CheckBoxHotkey2.Name = "CheckBoxHotkey2";
            this.CheckBoxHotkey2.Size = new System.Drawing.Size(78, 18);
            this.CheckBoxHotkey2.TabIndex = 40;
            this.CheckBoxHotkey2.Text = "Hotkey 2:";
            this.CheckBoxHotkey2.UseVisualStyleBackColor = true;
            this.CheckBoxHotkey2.CheckedChanged += new System.EventHandler(this.CheckBoxHotkey2_CheckedChanged);
            // 
            // CheckBoxHotkey4
            // 
            this.CheckBoxHotkey4.AutoSize = true;
            this.CheckBoxHotkey4.Checked = true;
            this.CheckBoxHotkey4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHotkey4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxHotkey4.Location = new System.Drawing.Point(12, 176);
            this.CheckBoxHotkey4.Name = "CheckBoxHotkey4";
            this.CheckBoxHotkey4.Size = new System.Drawing.Size(78, 18);
            this.CheckBoxHotkey4.TabIndex = 41;
            this.CheckBoxHotkey4.Text = "Hotkey 4:";
            this.CheckBoxHotkey4.UseVisualStyleBackColor = true;
            this.CheckBoxHotkey4.CheckedChanged += new System.EventHandler(this.CheckBoxHotkey4_CheckedChanged);
            // 
            // CheckBoxHotkey5
            // 
            this.CheckBoxHotkey5.AutoSize = true;
            this.CheckBoxHotkey5.Checked = true;
            this.CheckBoxHotkey5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxHotkey5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxHotkey5.Location = new System.Drawing.Point(12, 221);
            this.CheckBoxHotkey5.Name = "CheckBoxHotkey5";
            this.CheckBoxHotkey5.Size = new System.Drawing.Size(78, 18);
            this.CheckBoxHotkey5.TabIndex = 42;
            this.CheckBoxHotkey5.Text = "Hotkey 5:";
            this.CheckBoxHotkey5.UseVisualStyleBackColor = true;
            this.CheckBoxHotkey5.CheckedChanged += new System.EventHandler(this.CheckBoxHotkey5_CheckedChanged);
            // 
            // ButtonResetSettings
            // 
            this.ButtonResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonResetSettings.Location = new System.Drawing.Point(13, 372);
            this.ButtonResetSettings.Name = "ButtonResetSettings";
            this.ButtonResetSettings.Size = new System.Drawing.Size(698, 23);
            this.ButtonResetSettings.TabIndex = 43;
            this.ButtonResetSettings.Text = "Reset settings";
            this.ButtonResetSettings.UseVisualStyleBackColor = true;
            this.ButtonResetSettings.Click += new System.EventHandler(this.ButtonResetSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 412);
            this.Controls.Add(this.ButtonResetSettings);
            this.Controls.Add(this.CheckBoxHotkey5);
            this.Controls.Add(this.CheckBoxHotkey4);
            this.Controls.Add(this.CheckBoxHotkey2);
            this.Controls.Add(this.CheckBoxHotkey3);
            this.Controls.Add(this.CheckBoxHotkey1);
            this.Controls.Add(this.TextBoxProcessesToKillOnStartup);
            this.Controls.Add(this.LabelProcessesToKillOnStartup);
            this.Controls.Add(this.ButtonBrowse5);
            this.Controls.Add(this.TextBoxProcess5);
            this.Controls.Add(this.LabelProcess5);
            this.Controls.Add(this.ComboBoxAction5);
            this.Controls.Add(this.LabelAction5);
            this.Controls.Add(this.TextBoxHotkey5);
            this.Controls.Add(this.ButtonBrowse4);
            this.Controls.Add(this.TextBoxProcess4);
            this.Controls.Add(this.LabelProcess4);
            this.Controls.Add(this.ComboBoxAction4);
            this.Controls.Add(this.LabelAction4);
            this.Controls.Add(this.TextBoxHotkey4);
            this.Controls.Add(this.ButtonBrowse3);
            this.Controls.Add(this.TextBoxProcess3);
            this.Controls.Add(this.LabelProcess3);
            this.Controls.Add(this.ComboBoxAction3);
            this.Controls.Add(this.LabelAction3);
            this.Controls.Add(this.TextBoxHotkey3);
            this.Controls.Add(this.ButtonBrowse2);
            this.Controls.Add(this.TextBoxProcess2);
            this.Controls.Add(this.LabelProcess2);
            this.Controls.Add(this.ComboBoxAction2);
            this.Controls.Add(this.LabelAction2);
            this.Controls.Add(this.TextBoxHotkey2);
            this.Controls.Add(this.ButtonBrowse1);
            this.Controls.Add(this.TextBoxProcess1);
            this.Controls.Add(this.LabelProcess1);
            this.Controls.Add(this.ComboBoxAction1);
            this.Controls.Add(this.LabelAction1);
            this.Controls.Add(this.TextBoxHotkey1);
            this.Controls.Add(this.menustrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menustrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinShell Settings";
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxHotkey1;
        private System.Windows.Forms.Label LabelAction1;
        private System.Windows.Forms.ComboBox ComboBoxAction1;
        private System.Windows.Forms.Label LabelProcess1;
        private System.Windows.Forms.TextBox TextBoxProcess1;
        private System.Windows.Forms.Button ButtonBrowse1;
        private System.Windows.Forms.Button ButtonBrowse2;
        private System.Windows.Forms.TextBox TextBoxProcess2;
        private System.Windows.Forms.Label LabelProcess2;
        private System.Windows.Forms.ComboBox ComboBoxAction2;
        private System.Windows.Forms.Label LabelAction2;
        private System.Windows.Forms.TextBox TextBoxHotkey2;
        private System.Windows.Forms.Button ButtonBrowse3;
        private System.Windows.Forms.TextBox TextBoxProcess3;
        private System.Windows.Forms.Label LabelProcess3;
        private System.Windows.Forms.ComboBox ComboBoxAction3;
        private System.Windows.Forms.Label LabelAction3;
        private System.Windows.Forms.TextBox TextBoxHotkey3;
        private System.Windows.Forms.Button ButtonBrowse4;
        private System.Windows.Forms.TextBox TextBoxProcess4;
        private System.Windows.Forms.Label LabelProcess4;
        private System.Windows.Forms.ComboBox ComboBoxAction4;
        private System.Windows.Forms.Label LabelAction4;
        private System.Windows.Forms.TextBox TextBoxHotkey4;
        private System.Windows.Forms.Button ButtonBrowse5;
        private System.Windows.Forms.TextBox TextBoxProcess5;
        private System.Windows.Forms.Label LabelProcess5;
        private System.Windows.Forms.ComboBox ComboBoxAction5;
        private System.Windows.Forms.Label LabelAction5;
        private System.Windows.Forms.TextBox TextBoxHotkey5;
        private System.Windows.Forms.Label LabelProcessesToKillOnStartup;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.TextBox TextBoxProcessesToKillOnStartup;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.CheckBox CheckBoxHotkey1;
        private System.Windows.Forms.CheckBox CheckBoxHotkey3;
        private System.Windows.Forms.CheckBox CheckBoxHotkey2;
        private System.Windows.Forms.CheckBox CheckBoxHotkey4;
        private System.Windows.Forms.CheckBox CheckBoxHotkey5;
        private System.Windows.Forms.Button ButtonResetSettings;
    }
}

