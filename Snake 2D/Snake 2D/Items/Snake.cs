using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Snake_2D.Items
{
    public class Snake
    {
        public List<SnakePart> snake = new List<SnakePart>();


        public Snake()
        {
            snake.Add(new SnakePart());
            snake.Add(new SnakePart());
            snake[0].X = (MainForm.SCALE / 2) * MainForm.WIDTH;
            snake[0].Y = ((MainForm.SCALE / 2)-1) * MainForm.HEIGHT;
            snake[1].X = ((MainForm.SCALE / 2)) * MainForm.WIDTH;
            snake[1].Y = ((MainForm.SCALE / 2)-2) * MainForm.HEIGHT;
        }

        #region Snake actions
        public void Move()
        {
            for (int i = snake.Count - 1; i > 0; i--)
                {
                    snake[i] = snake[i - 1];
                }
            snake[0].X -= MainForm.HEIGHT;
        }

        public void Draw(Graphics canv)
        {
            for (int i = 0; i < snake.Count; i++)
            {
                canv.FillRectangle(Brushes.Aqua, snake[i].X, snake[i].Y, MainForm.WIDTH, MainForm.HEIGHT);
            }
        }


        #endregion

    }
}
