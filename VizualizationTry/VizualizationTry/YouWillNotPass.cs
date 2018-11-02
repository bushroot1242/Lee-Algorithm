using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizualizationTry
{
    [Serializable]
    class YouWillNotPassExeption : ApplicationException
    {
        /// <summary>
        /// Класс, описывающий эксепшн, выкидываемый если путь не может быть найден
        /// </summary>

        public YouWillNotPassExeption()
        {
            FPathFinder.FormInstance.gameTimer.Stop();//останавливаем игровой таймер
            Snake.Kill();//убиваем змейку, чтобы не мучилась

            //предлогаем начать с начала
            if (MessageBox.Show("Точка не достижима", "Приехали", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Retry)
            {
                FPathFinder.FormInstance.startGame();//рестарт
            }
            
           
        }
        public YouWillNotPassExeption(string message) : base(message)
        {
          
        }
        public YouWillNotPassExeption(string message, Exception inner) : base(message, inner) { }
        protected YouWillNotPassExeption(
          SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}

