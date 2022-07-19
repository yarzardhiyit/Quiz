namespace Quiz
{
    partial class UCQuiz2
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnQ1Submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpQ2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpQ2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(248, 182);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 20);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "80 meters";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(248, 154);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "50 meters";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(248, 126);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 20);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "50 miles";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnQ1Submit
            // 
            this.btnQ1Submit.Location = new System.Drawing.Point(248, 240);
            this.btnQ1Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQ1Submit.Name = "btnQ1Submit";
            this.btnQ1Submit.Size = new System.Drawing.Size(305, 28);
            this.btnQ1Submit.TabIndex = 11;
            this.btnQ1Submit.Text = "Check";
            this.btnQ1Submit.UseVisualStyleBackColor = true;
            this.btnQ1Submit.Click += new System.EventHandler(this.btnQ1Submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz.Properties.Resources.qmark_in_square;
            this.pictureBox1.Location = new System.Drawing.Point(470, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hong Long is an Olympic swimming pool (in meters)?";
            // 
            // gpQ2
            // 
            this.gpQ2.Controls.Add(this.label1);
            this.gpQ2.Controls.Add(this.radioButton3);
            this.gpQ2.Controls.Add(this.pictureBox1);
            this.gpQ2.Controls.Add(this.radioButton2);
            this.gpQ2.Controls.Add(this.btnQ1Submit);
            this.gpQ2.Controls.Add(this.radioButton1);
            this.gpQ2.Location = new System.Drawing.Point(4, 4);
            this.gpQ2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpQ2.Name = "gpQ2";
            this.gpQ2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpQ2.Size = new System.Drawing.Size(803, 394);
            this.gpQ2.TabIndex = 15;
            this.gpQ2.TabStop = false;
            // 
            // UCQuiz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.gpQ2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCQuiz2";
            this.Size = new System.Drawing.Size(811, 401);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpQ2.ResumeLayout(false);
            this.gpQ2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnQ1Submit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpQ2;
    }
}
