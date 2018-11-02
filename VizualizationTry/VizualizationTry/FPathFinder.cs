using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace VizualizationTry
{
    public partial class FPathFinder : Form
    {
       
        private static FPathFinder formInstance;
        public static FPathFinder FormInstance
        {
            get
            {
                return formInstance;
            }
        }

        public FPathFinder()
        {
            InitializeComponent();
            formInstance = this;
            Snake.Snake_.FoodEaten += updateScore;
            Snake.Snake_.FoodEaten += ShowMatrix;
            bnGeneratColliders.Click += (s,e)=> ShowMatrix();

            new Settings(pbCanvas.Size.Width, pbCanvas.Size.Height);

            gameTimer.Interval = 3000 / Settings.Speed;
            gameTimer.Tick += (x,y) => pbCanvas.Invalidate();
           

            startGame();
        }

        void ShowMatrix()
        {
            string matrix = string.Empty;
            Task t = Task.Factory.StartNew(() =>
            {
                if(label3.InvokeRequired)
                label3.Invoke(new Action(() => { 
                label3.Text = PathFinder.getMatrix();
            }));
            });
        }
       

        public void startGame()
        {
            GameObjects.FlushObstacles();
            Food.getFood();          
            ShowMatrix();
            gameTimer.Start();
        }
        #region Обновляшки всякие
        /// <summary>
        /// Выводим счет на экран
        /// </summary>
        public void updateScore()
        {
            lScore.Text = Settings.Score.ToString();
        }
        /// <summary>
        /// Выводим координаты цели
        /// </summary>
        public void UpdateTargetMonitor()
        {
            lTargetMonitor.Text = Food.Food_.ToString();
        }

        /// <summary>
        /// Выводим координаты змейки
        /// </summary>
        public void UpdateSnakeMonitor()
        {
            lSnakeMonitor.Text = Snake.Snake_.ToString();
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            Canvas.RePaint(e.Graphics);
        }
        #endregion
    }
}
