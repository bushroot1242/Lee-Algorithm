using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    public class Circle : IEquatable<Circle>
    {
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }

        public Circle()
        {
            X = 0;
            Y = 0;
        }

        public Circle(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X:{X},Y:{Y}";
        }
        public bool Equals(Circle other)
        {
            if (X == other.X && Y == other.Y)
                return true;
            else
                return false;
        }
        static Random rnd = new Random();
        /// <summary>
        /// Возвращает случайную точку, генерированную вне змейки и цели
        /// </summary>
        /// <returns></returns>
        public static Circle getRandomCircle()
        {
            bool flag = false;
            Circle circle = new Circle();
            while (!flag)
            {
                flag = true;
                circle = new Circle(rnd.Next(1, Settings.YmaxPos), rnd.Next(1, Settings.XmaxPos));
                if (!circle.Equals(Snake.Snake_) && !circle.Equals(Food.Food_))
                {
                    foreach (Circle c in GameObjects.Obstacles)
                    {
                        if (circle.Equals(c))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    flag = false;
                }
            }
            return circle;
        }

    }
}
