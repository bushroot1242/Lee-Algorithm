using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    public static class PathFinder
    {
        static PathFinder()
        {
            //съели вишенку ищем путь к новой
            Snake.Snake_.FoodEaten += FindRoute;
        }
        /// <summary>
        /// Получить строковое представление двумерной матрицы с волнами
        /// </summary>
        /// <returns></returns>
        public static string getMatrix()
        {
            if (cMap == null)
                return string.Empty;

            else
                return IntArrayToString(cMap);
        }
        /// <summary>
        /// Тут лежит матрица с волнами
        /// </summary>
        static int[,] cMap;
        /// <summary>
        /// Тут хранится список точек, для передвижения змейки для достижения цели
        /// </summary>
        private static Queue<Circle> path;
        public static Queue<Circle> Path
        {
            get
            {
                if (path == null)
                {
                    path = new Queue<Circle>();
                }
                return path;

            }
            private set { path = value; }
        }

        /// <summary>
        /// Точка входа для запуска алгаритма поиска пути
        /// </summary>
        public static void FindRoute()
        {
            Path = new Queue<Circle>();
            FindWave();//пустить распространение волны
            RestorePath();//идем обратно
        }

        /// <summary>
        /// Запустить распространение волны
        /// </summary>
        public static void FindWave()
        {
            int[,] Map = getMapMatrix();//обновляем текущее состояние карты
            cMap = new int[Map.GetLength(0), Map.GetLength(1)];//клон карты с обозначениями припятствий
            bool add = true;

            int x, y,
                step = 0;//идентификатор волны
            for (y = 0; y < cMap.GetLength(0); y++)
                for (x = 0; x < cMap.GetLength(1); x++)
                {
                    if (isWall(Map[y, x])) setWall(y, x);
                    else setSpace(y, x);//нас тут еще не было
                }

            cMap[Food.Food_.X, Food.Food_.Y] = 0;//Идем от цели

            x = Snake.Snake_.X;//малая оптимизация, чтоб не начинать поиск с нуля
            y = Snake.Snake_.Y;

            while (add)
            {
                add = false;
                for (y = 1; y < Map.GetLength(1) - 1; y++)
                    for (x = 1; x < Map.GetLength(0) - 1; x++)
                    {
                        if (cMap[x, y] == step)
                        {
                            if (y - 1 >= 0 && cMap[x - 1, y] != -2 && cMap[x - 1, y] == -1)
                                cMap[x - 1, y] = step + 1;
                            if (x - 1 >= 0 && cMap[x, y - 1] != -2 && cMap[x, y - 1] == -1)
                                cMap[x, y - 1] = step + 1;
                            if (y + 1 < Map.GetLength(1) && cMap[x + 1, y] != -2 && cMap[x + 1, y] == -1)
                                cMap[x + 1, y] = step + 1;
                            if (x + 1 < Map.GetLength(0) && cMap[x, y + 1] != -2 && cMap[x, y + 1] == -1)
                                cMap[x, y + 1] = step + 1;
                        }
                    }
                step++;
                add = true;
                if (cMap[Snake.Snake_.X, Snake.Snake_.Y] != -1)//точка достижима
                    add = false;
                try {
                    if (step > Map.GetLength(0) * Map.GetLength(1))//точка не достижима
                    {
                        add = false;
                        throw new YouWillNotPassExeption();
                    } }
                catch(YouWillNotPassExeption) { }
            }
        }
        /// <summary>
        /// Проверка - стена ?
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        static bool isWall(int p)
        {
            if (p == 1)
                return true;
            else return false;

        }
        /// <summary>
        /// Пометить участок как стена
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        static void setWall(int x, int y)
        {
            cMap[x, y] = -2;
        }
        /// <summary>
        /// Пометить участок как проходимый
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        static void setSpace(int x, int y)
        {
            cMap[x, y] = -1;
        }

        private static void RestorePath()
        {
            int W = Settings.XmaxPos;         // ширина рабочего поля
            int H = Settings.YmaxPos;       // высота рабочего поля
            int[] dx = { 1, 0, -1, 0 };   // смещения, соответствующие соседям ячейки
            int[] dy = { 0, 1, 0, -1 };   // справа, сверху, слева и снизу
            int x = Snake.Snake_.X,
                y = Snake.Snake_.Y;
            int len = cMap[x, y];
            int d = len;

            while (d > -1)
            {
                Path.Enqueue(new Circle(x, y));                // записываем ячейку (x, y) в путь
                d--;
                for (int k = 0; k < 4; ++k)
                {
                    int iy = y + dy[k], ix = x + dx[k];
                    if (iy >= 0 && iy < H && ix >= 0 && ix < W &&
                         cMap[ix, iy] == d)
                    {
                        x = x + dx[k];
                        y = y + dy[k];           // переходим в ячейку, которая на 1 ближе к старту
                        break;
                    }
                }
            }

        }

        static string IntArrayToString(int[,] matrix)
        {

            string s = string.Empty;


            for (int i = 0; i <= matrix.GetLength(1) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    s += String.Format("{0,3 }", matrix[j, i]);
                }
                s += "\n";
            }

            return s;

        }
        /// <summary>
        /// Генерация матричного представления местности
        /// </summary>
        /// <returns></returns>
        static int[,] getMapMatrix()
        {
            int[,] map = new int[Settings.XmaxPos + 1, Settings.YmaxPos + 1];

            foreach (Circle b in GameObjects.Border)
            {
                map[b.X, b.Y] = 1;
            }
            foreach (Circle o in GameObjects.Obstacles)
            {
                map[o.X, o.Y] = 1;
            }

            return map;
        }
    }
}
