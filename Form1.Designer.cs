namespace Fear2Pc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FovInput = new System.Windows.Forms.RichTextBox();
            this.FovLabel = new System.Windows.Forms.Label();
            this.WYes = new System.Windows.Forms.RadioButton();
            this.WNo = new System.Windows.Forms.RadioButton();
            this.WindowedLabel = new System.Windows.Forms.Label();
            this.GDButton = new System.Windows.Forms.Button();
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.GameDirectoryLabel = new System.Windows.Forms.Label();
            this.CreateCFG = new System.Windows.Forms.Button();
            this.MouseFixDownload = new System.Windows.Forms.Button();
            this.EnableMAFix = new System.Windows.Forms.Button();
            this.CreatorLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // FovInput
            // 
            this.FovInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FovInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FovInput.Location = new System.Drawing.Point(72, 312);
            this.FovInput.Name = "FovInput";
            this.FovInput.Size = new System.Drawing.Size(82, 26);
            this.FovInput.TabIndex = 1;
            this.FovInput.Text = "80";
            this.FovInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DIGIT_ONLY);
            // 
            // FovLabel
            // 
            this.FovLabel.AutoSize = true;
            this.FovLabel.BackColor = System.Drawing.Color.Transparent;
            this.FovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FovLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FovLabel.Location = new System.Drawing.Point(12, 312);
            this.FovLabel.Name = "FovLabel";
            this.FovLabel.Size = new System.Drawing.Size(54, 25);
            this.FovLabel.TabIndex = 2;
            this.FovLabel.Text = "Fov:";
            // 
            // WYes
            // 
            this.WYes.AutoSize = true;
            this.WYes.BackColor = System.Drawing.Color.Transparent;
            this.WYes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WYes.Location = new System.Drawing.Point(136, 351);
            this.WYes.Name = "WYes";
            this.WYes.Size = new System.Drawing.Size(43, 17);
            this.WYes.TabIndex = 3;
            this.WYes.Text = "Yes";
            this.WYes.UseVisualStyleBackColor = false;
            // 
            // WNo
            // 
            this.WNo.AutoSize = true;
            this.WNo.BackColor = System.Drawing.Color.Transparent;
            this.WNo.Checked = true;
            this.WNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WNo.Location = new System.Drawing.Point(185, 351);
            this.WNo.Name = "WNo";
            this.WNo.Size = new System.Drawing.Size(39, 17);
            this.WNo.TabIndex = 4;
            this.WNo.TabStop = true;
            this.WNo.Text = "No";
            this.WNo.UseVisualStyleBackColor = false;
            // 
            // WindowedLabel
            // 
            this.WindowedLabel.AutoSize = true;
            this.WindowedLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindowedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WindowedLabel.Location = new System.Drawing.Point(12, 351);
            this.WindowedLabel.Name = "WindowedLabel";
            this.WindowedLabel.Size = new System.Drawing.Size(118, 25);
            this.WindowedLabel.TabIndex = 5;
            this.WindowedLabel.Text = "Windowed:";
            // 
            // GDButton
            // 
            this.GDButton.Location = new System.Drawing.Point(12, 405);
            this.GDButton.Name = "GDButton";
            this.GDButton.Size = new System.Drawing.Size(110, 36);
            this.GDButton.TabIndex = 6;
            this.GDButton.Text = "Game Directory";
            this.GDButton.UseVisualStyleBackColor = true;
            this.GDButton.Click += new System.EventHandler(this.GDButton_Click);
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage.Image = global::Fear2Pc.Properties.Resources.external_content_duckduckgo_com;
            this.BackgroundImage.Location = new System.Drawing.Point(-2, -1);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(810, 461);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage.TabIndex = 8;
            this.BackgroundImage.TabStop = false;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VersionLabel.Location = new System.Drawing.Point(685, 416);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(103, 25);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "Version 2";
            // 
            // GameDirectoryLabel
            // 
            this.GameDirectoryLabel.AutoSize = true;
            this.GameDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDirectoryLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GameDirectoryLabel.Location = new System.Drawing.Point(550, 380);
            this.GameDirectoryLabel.Name = "GameDirectoryLabel";
            this.GameDirectoryLabel.Size = new System.Drawing.Size(238, 25);
            this.GameDirectoryLabel.TabIndex = 7;
            this.GameDirectoryLabel.Text = "Game Directory Not Set";
            // 
            // CreateCFG
            // 
            this.CreateCFG.Location = new System.Drawing.Point(136, 405);
            this.CreateCFG.Name = "CreateCFG";
            this.CreateCFG.Size = new System.Drawing.Size(110, 36);
            this.CreateCFG.TabIndex = 10;
            this.CreateCFG.Text = "Create CFG";
            this.CreateCFG.UseVisualStyleBackColor = true;
            this.CreateCFG.Visible = false;
            this.CreateCFG.Click += new System.EventHandler(this.CreateCFG_Click);
            // 
            // MouseFixDownload
            // 
            this.MouseFixDownload.Location = new System.Drawing.Point(252, 405);
            this.MouseFixDownload.Name = "MouseFixDownload";
            this.MouseFixDownload.Size = new System.Drawing.Size(110, 36);
            this.MouseFixDownload.TabIndex = 11;
            this.MouseFixDownload.Text = "Download Mouse Acceleration Fix";
            this.MouseFixDownload.UseVisualStyleBackColor = true;
            this.MouseFixDownload.Visible = false;
            this.MouseFixDownload.Click += new System.EventHandler(this.MouseFixDownload_Click);
            // 
            // EnableMAFix
            // 
            this.EnableMAFix.Location = new System.Drawing.Point(368, 405);
            this.EnableMAFix.Name = "EnableMAFix";
            this.EnableMAFix.Size = new System.Drawing.Size(110, 36);
            this.EnableMAFix.TabIndex = 12;
            this.EnableMAFix.Text = "Enable Mouse Acceleration Fix";
            this.EnableMAFix.UseVisualStyleBackColor = true;
            this.EnableMAFix.Visible = false;
            this.EnableMAFix.Click += new System.EventHandler(this.EnableMAFix_Click);
            // 
            // CreatorLabel
            // 
            this.CreatorLabel.AutoSize = true;
            this.CreatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatorLabel.LinkColor = System.Drawing.Color.White;
            this.CreatorLabel.Location = new System.Drawing.Point(9, 9);
            this.CreatorLabel.Name = "CreatorLabel";
            this.CreatorLabel.Size = new System.Drawing.Size(155, 24);
            this.CreatorLabel.TabIndex = 13;
            this.CreatorLabel.TabStop = true;
            this.CreatorLabel.Text = "Made By KasKillo";
            this.CreatorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreatorLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreatorLabel);
            this.Controls.Add(this.EnableMAFix);
            this.Controls.Add(this.MouseFixDownload);
            this.Controls.Add(this.CreateCFG);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.GameDirectoryLabel);
            this.Controls.Add(this.GDButton);
            this.Controls.Add(this.WindowedLabel);
            this.Controls.Add(this.WNo);
            this.Controls.Add(this.WYes);
            this.Controls.Add(this.FovLabel);
            this.Controls.Add(this.FovInput);
            this.Controls.Add(this.BackgroundImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fear 2 Fixer by KasKillo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox FovInput;
        private System.Windows.Forms.Label FovLabel;
        private System.Windows.Forms.RadioButton WYes;
        private System.Windows.Forms.RadioButton WNo;
        private System.Windows.Forms.Label WindowedLabel;
        private System.Windows.Forms.Button GDButton;
        private System.Windows.Forms.PictureBox BackgroundImage;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label GameDirectoryLabel;
        private System.Windows.Forms.Button CreateCFG;
        private System.Windows.Forms.Button MouseFixDownload;
        private System.Windows.Forms.Button EnableMAFix;
        private System.Windows.Forms.LinkLabel CreatorLabel;
    }
}

