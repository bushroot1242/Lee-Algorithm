using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualizationTry
{
    
    class Settings
    {
        /// <summary>
        /// Ширина генерированных точек
        /// </summary>
        public static int Width { get; set; }
        /// <summary>
        /// Высота генерированных точек
        /// </summary>
        public static int Height { get; set; }
        /// <summary>
        /// Скорость движения( частота тиканья таймера)
        /// </summary>
        public static int Speed { get; set; }
        /// <summary>
        /// Высота холста
        /// </summary>
        public static int CanvasHeight { get; set; }
        /// <summary>
        /// Ширина холста
        /// </summary>
        public static int CanvasWidth { get; set; }
        /// <summary>
        /// Общий счет
        /// </summary>
        public static int Score { get; set; }
        /// <summary>
        /// Максимальнодостижимая точка по Х на игровом поле(за вычетом границ игрового поля)
        /// </summary>
        public static int XmaxPos
        {
            get
            {
                return (CanvasWidth / Settings.Width) - 1;
            }
        }
        /// <summary>
        /// Максимальнодостижимая точка по У на игровом поле(за вычетом границ игрового поля)
        /// </summary>
        public static int YmaxPos
        {
            get
            {
                return (CanvasHeight / Settings.Height)-1;
            }
        }

        public Settings(int width, int height)
        {
            Width = 16;
            Height = 16;
            Speed = 20;
            CanvasHeight = height;
            CanvasWidth = width;
            
            Snake.Snake_.FoodEaten += ()=> Score++; //скушал вишенку, прибавил очко
        }
    }
}
