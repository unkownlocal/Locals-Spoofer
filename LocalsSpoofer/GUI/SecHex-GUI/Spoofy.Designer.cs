﻿namespace SecHex_GUI
{
    partial class Spoofy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spoofy));
            disk = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            mac = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            pcname = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            winid = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            GUID = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            display = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            efi = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            sm = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            req = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            spoofall = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            product = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            tracercl = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            backup = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            systemcleaner = new MetroFramework.Controls.MetroCheckBox();
            logwind = new MetroFramework.Controls.MetroCheckBox();
            lgbt = new MetroFramework.Controls.MetroCheckBox();
            metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            SuspendLayout();
            // 
            // disk
            // 
            disk.Animated = true;
            disk.AutoRoundedCorners = true;
            disk.BackColor = Color.Transparent;
            disk.BorderColor = Color.White;
            disk.BorderRadius = 15;
            disk.BorderThickness = 1;
            disk.CustomBorderColor = Color.Transparent;
            disk.DisabledState.BorderColor = Color.DarkGray;
            disk.DisabledState.CustomBorderColor = Color.DarkGray;
            disk.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            disk.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            disk.FillColor = Color.Transparent;
            disk.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            disk.ForeColor = Color.White;
            disk.Location = new Point(12, 83);
            disk.Name = "disk";
            disk.PressedDepth = 60;
            disk.ShadowDecoration.Depth = 50;
            disk.Size = new Size(157, 32);
            disk.TabIndex = 2;
            disk.Text = "DISK";
            disk.Click += disk_Click;
            // 
            // mac
            // 
            mac.Animated = true;
            mac.AutoRoundedCorners = true;
            mac.BackColor = Color.Transparent;
            mac.BorderColor = Color.White;
            mac.BorderRadius = 15;
            mac.BorderThickness = 1;
            mac.CustomBorderColor = Color.Transparent;
            mac.DisabledState.BorderColor = Color.DarkGray;
            mac.DisabledState.CustomBorderColor = Color.DarkGray;
            mac.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            mac.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            mac.FillColor = Color.Transparent;
            mac.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mac.ForeColor = Color.White;
            mac.Location = new Point(12, 121);
            mac.Name = "mac";
            mac.PressedDepth = 60;
            mac.Size = new Size(157, 32);
            mac.TabIndex = 4;
            mac.Text = "MAC";
            mac.Click += mac_Click;
            // 
            // pcname
            // 
            pcname.Animated = true;
            pcname.AutoRoundedCorners = true;
            pcname.BackColor = Color.Transparent;
            pcname.BorderColor = Color.White;
            pcname.BorderRadius = 15;
            pcname.BorderThickness = 1;
            pcname.CustomBorderColor = Color.Transparent;
            pcname.DisabledState.BorderColor = Color.DarkGray;
            pcname.DisabledState.CustomBorderColor = Color.DarkGray;
            pcname.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            pcname.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            pcname.FillColor = Color.Transparent;
            pcname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pcname.ForeColor = Color.White;
            pcname.Location = new Point(338, 121);
            pcname.Name = "pcname";
            pcname.PressedDepth = 60;
            pcname.Size = new Size(157, 32);
            pcname.TabIndex = 5;
            pcname.Text = "PC-Name";
            pcname.Click += pcname_Click;
            // 
            // winid
            // 
            winid.Animated = true;
            winid.AutoRoundedCorners = true;
            winid.BackColor = Color.Transparent;
            winid.BorderColor = Color.White;
            winid.BorderRadius = 15;
            winid.BorderThickness = 1;
            winid.CustomBorderColor = Color.Transparent;
            winid.DisabledState.BorderColor = Color.DarkGray;
            winid.DisabledState.CustomBorderColor = Color.DarkGray;
            winid.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            winid.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            winid.FillColor = Color.Transparent;
            winid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            winid.ForeColor = Color.White;
            winid.Location = new Point(175, 83);
            winid.Name = "winid";
            winid.PressedDepth = 60;
            winid.Size = new Size(157, 32);
            winid.TabIndex = 6;
            winid.Text = "Machine GUID";
            winid.Click += winid_Click;
            // 
            // GUID
            // 
            GUID.Animated = true;
            GUID.AutoRoundedCorners = true;
            GUID.BackColor = Color.Transparent;
            GUID.BorderColor = Color.White;
            GUID.BorderRadius = 15;
            GUID.BorderThickness = 1;
            GUID.CustomBorderColor = Color.Transparent;
            GUID.DisabledState.BorderColor = Color.DarkGray;
            GUID.DisabledState.CustomBorderColor = Color.DarkGray;
            GUID.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GUID.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GUID.FillColor = Color.Transparent;
            GUID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GUID.ForeColor = Color.White;
            GUID.Location = new Point(175, 121);
            GUID.Name = "GUID";
            GUID.PressedDepth = 60;
            GUID.Size = new Size(157, 32);
            GUID.TabIndex = 7;
            GUID.Text = "GUID ";
            GUID.Click += GUID_Click;
            // 
            // display
            // 
            display.Animated = true;
            display.AutoRoundedCorners = true;
            display.BackColor = Color.Transparent;
            display.BorderColor = Color.White;
            display.BorderRadius = 15;
            display.BorderThickness = 1;
            display.CustomBorderColor = Color.Transparent;
            display.DisabledState.BorderColor = Color.DarkGray;
            display.DisabledState.CustomBorderColor = Color.DarkGray;
            display.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            display.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            display.FillColor = Color.Transparent;
            display.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            display.ForeColor = Color.White;
            display.Location = new Point(338, 83);
            display.Name = "display";
            display.PressedDepth = 60;
            display.Size = new Size(157, 32);
            display.TabIndex = 8;
            display.Text = "Display ID";
            display.Click += display_Click;
            // 
            // efi
            // 
            efi.Animated = true;
            efi.AutoRoundedCorners = true;
            efi.BackColor = Color.Transparent;
            efi.BorderColor = Color.White;
            efi.BorderRadius = 15;
            efi.BorderThickness = 1;
            efi.CustomBorderColor = Color.Transparent;
            efi.DisabledState.BorderColor = Color.DarkGray;
            efi.DisabledState.CustomBorderColor = Color.DarkGray;
            efi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            efi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            efi.FillColor = Color.Transparent;
            efi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            efi.ForeColor = Color.White;
            efi.Location = new Point(338, 159);
            efi.Name = "efi";
            efi.PressedDepth = 60;
            efi.Size = new Size(157, 32);
            efi.TabIndex = 9;
            efi.Text = "EFI";
            efi.Click += efi_Click;
            // 
            // sm
            // 
            sm.Animated = true;
            sm.AutoRoundedCorners = true;
            sm.BackColor = Color.Transparent;
            sm.BorderColor = Color.White;
            sm.BorderRadius = 15;
            sm.BorderThickness = 1;
            sm.CustomBorderColor = Color.Transparent;
            sm.DisabledState.BorderColor = Color.DarkGray;
            sm.DisabledState.CustomBorderColor = Color.DarkGray;
            sm.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sm.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sm.FillColor = Color.Transparent;
            sm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sm.ForeColor = Color.White;
            sm.Location = new Point(12, 159);
            sm.Name = "sm";
            sm.PressedDepth = 60;
            sm.Size = new Size(157, 32);
            sm.TabIndex = 10;
            sm.Text = "SMBIOS";
            sm.Click += siticoneButton1_Click;
            // 
            // req
            // 
            req.Animated = true;
            req.AutoRoundedCorners = true;
            req.BackColor = Color.Transparent;
            req.BorderColor = Color.White;
            req.BorderRadius = 15;
            req.BorderThickness = 1;
            req.CustomBorderColor = Color.Transparent;
            req.DisabledState.BorderColor = Color.DarkGray;
            req.DisabledState.CustomBorderColor = Color.DarkGray;
            req.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            req.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            req.FillColor = Color.Transparent;
            req.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            req.ForeColor = Color.White;
            req.Location = new Point(12, 236);
            req.Name = "req";
            req.PressedDepth = 60;
            req.Size = new Size(483, 32);
            req.TabIndex = 11;
            req.Text = "Requirement Check";
            req.Click += req_Click;
            // 
            // spoofall
            // 
            spoofall.Animated = true;
            spoofall.AutoRoundedCorners = true;
            spoofall.BackColor = Color.Transparent;
            spoofall.BorderColor = Color.White;
            spoofall.BorderRadius = 15;
            spoofall.BorderThickness = 1;
            spoofall.CustomBorderColor = Color.Transparent;
            spoofall.DisabledState.BorderColor = Color.DarkGray;
            spoofall.DisabledState.CustomBorderColor = Color.DarkGray;
            spoofall.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            spoofall.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            spoofall.FillColor = Color.Transparent;
            spoofall.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            spoofall.ForeColor = Color.White;
            spoofall.Location = new Point(12, 274);
            spoofall.Name = "spoofall";
            spoofall.PressedDepth = 60;
            spoofall.Size = new Size(483, 32);
            spoofall.TabIndex = 17;
            spoofall.Text = "Spoof All";
            spoofall.Click += spoofall_Click;
            // 
            // product
            // 
            product.Animated = true;
            product.AutoRoundedCorners = true;
            product.BackColor = Color.Transparent;
            product.BorderColor = Color.White;
            product.BorderRadius = 15;
            product.BorderThickness = 1;
            product.CustomBorderColor = Color.Transparent;
            product.DisabledState.BorderColor = Color.DarkGray;
            product.DisabledState.CustomBorderColor = Color.DarkGray;
            product.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            product.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            product.FillColor = Color.Transparent;
            product.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            product.ForeColor = Color.White;
            product.Location = new Point(12, 197);
            product.Name = "product";
            product.PressedDepth = 60;
            product.Size = new Size(157, 32);
            product.TabIndex = 18;
            product.Text = "Product ID";
            product.Click += product_Click;
            // 
            // tracercl
            // 
            tracercl.Animated = true;
            tracercl.AutoRoundedCorners = true;
            tracercl.BackColor = Color.Transparent;
            tracercl.BorderColor = Color.White;
            tracercl.BorderRadius = 15;
            tracercl.BorderThickness = 1;
            tracercl.CustomBorderColor = Color.Transparent;
            tracercl.DisabledState.BorderColor = Color.DarkGray;
            tracercl.DisabledState.CustomBorderColor = Color.DarkGray;
            tracercl.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            tracercl.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            tracercl.FillColor = Color.Transparent;
            tracercl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tracercl.ForeColor = Color.White;
            tracercl.Location = new Point(175, 159);
            tracercl.Name = "tracercl";
            tracercl.PressedDepth = 60;
            tracercl.Size = new Size(157, 32);
            tracercl.TabIndex = 16;
            tracercl.Text = "Trace Cleaner (soon)";
            tracercl.Click += tracercl_Click;
            // 
            // backup
            // 
            backup.Animated = true;
            backup.AutoRoundedCorners = true;
            backup.BackColor = Color.Transparent;
            backup.BorderColor = Color.White;
            backup.BorderRadius = 15;
            backup.BorderThickness = 1;
            backup.CustomBorderColor = Color.Transparent;
            backup.DisabledState.BorderColor = Color.DarkGray;
            backup.DisabledState.CustomBorderColor = Color.DarkGray;
            backup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            backup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            backup.FillColor = Color.Transparent;
            backup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            backup.ForeColor = Color.White;
            backup.Location = new Point(338, 197);
            backup.Name = "backup";
            backup.PressedDepth = 60;
            backup.Size = new Size(157, 32);
            backup.TabIndex = 19;
            backup.Text = "BACKUP";
            backup.Click += backup_Click;
            // 
            // systemcleaner
            // 
            systemcleaner.AutoSize = true;
            systemcleaner.Location = new Point(12, 343);
            systemcleaner.Name = "systemcleaner";
            systemcleaner.Size = new Size(234, 15);
            systemcleaner.Style = MetroFramework.MetroColorStyle.Magenta;
            systemcleaner.TabIndex = 33;
            systemcleaner.Text = "System Cleaner + Anti Cheat Terminator";
            systemcleaner.Theme = MetroFramework.MetroThemeStyle.Dark;
            systemcleaner.UseVisualStyleBackColor = true;
            systemcleaner.CheckedChanged += systemcleaner_CheckedChanged;
            // 
            // logwind
            // 
            logwind.AutoSize = true;
            logwind.Location = new Point(12, 364);
            logwind.Name = "logwind";
            logwind.Size = new Size(93, 15);
            logwind.Style = MetroFramework.MetroColorStyle.Magenta;
            logwind.TabIndex = 34;
            logwind.Text = "LOG Window";
            logwind.Theme = MetroFramework.MetroThemeStyle.Dark;
            logwind.UseVisualStyleBackColor = true;
            logwind.CheckedChanged += logwind_CheckedChanged;
            // 
            // lgbt
            // 
            lgbt.AutoSize = true;
            lgbt.Location = new Point(12, 385);
            lgbt.Name = "lgbt";
            lgbt.Size = new Size(100, 15);
            lgbt.Style = MetroFramework.MetroColorStyle.Magenta;
            lgbt.TabIndex = 35;
            lgbt.Text = "LGBTQ+ Mode";
            lgbt.TextAlign = ContentAlignment.TopLeft;
            lgbt.Theme = MetroFramework.MetroThemeStyle.Dark;
            lgbt.UseVisualStyleBackColor = true;
            lgbt.CheckedChanged += lgbt_CheckedChanged;
            // 
            // metroProgressSpinner1
            // 
            metroProgressSpinner1.Location = new Point(437, 344);
            metroProgressSpinner1.Maximum = 100;
            metroProgressSpinner1.Name = "metroProgressSpinner1";
            metroProgressSpinner1.Size = new Size(58, 56);
            metroProgressSpinner1.TabIndex = 36;
            metroProgressSpinner1.Text = "metroProgressSpinner1";
            // 
            // Spoofy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(634, 423);
            Controls.Add(metroProgressSpinner1);
            Controls.Add(lgbt);
            Controls.Add(logwind);
            Controls.Add(systemcleaner);
            Controls.Add(backup);
            Controls.Add(product);
            Controls.Add(spoofall);
            Controls.Add(tracercl);
            Controls.Add(req);
            Controls.Add(sm);
            Controls.Add(efi);
            Controls.Add(display);
            Controls.Add(GUID);
            Controls.Add(winid);
            Controls.Add(pcname);
            Controls.Add(mac);
            Controls.Add(disk);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Spoofy";
            Resizable = false;
            ShadowType = MetroFormShadowType.DropShadow;
            Style = MetroFramework.MetroColorStyle.Magenta;
            Text = "SecHex - Spoofy V1.5.7";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton disk;
        private Siticone.Desktop.UI.WinForms.SiticoneButton mac;
        private Siticone.Desktop.UI.WinForms.SiticoneButton pcname;
        private Siticone.Desktop.UI.WinForms.SiticoneButton winid;
        private Siticone.Desktop.UI.WinForms.SiticoneButton GUID;
        private Siticone.Desktop.UI.WinForms.SiticoneButton display;
        private Siticone.Desktop.UI.WinForms.SiticoneButton efi;
        private Siticone.Desktop.UI.WinForms.SiticoneButton sm;
        private Siticone.Desktop.UI.WinForms.SiticoneButton req;
        private Siticone.Desktop.UI.WinForms.SiticoneButton spoofall;
        private Siticone.Desktop.UI.WinForms.SiticoneButton product;
        private Siticone.Desktop.UI.WinForms.SiticoneButton tracercl;
        private Siticone.Desktop.UI.WinForms.SiticoneButton backup;
        private MetroFramework.Controls.MetroCheckBox systemcleaner;
        private MetroFramework.Controls.MetroCheckBox logwind;
        private MetroFramework.Controls.MetroCheckBox lgbt;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
    }
}