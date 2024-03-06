namespace UI
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeLabel = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.timeList = new System.Windows.Forms.ListBox();
            this.thread = new System.Windows.Forms.TrackBar();
            this.spp = new System.Windows.Forms.TrackBar();
            this.threadLabel = new System.Windows.Forms.Label();
            this.sppLabel = new System.Windows.Forms.Label();
            this.configBox = new System.Windows.Forms.GroupBox();
            this.maxDepthNumber = new System.Windows.Forms.Label();
            this.maxDepthLabel = new System.Windows.Forms.Label();
            this.maxDepth = new System.Windows.Forms.TrackBar();
            this.threadNumber = new System.Windows.Forms.Label();
            this.sppNumber = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.renderButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spp)).BeginInit();
            this.configBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(10, 82);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(74, 15);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Rozmiar (px)";
            // 
            // size
            // 
            this.size.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.size.Location = new System.Drawing.Point(10, 99);
            this.size.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.size.Maximum = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            this.size.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(245, 23);
            this.size.TabIndex = 0;
            this.size.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // timeList
            // 
            this.timeList.FormattingEnabled = true;
            this.timeList.ItemHeight = 15;
            this.timeList.Location = new System.Drawing.Point(10, 148);
            this.timeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeList.Name = "timeList";
            this.timeList.Size = new System.Drawing.Size(246, 349);
            this.timeList.TabIndex = 2;
            // 
            // thread
            // 
            this.thread.Location = new System.Drawing.Point(5, 50);
            this.thread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thread.Maximum = 64;
            this.thread.Minimum = 1;
            this.thread.Name = "thread";
            this.thread.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.thread.Size = new System.Drawing.Size(45, 320);
            this.thread.TabIndex = 3;
            this.thread.Value = 1;
            this.thread.Scroll += new System.EventHandler(this.threadCount_Scroll);
            // 
            // spp
            // 
            this.spp.Location = new System.Drawing.Point(191, 50);
            this.spp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spp.Maximum = 100;
            this.spp.Minimum = 1;
            this.spp.Name = "spp";
            this.spp.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.spp.Size = new System.Drawing.Size(45, 320);
            this.spp.SmallChange = 3;
            this.spp.TabIndex = 4;
            this.spp.Value = 8;
            this.spp.Scroll += new System.EventHandler(this.sppCount_Scroll);
            // 
            // threadLabel
            // 
            this.threadLabel.AutoSize = true;
            this.threadLabel.Location = new System.Drawing.Point(5, 25);
            this.threadLabel.Name = "threadLabel";
            this.threadLabel.Size = new System.Drawing.Size(37, 15);
            this.threadLabel.TabIndex = 5;
            this.threadLabel.Text = "Wątki";
            // 
            // sppLabel
            // 
            this.sppLabel.Location = new System.Drawing.Point(170, 17);
            this.sppLabel.Name = "sppLabel";
            this.sppLabel.Size = new System.Drawing.Size(70, 30);
            this.sppLabel.TabIndex = 6;
            this.sppLabel.Text = "Próbki na pixel";
            this.sppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // configBox
            // 
            this.configBox.Controls.Add(this.maxDepthNumber);
            this.configBox.Controls.Add(this.maxDepthLabel);
            this.configBox.Controls.Add(this.maxDepth);
            this.configBox.Controls.Add(this.threadNumber);
            this.configBox.Controls.Add(this.sppNumber);
            this.configBox.Controls.Add(this.spp);
            this.configBox.Controls.Add(this.sppLabel);
            this.configBox.Controls.Add(this.thread);
            this.configBox.Controls.Add(this.threadLabel);
            this.configBox.Location = new System.Drawing.Point(849, 9);
            this.configBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configBox.Name = "configBox";
            this.configBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.configBox.Size = new System.Drawing.Size(245, 390);
            this.configBox.TabIndex = 7;
            this.configBox.TabStop = false;
            this.configBox.Text = "Konfiguracja";
            // 
            // maxDepthNumber
            // 
            this.maxDepthNumber.AutoSize = true;
            this.maxDepthNumber.Location = new System.Drawing.Point(98, 372);
            this.maxDepthNumber.Name = "maxDepthNumber";
            this.maxDepthNumber.Size = new System.Drawing.Size(19, 15);
            this.maxDepthNumber.TabIndex = 13;
            this.maxDepthNumber.Text = "32";
            // 
            // maxDepthLabel
            // 
            this.maxDepthLabel.Location = new System.Drawing.Point(77, 14);
            this.maxDepthLabel.Name = "maxDepthLabel";
            this.maxDepthLabel.Size = new System.Drawing.Size(88, 31);
            this.maxDepthLabel.TabIndex = 12;
            this.maxDepthLabel.Text = "Maksymalna ilość odbić";
            this.maxDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxDepth
            // 
            this.maxDepth.LargeChange = 4;
            this.maxDepth.Location = new System.Drawing.Point(98, 50);
            this.maxDepth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxDepth.Maximum = 64;
            this.maxDepth.Minimum = 1;
            this.maxDepth.Name = "maxDepth";
            this.maxDepth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.maxDepth.Size = new System.Drawing.Size(45, 320);
            this.maxDepth.TabIndex = 11;
            this.maxDepth.Value = 32;
            this.maxDepth.Scroll += new System.EventHandler(this.depth_Scroll);
            // 
            // threadNumber
            // 
            this.threadNumber.AutoSize = true;
            this.threadNumber.Location = new System.Drawing.Point(5, 372);
            this.threadNumber.Name = "threadNumber";
            this.threadNumber.Size = new System.Drawing.Size(13, 15);
            this.threadNumber.TabIndex = 10;
            this.threadNumber.Text = "1";
            // 
            // sppNumber
            // 
            this.sppNumber.AutoSize = true;
            this.sppNumber.Location = new System.Drawing.Point(191, 372);
            this.sppNumber.Name = "sppNumber";
            this.sppNumber.Size = new System.Drawing.Size(13, 15);
            this.sppNumber.TabIndex = 8;
            this.sppNumber.Text = "8";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(10, 130);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(91, 15);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "Czas wykonania";
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(849, 404);
            this.renderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(245, 45);
            this.renderButton.TabIndex = 9;
            this.renderButton.Text = "Renderuj";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(849, 453);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(245, 45);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Zapisz do pliku";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "bmp";
            this.saveFileDialog.Filter = "24-bit bitmap (*.bmp)|*.bmp";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image.Location = new System.Drawing.Point(272, 16);
            this.image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(560, 480);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 11;
            this.image.TabStop = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.image);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.size);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.configBox);
            this.Controls.Add(this.timeList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Window";
            this.Text = "RayTracer";
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spp)).EndInit();
            this.configBox.ResumeLayout(false);
            this.configBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label sizeLabel;
        private NumericUpDown size;
        private ListBox timeList;
        private TrackBar thread;
        private TrackBar spp;
        private Label threadLabel;
        private Label sppLabel;
        private GroupBox configBox;
        private Label sppNumber;
        private Label timeLabel;
        private Label threadNumber;
        private Button renderButton;
        private Button saveButton;
        private SaveFileDialog saveFileDialog;
        private PictureBox image;
        private TrackBar maxDepth;
        private Label maxDepthLabel;
        private Label maxDepthNumber;
    }
}