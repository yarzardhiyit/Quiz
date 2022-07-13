namespace Quiz
{
    partial class frmQuiz
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.plHeadline = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.ucQuiz31 = new Quiz.UCQuiz3();
            this.ucQuiz21 = new Quiz.UCQuiz2();
            this.ucQuiz11 = new Quiz.UCQuiz1();
            this.ucHome1 = new Quiz.UcHome();
            this.btnBack = new System.Windows.Forms.Button();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(96, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz Hub";
            // 
            // plHeadline
            // 
            this.plHeadline.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plHeadline.Location = new System.Drawing.Point(12, 58);
            this.plHeadline.Name = "plHeadline";
            this.plHeadline.Size = new System.Drawing.Size(608, 5);
            this.plHeadline.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Quiz.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Location = new System.Drawing.Point(580, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = global::Quiz.Properties.Resources.about;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.Location = new System.Drawing.Point(534, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(40, 40);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.btnBack);
            this.plMain.Controls.Add(this.btnNext);
            this.plMain.Controls.Add(this.ucQuiz31);
            this.plMain.Controls.Add(this.ucQuiz21);
            this.plMain.Controls.Add(this.ucQuiz11);
            this.plMain.Controls.Add(this.ucHome1);
            this.plMain.Location = new System.Drawing.Point(12, 69);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(608, 326);
            this.plMain.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::Quiz.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Location = new System.Drawing.Point(568, 287);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 39);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(441, 404);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(179, 13);
            this.lblCopyRight.TabIndex = 5;
            this.lblCopyRight.Text = "Made with ❤️ by yarzardhiyit © 2022";
            // 
            // ucQuiz31
            // 
            this.ucQuiz31.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucQuiz31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuiz31.Location = new System.Drawing.Point(0, 0);
            this.ucQuiz31.Name = "ucQuiz31";
            this.ucQuiz31.Size = new System.Drawing.Size(608, 326);
            this.ucQuiz31.TabIndex = 7;
            // 
            // ucQuiz21
            // 
            this.ucQuiz21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucQuiz21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuiz21.Location = new System.Drawing.Point(0, 0);
            this.ucQuiz21.Margin = new System.Windows.Forms.Padding(2);
            this.ucQuiz21.Name = "ucQuiz21";
            this.ucQuiz21.Size = new System.Drawing.Size(608, 326);
            this.ucQuiz21.TabIndex = 2;
            // 
            // ucQuiz11
            // 
            this.ucQuiz11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucQuiz11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucQuiz11.Location = new System.Drawing.Point(0, 0);
            this.ucQuiz11.Margin = new System.Windows.Forms.Padding(2);
            this.ucQuiz11.Name = "ucQuiz11";
            this.ucQuiz11.Size = new System.Drawing.Size(608, 326);
            this.ucQuiz11.TabIndex = 1;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(608, 326);
            this.ucHome1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Quiz.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(0, 287);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 426);
            this.ControlBox = false;
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.plHeadline);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Hub";
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel plHeadline;
        private System.Windows.Forms.Panel plMain;
        private UcHome ucHome1;
        private System.Windows.Forms.Label lblCopyRight;
        private UCQuiz1 ucQuiz11;
        private UCQuiz2 ucQuiz21;
        private System.Windows.Forms.Button btnNext;
        private UCQuiz3 ucQuiz31;
        private System.Windows.Forms.Button btnBack;
    }
}

