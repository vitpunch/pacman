﻿namespace pacman
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.EatedDot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.mainBox)).BeginInit();
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
            this.startButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.startButton_PreviewKeyDown);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 20;
            this.mainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // EatedDot
            // 
            this.EatedDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.EatedDot.Location = new System.Drawing.Point(577, 191);
            this.EatedDot.Name = "EatedDot";
            this.EatedDot.Size = new System.Drawing.Size(188, 63);
            this.EatedDot.TabIndex = 3;
            this.EatedDot.Text = "0";
            this.EatedDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EatedDot.UseWaitCursor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 822);
            this.Controls.Add(this.EatedDot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mainBox);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Игра Pac-Man";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.mainBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.Label EatedDot;

        #endregion

        private System.Windows.Forms.PictureBox mainBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label label1;
    }
}

