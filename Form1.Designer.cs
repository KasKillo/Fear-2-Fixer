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
            this.label1 = new System.Windows.Forms.Label();
            this.WYes = new System.Windows.Forms.RadioButton();
            this.WNo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.GDButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.FovInput.Text = "";
            this.FovInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DIGIT_ONLY);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fov:";
            // 
            // WYes
            // 
            this.WYes.AutoSize = true;
            this.WYes.Location = new System.Drawing.Point(136, 351);
            this.WYes.Name = "WYes";
            this.WYes.Size = new System.Drawing.Size(43, 17);
            this.WYes.TabIndex = 3;
            this.WYes.Text = "Yes";
            this.WYes.UseVisualStyleBackColor = true;
            // 
            // WNo
            // 
            this.WNo.AutoSize = true;
            this.WNo.Checked = true;
            this.WNo.Location = new System.Drawing.Point(185, 351);
            this.WNo.Name = "WNo";
            this.WNo.Size = new System.Drawing.Size(39, 17);
            this.WNo.TabIndex = 4;
            this.WNo.TabStop = true;
            this.WNo.Text = "No";
            this.WNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Windowed:";
            // 
            // GDButton
            // 
            this.GDButton.Location = new System.Drawing.Point(12, 405);
            this.GDButton.Name = "GDButton";
            this.GDButton.Size = new System.Drawing.Size(110, 36);
            this.GDButton.TabIndex = 6;
            this.GDButton.Text = "Create CFG";
            this.GDButton.UseVisualStyleBackColor = true;
            this.GDButton.Click += new System.EventHandler(this.GDButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fear2Pc.Properties.Resources.external_content_duckduckgo_com;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(810, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Version 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Game Directory Not Set";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GDButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WNo);
            this.Controls.Add(this.WYes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FovInput);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fear 2 Fixer by KasKillo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox FovInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton WYes;
        private System.Windows.Forms.RadioButton WNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GDButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

