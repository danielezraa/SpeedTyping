namespace SpeedTyping
{
    partial class main
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
            this.label2 = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.compRTB = new System.Windows.Forms.RichTextBox();
            this.wordscompletedTB = new System.Windows.Forms.TextBox();
            this.scoreboardBOX = new System.Windows.Forms.GroupBox();
            this.mistakesTB = new System.Windows.Forms.TextBox();
            this.mistakesLB = new System.Windows.Forms.Label();
            this.wordcompletedLB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stopBN = new System.Windows.Forms.Button();
            this.startBN = new System.Windows.Forms.Button();
            this.timerBN = new System.Windows.Forms.Button();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.lastsocrepersecTB = new System.Windows.Forms.TextBox();
            this.deleteifincorrectCB = new System.Windows.Forms.CheckBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.usernameLB = new System.Windows.Forms.Label();
            this.highscoreBN = new System.Windows.Forms.Button();
            this.newLB = new System.Windows.Forms.Label();
            this.highscoreBT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cointimer = new System.Windows.Forms.Timer(this.components);
            this.coin1 = new System.Windows.Forms.Button();
            this.scoreboardBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Keybaord";
            // 
            // userTB
            // 
            this.userTB.Enabled = false;
            this.userTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTB.Location = new System.Drawing.Point(286, 240);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(244, 33);
            this.userTB.TabIndex = 5;
            this.userTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userTB_KeyPress);
            // 
            // compRTB
            // 
            this.compRTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compRTB.Location = new System.Drawing.Point(195, 25);
            this.compRTB.Name = "compRTB";
            this.compRTB.ReadOnly = true;
            this.compRTB.Size = new System.Drawing.Size(458, 153);
            this.compRTB.TabIndex = 8;
            this.compRTB.Text = "";
            // 
            // wordscompletedTB
            // 
            this.wordscompletedTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordscompletedTB.Location = new System.Drawing.Point(15, 45);
            this.wordscompletedTB.Name = "wordscompletedTB";
            this.wordscompletedTB.Size = new System.Drawing.Size(100, 23);
            this.wordscompletedTB.TabIndex = 6;
            this.wordscompletedTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scoreboardBOX
            // 
            this.scoreboardBOX.BackColor = System.Drawing.Color.Transparent;
            this.scoreboardBOX.Controls.Add(this.mistakesTB);
            this.scoreboardBOX.Controls.Add(this.mistakesLB);
            this.scoreboardBOX.Controls.Add(this.wordcompletedLB);
            this.scoreboardBOX.Controls.Add(this.wordscompletedTB);
            this.scoreboardBOX.ForeColor = System.Drawing.Color.White;
            this.scoreboardBOX.Location = new System.Drawing.Point(10, 55);
            this.scoreboardBOX.Name = "scoreboardBOX";
            this.scoreboardBOX.Size = new System.Drawing.Size(149, 137);
            this.scoreboardBOX.TabIndex = 10;
            this.scoreboardBOX.TabStop = false;
            this.scoreboardBOX.Text = "ScoreBoard";
            // 
            // mistakesTB
            // 
            this.mistakesTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.mistakesTB.Location = new System.Drawing.Point(12, 100);
            this.mistakesTB.Name = "mistakesTB";
            this.mistakesTB.Size = new System.Drawing.Size(100, 23);
            this.mistakesTB.TabIndex = 9;
            this.mistakesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mistakesLB
            // 
            this.mistakesLB.AutoSize = true;
            this.mistakesLB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.mistakesLB.ForeColor = System.Drawing.SystemColors.Control;
            this.mistakesLB.Location = new System.Drawing.Point(36, 81);
            this.mistakesLB.Name = "mistakesLB";
            this.mistakesLB.Size = new System.Drawing.Size(60, 15);
            this.mistakesLB.TabIndex = 8;
            this.mistakesLB.Text = "Mistakes";
            // 
            // wordcompletedLB
            // 
            this.wordcompletedLB.AutoSize = true;
            this.wordcompletedLB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordcompletedLB.ForeColor = System.Drawing.Color.White;
            this.wordcompletedLB.Location = new System.Drawing.Point(12, 27);
            this.wordcompletedLB.Name = "wordcompletedLB";
            this.wordcompletedLB.Size = new System.Drawing.Size(114, 15);
            this.wordcompletedLB.TabIndex = 7;
            this.wordcompletedLB.Text = "Words Completed";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SpeedTyping.Properties.Resources.starpngresize__2_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(103, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // stopBN
            // 
            this.stopBN.BackColor = System.Drawing.Color.Transparent;
            this.stopBN.BackgroundImage = global::SpeedTyping.Properties.Resources.stoppngresize;
            this.stopBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stopBN.FlatAppearance.BorderSize = 0;
            this.stopBN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stopBN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stopBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBN.Location = new System.Drawing.Point(25, 279);
            this.stopBN.Name = "stopBN";
            this.stopBN.Size = new System.Drawing.Size(100, 36);
            this.stopBN.TabIndex = 11;
            this.stopBN.TabStop = false;
            this.stopBN.UseVisualStyleBackColor = false;
            this.stopBN.Click += new System.EventHandler(this.stopBN_Click);
            // 
            // startBN
            // 
            this.startBN.BackColor = System.Drawing.Color.Transparent;
            this.startBN.BackgroundImage = global::SpeedTyping.Properties.Resources.startpngresize;
            this.startBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.startBN.FlatAppearance.BorderSize = 0;
            this.startBN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startBN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBN.Location = new System.Drawing.Point(25, 237);
            this.startBN.Name = "startBN";
            this.startBN.Size = new System.Drawing.Size(100, 36);
            this.startBN.TabIndex = 1;
            this.startBN.TabStop = false;
            this.startBN.UseVisualStyleBackColor = false;
            this.startBN.Click += new System.EventHandler(this.startBN_Click);
            // 
            // timerBN
            // 
            this.timerBN.BackColor = System.Drawing.Color.Transparent;
            this.timerBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.timerBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timerBN.Enabled = false;
            this.timerBN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.timerBN.FlatAppearance.BorderSize = 0;
            this.timerBN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.timerBN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.timerBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerBN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.timerBN.ForeColor = System.Drawing.Color.White;
            this.timerBN.Location = new System.Drawing.Point(659, 64);
            this.timerBN.Name = "timerBN";
            this.timerBN.Size = new System.Drawing.Size(171, 60);
            this.timerBN.TabIndex = 14;
            this.timerBN.TabStop = false;
            this.timerBN.Text = "Get Ready!";
            this.timerBN.UseVisualStyleBackColor = false;
            this.timerBN.Visible = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametimer_Tick);
            // 
            // lastsocrepersecTB
            // 
            this.lastsocrepersecTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.lastsocrepersecTB.Location = new System.Drawing.Point(303, 312);
            this.lastsocrepersecTB.Name = "lastsocrepersecTB";
            this.lastsocrepersecTB.Size = new System.Drawing.Size(213, 21);
            this.lastsocrepersecTB.TabIndex = 15;
            this.lastsocrepersecTB.Visible = false;
            // 
            // deleteifincorrectCB
            // 
            this.deleteifincorrectCB.AutoSize = true;
            this.deleteifincorrectCB.BackColor = System.Drawing.Color.Transparent;
            this.deleteifincorrectCB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteifincorrectCB.ForeColor = System.Drawing.Color.White;
            this.deleteifincorrectCB.Location = new System.Drawing.Point(25, 407);
            this.deleteifincorrectCB.Name = "deleteifincorrectCB";
            this.deleteifincorrectCB.Size = new System.Drawing.Size(188, 22);
            this.deleteifincorrectCB.TabIndex = 16;
            this.deleteifincorrectCB.Text = "Delete word if incorrect";
            this.deleteifincorrectCB.UseVisualStyleBackColor = false;
            this.deleteifincorrectCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernameTB.Location = new System.Drawing.Point(25, 354);
            this.usernameTB.MaxLength = 4;
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(111, 23);
            this.usernameTB.TabIndex = 17;
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.BackColor = System.Drawing.Color.Transparent;
            this.usernameLB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernameLB.ForeColor = System.Drawing.Color.Transparent;
            this.usernameLB.Location = new System.Drawing.Point(46, 336);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(76, 15);
            this.usernameLB.TabIndex = 18;
            this.usernameLB.Text = "Your Name:";
            // 
            // highscoreBN
            // 
            this.highscoreBN.BackColor = System.Drawing.Color.Transparent;
            this.highscoreBN.BackgroundImage = global::SpeedTyping.Properties.Resources.highscore;
            this.highscoreBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highscoreBN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.highscoreBN.Enabled = false;
            this.highscoreBN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.highscoreBN.FlatAppearance.BorderSize = 0;
            this.highscoreBN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.highscoreBN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.highscoreBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscoreBN.Location = new System.Drawing.Point(606, 219);
            this.highscoreBN.Name = "highscoreBN";
            this.highscoreBN.Size = new System.Drawing.Size(200, 72);
            this.highscoreBN.TabIndex = 19;
            this.highscoreBN.TabStop = false;
            this.highscoreBN.UseVisualStyleBackColor = false;
            this.highscoreBN.Visible = false;
            // 
            // newLB
            // 
            this.newLB.AutoSize = true;
            this.newLB.BackColor = System.Drawing.Color.Transparent;
            this.newLB.Enabled = false;
            this.newLB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.newLB.ForeColor = System.Drawing.Color.White;
            this.newLB.Location = new System.Drawing.Point(666, 198);
            this.newLB.Name = "newLB";
            this.newLB.Size = new System.Drawing.Size(80, 35);
            this.newLB.TabIndex = 20;
            this.newLB.Text = "NEW";
            this.newLB.Visible = false;
            // 
            // highscoreBT
            // 
            this.highscoreBT.AutoSize = true;
            this.highscoreBT.BackColor = System.Drawing.Color.Transparent;
            this.highscoreBT.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreBT.ForeColor = System.Drawing.Color.White;
            this.highscoreBT.Location = new System.Drawing.Point(603, 291);
            this.highscoreBT.Name = "highscoreBT";
            this.highscoreBT.Size = new System.Drawing.Size(76, 18);
            this.highscoreBT.TabIndex = 22;
            this.highscoreBT.Text = "highscore";
            this.highscoreBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.highscoreBT.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(645, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Highest Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(720, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "© Daniel Ezra";
            // 
            // cointimer
            // 
            this.cointimer.Interval = 50;
            this.cointimer.Tick += new System.EventHandler(this.cointimer_Tick);
            // 
            // coin1
            // 
            this.coin1.BackColor = System.Drawing.Color.Transparent;
            this.coin1.BackgroundImage = global::SpeedTyping.Properties.Resources.starpngresize__2_;
            this.coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coin1.Enabled = false;
            this.coin1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.coin1.FlatAppearance.BorderSize = 0;
            this.coin1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.coin1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.coin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coin1.Location = new System.Drawing.Point(65, -100);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(32, 27);
            this.coin1.TabIndex = 25;
            this.coin1.TabStop = false;
            this.coin1.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpeedTyping.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.highscoreBT);
            this.Controls.Add(this.newLB);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.usernameLB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.deleteifincorrectCB);
            this.Controls.Add(this.lastsocrepersecTB);
            this.Controls.Add(this.timerBN);
            this.Controls.Add(this.compRTB);
            this.Controls.Add(this.stopBN);
            this.Controls.Add(this.scoreboardBOX);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBN);
            this.Controls.Add(this.highscoreBN);
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.scoreboardBOX.ResumeLayout(false);
            this.scoreboardBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.RichTextBox compRTB;
        private System.Windows.Forms.TextBox wordscompletedTB;
        private System.Windows.Forms.GroupBox scoreboardBOX;
        private System.Windows.Forms.TextBox mistakesTB;
        private System.Windows.Forms.Label mistakesLB;
        private System.Windows.Forms.Label wordcompletedLB;
        private System.Windows.Forms.Button stopBN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button timerBN;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.TextBox lastsocrepersecTB;
        private System.Windows.Forms.CheckBox deleteifincorrectCB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Button highscoreBN;
        private System.Windows.Forms.Label newLB;
        private System.Windows.Forms.Label highscoreBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer cointimer;
        private System.Windows.Forms.Button coin1;
    }
}