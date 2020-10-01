namespace pacman
{
    partial class MainForm
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
            this.mainBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Location = new System.Drawing.Point(10, 10);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(560, 620);
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(577, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(188, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 822);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainBox);
            this.Name = "MainForm";
            this.Text = "Игра Pac-Man";
            ((System.ComponentModel.ISupportInitialize)(this.mainBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer mainTimer;
    }
}

