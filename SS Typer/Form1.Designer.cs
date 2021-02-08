namespace SS_Typer
{
    partial class FormSSTyper
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
            this.labelSSTyper = new System.Windows.Forms.Label();
            this.labelTypeThis = new System.Windows.Forms.Label();
            this.labelTM = new System.Windows.Forms.Label();
            this.labelSC = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelTimeExtended = new System.Windows.Forms.Label();
            this.label15Secs = new System.Windows.Forms.Label();
            this.labelCD1 = new System.Windows.Forms.Label();
            this.labelCD5 = new System.Windows.Forms.Label();
            this.labelCD3 = new System.Windows.Forms.Label();
            this.labelCD2 = new System.Windows.Forms.Label();
            this.labelCD4 = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.timerFrameRate = new System.Windows.Forms.Timer(this.components);
            this.timerBreak = new System.Windows.Forms.Timer(this.components);
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label60Secs = new System.Windows.Forms.Label();
            this.label30Secs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSSTyper
            // 
            this.labelSSTyper.AutoSize = true;
            this.labelSSTyper.BackColor = System.Drawing.Color.Transparent;
            this.labelSSTyper.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSTyper.Location = new System.Drawing.Point(238, 9);
            this.labelSSTyper.Name = "labelSSTyper";
            this.labelSSTyper.Size = new System.Drawing.Size(299, 49);
            this.labelSSTyper.TabIndex = 0;
            this.labelSSTyper.Text = "Super Speed Typer";
            // 
            // labelTypeThis
            // 
            this.labelTypeThis.AutoSize = true;
            this.labelTypeThis.BackColor = System.Drawing.Color.Transparent;
            this.labelTypeThis.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeThis.Location = new System.Drawing.Point(12, 80);
            this.labelTypeThis.Name = "labelTypeThis";
            this.labelTypeThis.Size = new System.Drawing.Size(190, 49);
            this.labelTypeThis.TabIndex = 1;
            this.labelTypeThis.Text = "Type This :";
            // 
            // labelTM
            // 
            this.labelTM.AutoSize = true;
            this.labelTM.BackColor = System.Drawing.Color.Transparent;
            this.labelTM.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTM.Location = new System.Drawing.Point(502, 80);
            this.labelTM.Name = "labelTM";
            this.labelTM.Size = new System.Drawing.Size(116, 49);
            this.labelTM.TabIndex = 2;
            this.labelTM.Text = "Time :";
            // 
            // labelSC
            // 
            this.labelSC.AutoSize = true;
            this.labelSC.BackColor = System.Drawing.Color.Transparent;
            this.labelSC.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSC.Location = new System.Drawing.Point(502, 139);
            this.labelSC.Name = "labelSC";
            this.labelSC.Size = new System.Drawing.Size(122, 49);
            this.labelSC.TabIndex = 3;
            this.labelSC.Text = "Score :";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(624, 80);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(96, 49);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Num";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(624, 139);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(96, 49);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "Num";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.BackColor = System.Drawing.Color.Transparent;
            this.labelA.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(12, 139);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(158, 49);
            this.labelA.TabIndex = 8;
            this.labelA.Text = "Answer :";
            // 
            // labelTimeExtended
            // 
            this.labelTimeExtended.AutoSize = true;
            this.labelTimeExtended.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeExtended.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeExtended.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTimeExtended.Location = new System.Drawing.Point(141, 235);
            this.labelTimeExtended.Name = "labelTimeExtended";
            this.labelTimeExtended.Size = new System.Drawing.Size(497, 72);
            this.labelTimeExtended.TabIndex = 9;
            this.labelTimeExtended.Text = "TIME EXTENDED";
            // 
            // label15Secs
            // 
            this.label15Secs.AutoSize = true;
            this.label15Secs.BackColor = System.Drawing.Color.Transparent;
            this.label15Secs.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15Secs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15Secs.Location = new System.Drawing.Point(211, 235);
            this.label15Secs.Name = "label15Secs";
            this.label15Secs.Size = new System.Drawing.Size(349, 72);
            this.label15Secs.TabIndex = 10;
            this.label15Secs.Text = "15 SECONDS";
            // 
            // labelCD1
            // 
            this.labelCD1.AutoSize = true;
            this.labelCD1.BackColor = System.Drawing.Color.Transparent;
            this.labelCD1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCD1.Location = new System.Drawing.Point(12, 235);
            this.labelCD1.Name = "labelCD1";
            this.labelCD1.Size = new System.Drawing.Size(57, 72);
            this.labelCD1.TabIndex = 11;
            this.labelCD1.Text = "5";
            // 
            // labelCD5
            // 
            this.labelCD5.AutoSize = true;
            this.labelCD5.BackColor = System.Drawing.Color.Transparent;
            this.labelCD5.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCD5.Location = new System.Drawing.Point(713, 235);
            this.labelCD5.Name = "labelCD5";
            this.labelCD5.Size = new System.Drawing.Size(57, 72);
            this.labelCD5.TabIndex = 12;
            this.labelCD5.Text = "5";
            // 
            // labelCD3
            // 
            this.labelCD3.AutoSize = true;
            this.labelCD3.BackColor = System.Drawing.Color.Transparent;
            this.labelCD3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCD3.Location = new System.Drawing.Point(359, 235);
            this.labelCD3.Name = "labelCD3";
            this.labelCD3.Size = new System.Drawing.Size(57, 72);
            this.labelCD3.TabIndex = 13;
            this.labelCD3.Text = "5";
            // 
            // labelCD2
            // 
            this.labelCD2.AutoSize = true;
            this.labelCD2.BackColor = System.Drawing.Color.Transparent;
            this.labelCD2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCD2.Location = new System.Drawing.Point(187, 235);
            this.labelCD2.Name = "labelCD2";
            this.labelCD2.Size = new System.Drawing.Size(57, 72);
            this.labelCD2.TabIndex = 14;
            this.labelCD2.Text = "5";
            // 
            // labelCD4
            // 
            this.labelCD4.AutoSize = true;
            this.labelCD4.BackColor = System.Drawing.Color.Transparent;
            this.labelCD4.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCD4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCD4.Location = new System.Drawing.Point(536, 235);
            this.labelCD4.Name = "labelCD4";
            this.labelCD4.Size = new System.Drawing.Size(57, 72);
            this.labelCD4.TabIndex = 15;
            this.labelCD4.Text = "5";
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerDisplay
            // 
            this.timerDisplay.Interval = 250;
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick);
            // 
            // timerFrameRate
            // 
            this.timerFrameRate.Enabled = true;
            this.timerFrameRate.Interval = 40;
            this.timerFrameRate.Tick += new System.EventHandler(this.timerFrameRate_Tick);
            // 
            // timerBreak
            // 
            this.timerBreak.Interval = 40;
            this.timerBreak.Tick += new System.EventHandler(this.timerBreak_Tick);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(208, 136);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(288, 52);
            this.textBoxAnswer.TabIndex = 18;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(208, 78);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(288, 52);
            this.textBoxQuestion.TabIndex = 19;
            // 
            // label60Secs
            // 
            this.label60Secs.AutoSize = true;
            this.label60Secs.BackColor = System.Drawing.Color.Transparent;
            this.label60Secs.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60Secs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label60Secs.Location = new System.Drawing.Point(235, 235);
            this.label60Secs.Name = "label60Secs";
            this.label60Secs.Size = new System.Drawing.Size(270, 72);
            this.label60Secs.TabIndex = 20;
            this.label60Secs.Text = "60 Seconds";
            // 
            // label30Secs
            // 
            this.label30Secs.AutoSize = true;
            this.label30Secs.BackColor = System.Drawing.Color.Transparent;
            this.label30Secs.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30Secs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30Secs.Location = new System.Drawing.Point(235, 235);
            this.label30Secs.Name = "label30Secs";
            this.label30Secs.Size = new System.Drawing.Size(270, 72);
            this.label30Secs.TabIndex = 21;
            this.label30Secs.Text = "30 Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(259, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 22;
            this.label1.Text = "Press Enter To Answer";
            // 
            // FormSSTyper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SS_Typer.Properties.Resources.keyboard_wallpaper_hd_38999_39895_hd_wallpapers;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label30Secs);
            this.Controls.Add(this.label60Secs);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelCD4);
            this.Controls.Add(this.labelCD2);
            this.Controls.Add(this.labelCD3);
            this.Controls.Add(this.labelCD5);
            this.Controls.Add(this.labelCD1);
            this.Controls.Add(this.label15Secs);
            this.Controls.Add(this.labelTimeExtended);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSC);
            this.Controls.Add(this.labelTM);
            this.Controls.Add(this.labelTypeThis);
            this.Controls.Add(this.labelSSTyper);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "FormSSTyper";
            this.Text = "SS Typer";
            this.Load += new System.EventHandler(this.FormSSTyper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSSTyper;
        private System.Windows.Forms.Label labelTypeThis;
        private System.Windows.Forms.Label labelTM;
        private System.Windows.Forms.Label labelSC;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelTimeExtended;
        private System.Windows.Forms.Label label15Secs;
        private System.Windows.Forms.Label labelCD1;
        private System.Windows.Forms.Label labelCD5;
        private System.Windows.Forms.Label labelCD3;
        private System.Windows.Forms.Label labelCD2;
        private System.Windows.Forms.Label labelCD4;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerDisplay;
        private System.Windows.Forms.Timer timerFrameRate;
        private System.Windows.Forms.Timer timerBreak;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label60Secs;
        private System.Windows.Forms.Label label30Secs;
        private System.Windows.Forms.Label label1;
    }
}

