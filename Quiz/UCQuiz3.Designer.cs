namespace Quiz
{
    partial class UCQuiz3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpQ3 = new System.Windows.Forms.GroupBox();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnQ1Submit = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpQ3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpQ3
            // 
            this.gpQ3.Controls.Add(this.lblQ3);
            this.gpQ3.Controls.Add(this.radioButton3);
            this.gpQ3.Controls.Add(this.pictureBox1);
            this.gpQ3.Controls.Add(this.radioButton2);
            this.gpQ3.Controls.Add(this.btnQ1Submit);
            this.gpQ3.Controls.Add(this.radioButton1);
            this.gpQ3.Location = new System.Drawing.Point(3, 3);
            this.gpQ3.Name = "gpQ3";
            this.gpQ3.Size = new System.Drawing.Size(602, 320);
            this.gpQ3.TabIndex = 16;
            this.gpQ3.TabStop = false;
            // 
            // lblQ3
            // 
            this.lblQ3.AutoSize = true;
            this.lblQ3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQ3.Location = new System.Drawing.Point(6, 16);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(431, 23);
            this.lblQ3.TabIndex = 9;
            this.lblQ3.Text = "What geometric shape is generally used for stop signs?";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 106);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Circle";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Square";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnQ1Submit
            // 
            this.btnQ1Submit.Location = new System.Drawing.Point(10, 153);
            this.btnQ1Submit.Name = "btnQ1Submit";
            this.btnQ1Submit.Size = new System.Drawing.Size(229, 23);
            this.btnQ1Submit.TabIndex = 11;
            this.btnQ1Submit.Text = "Check";
            this.btnQ1Submit.UseVisualStyleBackColor = true;
            this.btnQ1Submit.Click += new System.EventHandler(this.btnQ1Submit_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Octagon";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.qmark_in_square;
            this.pictureBox1.Location = new System.Drawing.Point(176, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UCQuiz3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.gpQ3);
            this.Name = "UCQuiz3";
            this.Size = new System.Drawing.Size(608, 326);
            this.gpQ3.ResumeLayout(false);
            this.gpQ3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpQ3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnQ1Submit;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
