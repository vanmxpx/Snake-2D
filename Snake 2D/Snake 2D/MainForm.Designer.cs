namespace Snake_2D
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainCanvas = new System.Windows.Forms.Panel();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sghToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblGameOverScore = new System.Windows.Forms.Label();
            this.lblGOScoreCount = new System.Windows.Forms.Label();
            this.lblGO = new System.Windows.Forms.Label();
            this.MainCanvas.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCanvas
            // 
            this.MainCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainCanvas.ContextMenuStrip = this.MenuStrip;
            this.MainCanvas.Controls.Add(this.lblGO);
            this.MainCanvas.Controls.Add(this.lblGOScoreCount);
            this.MainCanvas.Controls.Add(this.lblGameOverScore);
            this.MainCanvas.Controls.Add(this.lblScoreCount);
            this.MainCanvas.Controls.Add(this.lblScore);
            this.MainCanvas.Controls.Add(this.lblTitle);
            this.MainCanvas.Controls.Add(this.lblEnter);
            this.MainCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCanvas.Location = new System.Drawing.Point(0, 0);
            this.MainCanvas.Name = "MainCanvas";
            this.MainCanvas.Size = new System.Drawing.Size(600, 600);
            this.MainCanvas.TabIndex = 0;
            this.MainCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.MainCanvas_Paint);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.gToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.sghToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size(156, 126);
            this.MenuStrip.Opened += new System.EventHandler(this.MenuStrip_Opened);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resumeToolStripMenuItem.Text = "Resume        (P)";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sghToolStripMenuItem
            // 
            this.sghToolStripMenuItem.Name = "sghToolStripMenuItem";
            this.sghToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnter.AutoSize = true;
            this.lblEnter.BackColor = System.Drawing.Color.Transparent;
            this.lblEnter.Font = new System.Drawing.Font("Minion Pro", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnter.Location = new System.Drawing.Point(181, 268);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(239, 39);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Press Enter to start";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(174, 185);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 83);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Snake";
            // 
            // timerMove
            // 
            this.timerMove.Interval = 300;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Enabled = false;
            this.lblScore.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(4, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 23);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            this.lblScore.Visible = false;
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreCount.Enabled = false;
            this.lblScoreCount.Font = new System.Drawing.Font("Lucida Calligraphy", 13F, System.Drawing.FontStyle.Bold);
            this.lblScoreCount.Location = new System.Drawing.Point(81, 9);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(23, 23);
            this.lblScoreCount.TabIndex = 3;
            this.lblScoreCount.Text = "0";
            this.lblScoreCount.Visible = false;
            // 
            // lblGameOverScore
            // 
            this.lblGameOverScore.AutoSize = true;
            this.lblGameOverScore.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOverScore.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverScore.Location = new System.Drawing.Point(203, 307);
            this.lblGameOverScore.Name = "lblGameOverScore";
            this.lblGameOverScore.Size = new System.Drawing.Size(135, 37);
            this.lblGameOverScore.TabIndex = 4;
            this.lblGameOverScore.Tag = "";
            this.lblGameOverScore.Text = "Your Score:";
            this.lblGameOverScore.Visible = false;
            // 
            // lblGOScoreCount
            // 
            this.lblGOScoreCount.AutoSize = true;
            this.lblGOScoreCount.BackColor = System.Drawing.Color.Transparent;
            this.lblGOScoreCount.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Italic);
            this.lblGOScoreCount.Location = new System.Drawing.Point(344, 307);
            this.lblGOScoreCount.Name = "lblGOScoreCount";
            this.lblGOScoreCount.Size = new System.Drawing.Size(30, 37);
            this.lblGOScoreCount.TabIndex = 5;
            this.lblGOScoreCount.Text = "0";
            this.lblGOScoreCount.Visible = false;
            // 
            // lblGO
            // 
            this.lblGO.AutoSize = true;
            this.lblGO.BackColor = System.Drawing.Color.Transparent;
            this.lblGO.Font = new System.Drawing.Font("Lucida Calligraphy", 40F, System.Drawing.FontStyle.Bold);
            this.lblGO.ForeColor = System.Drawing.Color.Black;
            this.lblGO.Location = new System.Drawing.Point(119, 198);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(357, 70);
            this.lblGO.TabIndex = 6;
            this.lblGO.Text = "Game Over";
            this.lblGO.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.MainCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake 2D";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainCanvas.ResumeLayout(false);
            this.MainCanvas.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainCanvas;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator gToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sghToolStripMenuItem;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Label lblGOScoreCount;
        private System.Windows.Forms.Label lblGameOverScore;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGO;
    }
}

