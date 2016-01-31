using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_2D.Items
{
    public class Apple: SnakePart
    {
        Random rnd = new Random();

        public Apple(List<SnakePart> s)
        {
            NewApple(s);
        }


        #region Apple actions
        public void NewApple(List<SnakePart> s)
        {
            X = rnd.Next(0, 19) * MainForm.HEIGHT;
            Y = rnd.Next(0, 19) * MainForm.WIDTH;
            for (int i = 0; i < s.Count; i++)
            {
                if (s[i].X == X && s[i].Y == Y)
                {
                    NewApple(s);
                    break;
                }
            }
        }

        public void Draw(Graphics canv)
        {
            canv.FillRectangle(Brushes.Teal, X+5, Y+5, MainForm.WIDTH-10, MainForm.HEIGHT-10);
        }

        #endregion

    }
}
