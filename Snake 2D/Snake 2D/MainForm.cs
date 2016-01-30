using Snake_2D.Items;
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

        Snake s = new Snake();
        #endregion

        public MainForm()
        { 
            InitializeComponent();
        }


        #region FormEvents
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) StartGame();
            if (e.KeyCode == Keys.Escape) Close();
        }

        public void StartGame()
        {
            lblEnter.Visible = false;
            lblTitle.Visible = false;
            timerMove.Enabled = true;
            gameover = false;
            s = new Snake();
            
        }

        private void MainCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!gameover) s.Draw(e.Graphics);
            Invalidate();
        }



        #endregion

        private void timerMove_Tick(object sender, EventArgs e)
        {
            s.Move();

            MainCanvas.Invalidate();
        }
    }
}
