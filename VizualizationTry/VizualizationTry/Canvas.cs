using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    public static class Canvas
    {
        public static void RePaint(Graphics e)
        {

            Graphics canvas = e;

            canvas.FillEllipse(Brushes.Green, new Rectangle(
                Snake.Snake_.X * Settings.Width,
                Snake.Snake_.Y * Settings.Height,
                Settings.Width, Settings.Height));

            foreach (Circle c in GameObjects.Border)
            {
                canvas.FillEllipse(Brushes.Black, new Rectangle(
                c.X * Settings.Width,
                c.Y * Settings.Height,
                Settings.Width, Settings.Height));
            }

            foreach (Circle c in GameObjects.Obstacles)
            {
                canvas.FillEllipse(Brushes.Black, new Rectangle(
                c.X * Settings.Width,
                c.Y * Settings.Height,
                Settings.Width, Settings.Height));
            }
            foreach (Dot t in GameObjects.Track)
            {
                canvas.FillEllipse(Dot.Colore, new Rectangle(
                    (t.X * Settings.Width) + 5,
                    (t.Y * Settings.Height) + 5,
                    Dot.Size, Dot.Size));
            }
            canvas.FillEllipse(Brushes.Red, new Rectangle(
                Food.Food_.X * Settings.Width,
                Food.Food_.Y * Settings.Height,
                Settings.Width, Settings.Height));
        }
    }
}
