namespace Pixelator
{
    partial class Form
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
            this.OriginCanvasPanel = new System.Windows.Forms.Panel();
            this.OriginCanvas = new System.Windows.Forms.PictureBox();
            this.PixelateCanvasPanel = new System.Windows.Forms.Panel();
            this.PixelateCanvas = new System.Windows.Forms.PictureBox();
            this.PixelateTrackBar = new System.Windows.Forms.TrackBar();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PixelateButton = new System.Windows.Forms.Button();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.SaveImage = new System.Windows.Forms.SaveFileDialog();
            this.OriginCanvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginCanvas)).BeginInit();
            this.PixelateCanvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixelateCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelateTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginCanvasPanel
            // 
            this.OriginCanvasPanel.AutoScroll = true;
            this.OriginCanvasPanel.Controls.Add(this.OriginCanvas);
            this.OriginCanvasPanel.Location = new System.Drawing.Point(13, 13);
            this.OriginCanvasPanel.Name = "OriginCanvasPanel";
            this.OriginCanvasPanel.Size = new System.Drawing.Size(710, 710);
            this.OriginCanvasPanel.TabIndex = 0;
            // 
            // OriginCanvas
            // 
            this.OriginCanvas.Location = new System.Drawing.Point(4, 4);
            this.OriginCanvas.Name = "OriginCanvas";
            this.OriginCanvas.Size = new System.Drawing.Size(700, 700);
            this.OriginCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.OriginCanvas.TabIndex = 0;
            this.OriginCanvas.TabStop = false;
            // 
            // PixelateCanvasPanel
            // 
            this.PixelateCanvasPanel.AutoScroll = true;
            this.PixelateCanvasPanel.Controls.Add(this.PixelateCanvas);
            this.PixelateCanvasPanel.Location = new System.Drawing.Point(730, 13);
            this.PixelateCanvasPanel.Name = "PixelateCanvasPanel";
            this.PixelateCanvasPanel.Size = new System.Drawing.Size(710, 710);
            this.PixelateCanvasPanel.TabIndex = 1;
            // 
            // PixelateCanvas
            // 
            this.PixelateCanvas.Location = new System.Drawing.Point(4, 4);
            this.PixelateCanvas.Name = "PixelateCanvas";
            this.PixelateCanvas.Size = new System.Drawing.Size(700, 700);
            this.PixelateCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PixelateCanvas.TabIndex = 0;
            this.PixelateCanvas.TabStop = false;
            // 
            // PixelateTrackBar
            // 
            this.PixelateTrackBar.LargeChange = 2;
            this.PixelateTrackBar.Location = new System.Drawing.Point(13, 729);
            this.PixelateTrackBar.Maximum = 20;
            this.PixelateTrackBar.Minimum = 1;
            this.PixelateTrackBar.Name = "PixelateTrackBar";
            this.PixelateTrackBar.Size = new System.Drawing.Size(710, 69);
            this.PixelateTrackBar.TabIndex = 2;
            this.PixelateTrackBar.Value = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(730, 736);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(120, 60);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(856, 736);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 60);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PixelateButton
            // 
            this.PixelateButton.Location = new System.Drawing.Point(982, 738);
            this.PixelateButton.Name = "PixelateButton";
            this.PixelateButton.Size = new System.Drawing.Size(120, 60);
            this.PixelateButton.TabIndex = 5;
            this.PixelateButton.Text = "Pixelate";
            this.PixelateButton.UseVisualStyleBackColor = true;
            this.PixelateButton.Click += new System.EventHandler(this.PixelateButton_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Filter = "(*.png)|*.png";
            // 
            // SaveImage
            // 
            this.SaveImage.Filter = "(*.png)|*.png";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 808);
            this.Controls.Add(this.PixelateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.PixelateTrackBar);
            this.Controls.Add(this.PixelateCanvasPanel);
            this.Controls.Add(this.OriginCanvasPanel);
            this.Name = "Form";
            this.Text = "Pixelator";
            this.OriginCanvasPanel.ResumeLayout(false);
            this.OriginCanvasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginCanvas)).EndInit();
            this.PixelateCanvasPanel.ResumeLayout(false);
            this.PixelateCanvasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PixelateCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelateTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OriginCanvasPanel;
        private System.Windows.Forms.PictureBox OriginCanvas;
        private System.Windows.Forms.Panel PixelateCanvasPanel;
        private System.Windows.Forms.PictureBox PixelateCanvas;
        private System.Windows.Forms.TrackBar PixelateTrackBar;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button PixelateButton;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.SaveFileDialog SaveImage;
    }
}

