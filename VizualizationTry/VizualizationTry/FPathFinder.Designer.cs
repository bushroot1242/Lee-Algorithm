namespace VizualizationTry
{
    partial class FPathFinder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bnGeneratColliders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lSnakeMonitor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lTargetMonitor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Gray;
            this.pbCanvas.Location = new System.Drawing.Point(13, 13);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(528, 528);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // bnGeneratColliders
            // 
            this.bnGeneratColliders.Location = new System.Drawing.Point(593, 22);
            this.bnGeneratColliders.Name = "bnGeneratColliders";
            this.bnGeneratColliders.Size = new System.Drawing.Size(82, 36);
            this.bnGeneratColliders.TabIndex = 0;
            this.bnGeneratColliders.TabStop = false;
            this.bnGeneratColliders.Text = "Создать препятствия";
            this.bnGeneratColliders.UseVisualStyleBackColor = true;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(565, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты тележки";
            // 
            // lSnakeMonitor
            // 
            this.lSnakeMonitor.AutoSize = true;
            this.lSnakeMonitor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lSnakeMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSnakeMonitor.ForeColor = System.Drawing.Color.Yellow;
            this.lSnakeMonitor.Location = new System.Drawing.Point(569, 119);
            this.lSnakeMonitor.Name = "lSnakeMonitor";
            this.lSnakeMonitor.Size = new System.Drawing.Size(187, 24);
            this.lSnakeMonitor.TabIndex = 2;
            this.lSnakeMonitor.Text = "Монитор тележки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(565, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Пункт назначения";
            // 
            // lTargetMonitor
            // 
            this.lTargetMonitor.AutoSize = true;
            this.lTargetMonitor.BackColor = System.Drawing.Color.Black;
            this.lTargetMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTargetMonitor.ForeColor = System.Drawing.Color.Yellow;
            this.lTargetMonitor.Location = new System.Drawing.Point(569, 199);
            this.lTargetMonitor.Name = "lTargetMonitor";
            this.lTargetMonitor.Size = new System.Drawing.Size(281, 24);
            this.lTargetMonitor.TabIndex = 5;
            this.lTargetMonitor.Text = "Монитор точки назначения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(753, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "12";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.BackColor = System.Drawing.Color.Black;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lScore.ForeColor = System.Drawing.Color.Yellow;
            this.lScore.Location = new System.Drawing.Point(569, 292);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(21, 24);
            this.lScore.TabIndex = 8;
            this.lScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(565, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Счет";
            // 
            // FPathFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 738);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lTargetMonitor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lSnakeMonitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnGeneratColliders);
            this.Controls.Add(this.pbCanvas);
            this.KeyPreview = true;
            this.Name = "FPathFinder";
            this.ShowIcon = false;
            this.Text = "Имитатор беспилотной тележки";
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        public System.Windows.Forms.Button bnGeneratColliders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSnakeMonitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lTargetMonitor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label label5;
    }
}

