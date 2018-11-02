using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    class GameObjects
    {
         static GameObjects()
        {
            Snake.Snake_.FoodEaten += NewTrack;//вишенка съедена, сбрасываем список пройденного пути
            FPathFinder.FormInstance.bnGeneratColliders.Click += SetMoreObstacles;//подписались обрабатывать запрос генерации новых препятствий
        }
        static List<Circle> obstacles, border;
        static List<Dot> track;
        /// <summary>
        /// Список препятствий
        /// </summary>
        public static List<Circle> Obstacles
        {
            get
            {
                if (obstacles == null)
                {
                    obstacles = new List<Circle>();
 
                }
                return obstacles;
            }
        }
        /// <summary>
        /// Пройденный путь
        /// </summary>
        public static List<Dot> Track
        {
            get
            {
                if (track == null)
                {
                    track = new List<Dot>();
                }
                return track;
            }
        }
        /// <summary>
        /// Границы игрового поля
        /// </summary>
        public static List<Circle> Border
        {
            get
            {
                if (border == null)
                {
                    generateBorders();
                }
                return border;
            }
        }
        /// <summary>
        /// Обнулить список пройденного пути
        /// </summary>
        public static void NewTrack()
        {
            Track.Clear();
        }
        /// <summary>
        /// Записать новую точку в список пройденного пути
        /// </summary>
        public static void AddTrack()
        {
            Track.Add(new Dot(Snake.Snake_));
        }

        /// <summary>
        /// Нужно больше препятствий!!!!11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SetMoreObstacles(object sender, EventArgs e)
        {
            Snake.NeedToStop = true;
            for (int i = 0; i < 30; i++)
            {
                Obstacles.Add(Circle.getRandomCircle());
            }
            PathFinder.FindRoute();
            Snake.NeedToStop = false;
        }
        /// <summary>
        /// Обнулить список препятсвтий
        /// </summary>
        public static void FlushObstacles()
        {
            Obstacles.Clear();
        }
        /// <summary>
        /// Образовать границу игрового поля
        /// </summary>
        private static void generateBorders()
        {
            border = new List<Circle>();
            for (int i = 0; i <= Settings.YmaxPos; i++)
            {
                border.Add(new Circle(0, i));//вертикал
                border.Add(new Circle(Settings.YmaxPos, i));
            }
            for (int i = 1; i <= Settings.XmaxPos; i++)
            {
                border.Add(new Circle(i, 0));//горизонтал
                border.Add(new Circle(i, Settings.XmaxPos));
            }
        }

    }
}
