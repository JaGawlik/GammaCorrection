namespace GammaCorrection
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.sourceTextArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxDefault = new System.Windows.Forms.PictureBox();
            this.sliderGamma = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxModified = new System.Windows.Forms.PictureBox();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.sliderThread = new System.Windows.Forms.TrackBar();
            this.labelThreadUsed = new System.Windows.Forms.Label();
            this.radioCsLib = new System.Windows.Forms.RadioButton();
            this.radioAsemblyLib = new System.Windows.Forms.RadioButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderThread)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(317, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gamma Correction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.AccessibleName = "ButtonBrowse";
            this.ButtonBrowse.Location = new System.Drawing.Point(260, 83);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(69, 23);
            this.ButtonBrowse.TabIndex = 1;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceTextArea
            // 
            this.sourceTextArea.AccessibleName = "sourceTextArea";
            this.sourceTextArea.Location = new System.Drawing.Point(29, 85);
            this.sourceTextArea.Name = "sourceTextArea";
            this.sourceTextArea.Size = new System.Drawing.Size(225, 20);
            this.sourceTextArea.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source path";
            // 
            // pictureBoxDefault
            // 
            this.pictureBoxDefault.AccessibleName = "pictureBoxDefault";
            this.pictureBoxDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDefault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDefault.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDefault.ErrorImage")));
            this.pictureBoxDefault.ImageLocation = "]";
            this.pictureBoxDefault.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDefault.InitialImage")));
            this.pictureBoxDefault.Location = new System.Drawing.Point(29, 112);
            this.pictureBoxDefault.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxDefault.Name = "pictureBoxDefault";
            this.pictureBoxDefault.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDefault.TabIndex = 4;
            this.pictureBoxDefault.TabStop = false;
            this.pictureBoxDefault.Click += new System.EventHandler(this.pictureBoxDefault_Click);
            // 
            // sliderGamma
            // 
            this.sliderGamma.AccessibleName = "sliderGamma";
            this.sliderGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderGamma.Location = new System.Drawing.Point(338, 128);
            this.sliderGamma.Maximum = 5;
            this.sliderGamma.Minimum = 1;
            this.sliderGamma.Name = "sliderGamma";
            this.sliderGamma.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.sliderGamma.Size = new System.Drawing.Size(45, 275);
            this.sliderGamma.TabIndex = 5;
            this.sliderGamma.Value = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(56, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "γ = 1/4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(56, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "γ = 1/3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(56, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "γ = 1/2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(56, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "γ = 1 (original)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(57, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "γ = 2";
            // 
            // pictureBoxModified
            // 
            this.pictureBoxModified.AccessibleName = "pictureBoxModified";
            this.pictureBoxModified.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxModified.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxModified.ErrorImage")));
            this.pictureBoxModified.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxModified.InitialImage")));
            this.pictureBoxModified.Location = new System.Drawing.Point(504, 112);
            this.pictureBoxModified.MinimumSize = new System.Drawing.Size(300, 300);
            this.pictureBoxModified.Name = "pictureBoxModified";
            this.pictureBoxModified.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxModified.TabIndex = 11;
            this.pictureBoxModified.TabStop = false;
            // 
            // ButtonModify
            // 
            this.ButtonModify.AccessibleName = "ButtonModify";
            this.ButtonModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonModify.Enabled = false;
            this.ButtonModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonModify.Location = new System.Drawing.Point(366, 565);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(105, 25);
            this.ButtonModify.TabIndex = 12;
            this.ButtonModify.Text = "Modify";
            this.ButtonModify.UseVisualStyleBackColor = true;
            this.ButtonModify.Click += new System.EventHandler(this.button2_Click);
            // 
            // sliderThread
            // 
            this.sliderThread.AccessibleName = "sliderThread";
            this.sliderThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderThread.Location = new System.Drawing.Point(29, 455);
            this.sliderThread.Maximum = 64;
            this.sliderThread.Minimum = 1;
            this.sliderThread.Name = "sliderThread";
            this.sliderThread.Size = new System.Drawing.Size(775, 45);
            this.sliderThread.TabIndex = 13;
            this.sliderThread.Value = 1;
            this.sliderThread.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // labelThreadUsed
            // 
            this.labelThreadUsed.AccessibleName = "labelThreadUsed";
            this.labelThreadUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelThreadUsed.AutoSize = true;
            this.labelThreadUsed.Location = new System.Drawing.Point(32, 423);
            this.labelThreadUsed.Name = "labelThreadUsed";
            this.labelThreadUsed.Size = new System.Drawing.Size(86, 13);
            this.labelThreadUsed.TabIndex = 14;
            this.labelThreadUsed.Text = "Threads Used: 1";
            // 
            // radioCsLib
            // 
            this.radioCsLib.AccessibleName = "radioCsLib";
            this.radioCsLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioCsLib.AutoSize = true;
            this.radioCsLib.Checked = true;
            this.radioCsLib.Location = new System.Drawing.Point(35, 507);
            this.radioCsLib.Name = "radioCsLib";
            this.radioCsLib.Size = new System.Drawing.Size(61, 17);
            this.radioCsLib.TabIndex = 15;
            this.radioCsLib.TabStop = true;
            this.radioCsLib.Text = "Use C#";
            this.radioCsLib.UseVisualStyleBackColor = true;
            // 
            // radioAsemblyLib
            // 
            this.radioAsemblyLib.AccessibleName = "radioAsemblyLib";
            this.radioAsemblyLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioAsemblyLib.AutoSize = true;
            this.radioAsemblyLib.Location = new System.Drawing.Point(35, 531);
            this.radioAsemblyLib.Name = "radioAsemblyLib";
            this.radioAsemblyLib.Size = new System.Drawing.Size(91, 17);
            this.radioAsemblyLib.TabIndex = 16;
            this.radioAsemblyLib.Text = "Use Assembly";
            this.radioAsemblyLib.UseVisualStyleBackColor = true;
            // 
            // labelTime
            // 
            this.labelTime.AccessibleName = "labelTime";
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(500, 507);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(73, 24);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = "Time: 0";
            this.labelTime.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(332, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 300);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ButtonSave
            // 
            this.ButtonSave.AccessibleDescription = "ButtonSave";
            this.ButtonSave.AccessibleName = "ButtonSave";
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(729, 83);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 20;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.radioAsemblyLib);
            this.Controls.Add(this.radioCsLib);
            this.Controls.Add(this.labelThreadUsed);
            this.Controls.Add(this.sliderThread);
            this.Controls.Add(this.ButtonModify);
            this.Controls.Add(this.pictureBoxModified);
            this.Controls.Add(this.sliderGamma);
            this.Controls.Add(this.pictureBoxDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceTextArea);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(850, 650);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.Text = "Gamma Correction";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderThread)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.TextBox sourceTextArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxDefault;
        private System.Windows.Forms.TrackBar sliderGamma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxModified;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.TrackBar sliderThread;
        private System.Windows.Forms.Label labelThreadUsed;
        private System.Windows.Forms.RadioButton radioCsLib;
        private System.Windows.Forms.RadioButton radioAsemblyLib;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonSave;
    }
}

