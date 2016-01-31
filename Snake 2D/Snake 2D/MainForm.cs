﻿using Snake_2D.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_2D
{
    public partial class MainForm : Form
    {

        #region Variables
        public const int HEIGHT = 30;
        public const int WIDTH = 30;
        public const int SCALE = 20;
        bool gameover = true;
        bool pause = true;

        int score = 0;
        int direction = 3; // 1-left, 2-right, 3-up, 4-down;
        static Snake s = new Snake();
        static Apple a = new Apple(s.snake);
        #endregion

        public MainForm()
        { 
            InitializeComponent();
        }


        #region Logic
        public void StartGame()
        {
            score = 0;
            lblScoreCount.Text = Convert.ToString(score);
            lblScore.Visible = true;
            lblScoreCount.Visible = true;
            lblGO.Visible = false;
            lblGameOverScore.Visible = false;
            lblGOScoreCount.Visible = false;
            lblEnter.Visible = false;
            lblTitle.Visible = false;
            timerMove.Enabled = true;
            gameover = false;
            pause = false;
            s = new Snake();
        }

        public void Pause()
        {
            pause = true;
            timerMove.Enabled = false;
            lblTitle.Text = "Snake";
            lblEnter.Text = "       *Paused*";
            lblEnter.Visible = true;
            lblTitle.Visible = true;
        }

        public void Resume()
        {
            pause = false;
            timerMove.Enabled = true;
            lblEnter.Visible = false;
            lblTitle.Visible = false;
        }

        public void GameOver()
        {
            gameover = true;
            timerMove.Enabled = false;
            lblEnter.Text = "Press Enter to retry";
            lblGOScoreCount.Text = Convert.ToString(score);
            lblGO.Visible = true;
            lblEnter.Visible = true;
            lblGOScoreCount.Visible = true;
            lblGameOverScore.Visible = true;
            lblScore.Visible = false;
            lblScoreCount.Visible = false;

        }

        #endregion

        #region FormEvents
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gameover) StartGame();
            if (e.KeyCode == Keys.Escape) Close();
            if (e.KeyCode == Keys.P && !gameover)
            {
                if (pause) Resume();
                else Pause();
            }

            if (e.KeyCode == Keys.Left && direction !=2) direction = 1;
            if (e.KeyCode == Keys.Right && direction != 1) direction = 2;
            if (e.KeyCode == Keys.Up && direction != 4) direction = 3;
            if (e.KeyCode == Keys.Down && direction != 3) direction = 4;
        }

        private void MainCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!gameover)
            {
                a.Draw(e.Graphics);
                s.Draw(e.Graphics);
            }
            Invalidate();
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            s.Move(direction);
            if (s.CheckEat(a.X, a.Y))
            {
                score ++;
                a.NewApple(s.snake);
            }
            if(s.CheckCollision()) GameOver();
            lblScoreCount.Text = Convert.ToString(score);
            MainCanvas.Invalidate();
        }

        private void MenuStrip_Opened(object sender, EventArgs e)
        {
            if (!pause) Pause();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void resumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resume();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

    }
}
