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
    partial class LicenseAgreementDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseAgreementDialog));
            this.ButtonAgree = new System.Windows.Forms.Button();
            this.ButtonDecline = new System.Windows.Forms.Button();
            this.License = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonAgree
            // 
            this.ButtonAgree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonAgree.Location = new System.Drawing.Point(298, 261);
            this.ButtonAgree.Name = "ButtonAgree";
            this.ButtonAgree.Size = new System.Drawing.Size(75, 21);
            this.ButtonAgree.TabIndex = 65;
            this.ButtonAgree.Text = "Agree";
            this.ButtonAgree.UseVisualStyleBackColor = true;
            this.ButtonAgree.Click += new System.EventHandler(this.ButtonAgree_Click);
            // 
            // ButtonDecline
            // 
            this.ButtonDecline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonDecline.Location = new System.Drawing.Point(379, 261);
            this.ButtonDecline.Name = "ButtonDecline";
            this.ButtonDecline.Size = new System.Drawing.Size(75, 21);
            this.ButtonDecline.TabIndex = 64;
            this.ButtonDecline.Text = "Decline";
            this.ButtonDecline.UseVisualStyleBackColor = true;
            this.ButtonDecline.Click += new System.EventHandler(this.ButtonDecline_Click);
            // 
            // License
            // 
            this.License.Location = new System.Drawing.Point(13, 12);
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.Size = new System.Drawing.Size(441, 238);
            this.License.TabIndex = 63;
            this.License.Text = resources.GetString("License.Text");
            // 
            // LicenseAgreementDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 291);
            this.Controls.Add(this.ButtonAgree);
            this.Controls.Add(this.ButtonDecline);
            this.Controls.Add(this.License);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseAgreementDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinShell License Agreement";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButtonAgree;
        public System.Windows.Forms.Button ButtonDecline;
        private System.Windows.Forms.RichTextBox License;
    }
}