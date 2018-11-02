using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    class Snake:Circle
    {
        /// <summary>
        /// Нужна ли остановка ( используется в методе мув при генерации новых препятствий)
        /// </summary>
        public static bool NeedToStop
        {
            get; set;
        }
        static Snake snake;

        public static Snake Snake_
        {
            get {
                if (snake == null)
                    snake = new Snake();
                return snake;
            }
            private set { snake = value; }

        }
        /// <summary>
        /// Змейка не может проложить путь к вишенке, придется делать сепуку
        /// </summary>
        public static void Kill()
        {
            Snake_.X = 10;
            Snake_.Y = 5;
            GameObjects.NewTrack();
        }
        /// <summary>
        /// Кисть для отрисовки на холсте
        /// </summary>
        public static Brush Colore
        {
            get { return Brushes.Green; }
        }
        private Snake()
        {
            X = 10;Y = 5;
            //Двигаемся при тиканьи таймера
            FPathFinder.FormInstance.gameTimer.Tick += Move;
        }
        private void SetPosition(Circle c)
        {
            Snake_.X = c.X;
            Snake_.Y = c.Y;
        }
        /// <summary>
        /// Двигайся
        /// </summary>
        /// <param name="sender">не используемые аргументы</param>
        /// <param name="e">не используемые аргументы</param>
        public static void Move(object sender, EventArgs e)
        {
            if (NeedToStop)//если нет необходимости стоять
                return;
            GameObjects.AddTrack();//генерируем новый список для хранения пройденного пути
            if (PathFinder.Path.Count != 0)//путь вообще есть?
            {
                Snake_.SetPosition(PathFinder.Path.Dequeue());// поочередно проходим по точкам
            }
            if (Food.Food_.Equals(Snake.Snake_))// если достигли цели
            {
                Snake_.FoodEaten();//генерируем событие "Вишенка съедена"
                PathFinder.FindRoute();//Начинаем поиск новой
            }
            FPathFinder.FormInstance.UpdateSnakeMonitor();//обновляем табло




        }
        public delegate void FoodEatenDelegate();
        public event FoodEatenDelegate FoodEaten;
    }
}
