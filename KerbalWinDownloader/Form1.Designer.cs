namespace KerbalWinDownloader
{
    partial class Form1
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
            this.lstAvailableMods = new System.Windows.Forms.ListBox();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.txtKerbalPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstInstalledMods = new System.Windows.Forms.ListBox();
            this.btnUpdateMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAvailableMods
            // 
            this.lstAvailableMods.FormattingEnabled = true;
            this.lstAvailableMods.Location = new System.Drawing.Point(12, 12);
            this.lstAvailableMods.Name = "lstAvailableMods";
            this.lstAvailableMods.Size = new System.Drawing.Size(234, 264);
            this.lstAvailableMods.TabIndex = 0;
            this.lstAvailableMods.SelectedIndexChanged += new System.EventHandler(this.lstAvailableMods_SelectedIndexChanged);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 282);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(324, 282);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 2;
            this.btnUninstall.Text = "Uninstall";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // txtKerbalPath
            // 
            this.txtKerbalPath.Location = new System.Drawing.Point(13, 324);
            this.txtKerbalPath.Name = "txtKerbalPath";
            this.txtKerbalPath.Size = new System.Drawing.Size(220, 20);
            this.txtKerbalPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(249, 324);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstInstalledMods
            // 
            this.lstInstalledMods.FormattingEnabled = true;
            this.lstInstalledMods.Location = new System.Drawing.Point(252, 12);
            this.lstInstalledMods.Name = "lstInstalledMods";
            this.lstInstalledMods.Size = new System.Drawing.Size(234, 264);
            this.lstInstalledMods.TabIndex = 5;
            // 
            // btnUpdateMod
            // 
            this.btnUpdateMod.Location = new System.Drawing.Point(243, 282);
            this.btnUpdateMod.Name = "btnUpdateMod";
            this.btnUpdateMod.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMod.TabIndex = 6;
            this.btnUpdateMod.Text = "Update";
            this.btnUpdateMod.UseVisualStyleBackColor = true;
            this.btnUpdateMod.Click += new System.EventHandler(this.btnUpdateMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 379);
            this.Controls.Add(this.btnUpdateMod);
            this.Controls.Add(this.lstInstalledMods);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtKerbalPath);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.lstAvailableMods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAvailableMods;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.TextBox txtKerbalPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lstInstalledMods;
        private System.Windows.Forms.Button btnUpdateMod;
    }
}

