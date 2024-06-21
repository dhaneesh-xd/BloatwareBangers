namespace BloatwareBangers
{
    partial class BBmainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.uninstallApp = new System.Windows.Forms.TabPage();
            this.checkedListBoxAppsUninstall = new System.Windows.Forms.CheckedListBox();
            this.disableApp = new System.Windows.Forms.TabPage();
            this.checkedListBoxAppsDisable = new System.Windows.Forms.CheckedListBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.deviceNameShow = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.timmerScan = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.uninstallApp.SuspendLayout();
            this.disableApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.uninstallApp);
            this.tabControl.Controls.Add(this.disableApp);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(381, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(547, 580);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // uninstallApp
            // 
            this.uninstallApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uninstallApp.Controls.Add(this.checkedListBoxAppsUninstall);
            this.uninstallApp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uninstallApp.Location = new System.Drawing.Point(4, 30);
            this.uninstallApp.Margin = new System.Windows.Forms.Padding(4);
            this.uninstallApp.Name = "uninstallApp";
            this.uninstallApp.Padding = new System.Windows.Forms.Padding(4);
            this.uninstallApp.Size = new System.Drawing.Size(539, 546);
            this.uninstallApp.TabIndex = 0;
            this.uninstallApp.Text = "Uninstall";
            this.uninstallApp.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxAppsUninstall
            // 
            this.checkedListBoxAppsUninstall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAppsUninstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxAppsUninstall.FormattingEnabled = true;
            this.checkedListBoxAppsUninstall.Location = new System.Drawing.Point(4, 4);
            this.checkedListBoxAppsUninstall.Name = "checkedListBoxAppsUninstall";
            this.checkedListBoxAppsUninstall.Size = new System.Drawing.Size(529, 536);
            this.checkedListBoxAppsUninstall.TabIndex = 0;
            // 
            // disableApp
            // 
            this.disableApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disableApp.Controls.Add(this.checkedListBoxAppsDisable);
            this.disableApp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableApp.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.disableApp.Location = new System.Drawing.Point(4, 30);
            this.disableApp.Margin = new System.Windows.Forms.Padding(4);
            this.disableApp.Name = "disableApp";
            this.disableApp.Padding = new System.Windows.Forms.Padding(4);
            this.disableApp.Size = new System.Drawing.Size(539, 546);
            this.disableApp.TabIndex = 1;
            this.disableApp.Text = "Disable";
            this.disableApp.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxAppsDisable
            // 
            this.checkedListBoxAppsDisable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAppsDisable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxAppsDisable.FormattingEnabled = true;
            this.checkedListBoxAppsDisable.Location = new System.Drawing.Point(4, 4);
            this.checkedListBoxAppsDisable.Name = "checkedListBoxAppsDisable";
            this.checkedListBoxAppsDisable.Size = new System.Drawing.Size(529, 536);
            this.checkedListBoxAppsDisable.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(11, 173);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(358, 293);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(7, 150);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(68, 20);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output :";
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.AutoSize = true;
            this.deviceNameLabel.Location = new System.Drawing.Point(7, 107);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(123, 20);
            this.deviceNameLabel.TabIndex = 3;
            this.deviceNameLabel.Text = "Device Name : ";
            // 
            // deviceNameShow
            // 
            this.deviceNameShow.AutoSize = true;
            this.deviceNameShow.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceNameShow.Location = new System.Drawing.Point(104, 107);
            this.deviceNameShow.Name = "deviceNameShow";
            this.deviceNameShow.Size = new System.Drawing.Size(0, 19);
            this.deviceNameShow.TabIndex = 4;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(14, 27);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(77, 29);
            this.scanButton.TabIndex = 5;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.BackColor = System.Drawing.Color.Lime;
            this.executeButton.Location = new System.Drawing.Point(144, 522);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(98, 32);
            this.executeButton.TabIndex = 6;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = false;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // BBmainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.deviceNameShow);
            this.Controls.Add(this.deviceNameLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BBmainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bloatware Bangers by DxD";
            this.Load += new System.EventHandler(this.BBmainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.uninstallApp.ResumeLayout(false);
            this.disableApp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage uninstallApp;
        private System.Windows.Forms.TabPage disableApp;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label deviceNameLabel;
        private System.Windows.Forms.Label deviceNameShow;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.CheckedListBox checkedListBoxAppsUninstall;
        private System.Windows.Forms.CheckedListBox checkedListBoxAppsDisable;
        private System.Windows.Forms.Timer timmerScan;
    }
}

