using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    class Food : Circle
    {
        
        public Food()
        {
            Snake.Snake_.FoodEaten += getFood;
        }
        static Food food;

        public static Food Food_
        {
            get
            {
                if (food == null)
                    food = new Food();
                return food;
            }
            set
            {
                food = value;
            }

        }
        public static Brush Colore
        {
            get { return Brushes.Green; }
        }
       
        private Food(Circle c)
        {
            X = c.X;
            Y = c.Y;
        }
        public static void getFood()
        {
            Food_ = new Food(Circle.getRandomCircle());
            FPathFinder.FormInstance.UpdateTargetMonitor();
            PathFinder.FindRoute();

        }
        public static void getFood(Circle c)
        {
            Food_ = new Food(c);
        }

    }
}

