namespace WindowsFormsApp1
{
    partial class ChoosePhoto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectPhotoL = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.PictureBox();
            this.InWindow = new System.Windows.Forms.PictureBox();
            this.Svernut = new System.Windows.Forms.PictureBox();
            this.Info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Svernut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.draganddrop;
            this.pictureBox1.Location = new System.Drawing.Point(217, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.GetPhoto);
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // SelectPhotoL
            // 
            this.SelectPhotoL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectPhotoL.AutoSize = true;
            this.SelectPhotoL.BackColor = System.Drawing.Color.Transparent;
            this.SelectPhotoL.Font = new System.Drawing.Font("Bahnschrift", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectPhotoL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SelectPhotoL.Location = new System.Drawing.Point(755, 715);
            this.SelectPhotoL.Name = "SelectPhotoL";
            this.SelectPhotoL.Size = new System.Drawing.Size(162, 28);
            this.SelectPhotoL.TabIndex = 1;
            this.SelectPhotoL.Text = "Выбрать фото";
            this.SelectPhotoL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SelectPhotoL.Click += new System.EventHandler(this.GetPhoto);
            this.SelectPhotoL.MouseEnter += new System.EventHandler(this.SelectPhotoL_MouseEnter);
            this.SelectPhotoL.MouseLeave += new System.EventHandler(this.SelectPhotoL_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.richTextBox1.Location = new System.Drawing.Point(923, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(204, 249);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // GoButton
            // 
            this.GoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GoButton.FlatAppearance.BorderSize = 10;
            this.GoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GoButton.Location = new System.Drawing.Point(923, 503);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(204, 50);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Обработка";
            this.GoButton.UseVisualStyleBackColor = false;
            this.GoButton.Visible = false;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Image = global::WindowsFormsApp1.Properties.Resources._640px_Cross_red_circle_svg;
            this.Close.Location = new System.Drawing.Point(1114, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(20, 20);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 4;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // InWindow
            // 
            this.InWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InWindow.BackColor = System.Drawing.Color.Transparent;
            this.InWindow.Image = global::WindowsFormsApp1.Properties.Resources.copy_document_blue_circle_20582__2_;
            this.InWindow.Location = new System.Drawing.Point(1092, 0);
            this.InWindow.Name = "InWindow";
            this.InWindow.Size = new System.Drawing.Size(20, 20);
            this.InWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InWindow.TabIndex = 5;
            this.InWindow.TabStop = false;
            this.InWindow.Click += new System.EventHandler(this.InWindow_Click);
            // 
            // Svernut
            // 
            this.Svernut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Svernut.BackColor = System.Drawing.Color.Transparent;
            this.Svernut.Image = global::WindowsFormsApp1.Properties.Resources._9884852;
            this.Svernut.Location = new System.Drawing.Point(1069, 0);
            this.Svernut.Name = "Svernut";
            this.Svernut.Size = new System.Drawing.Size(20, 20);
            this.Svernut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Svernut.TabIndex = 6;
            this.Svernut.TabStop = false;
            this.Svernut.Click += new System.EventHandler(this.Svernut_Click);
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.BackColor = System.Drawing.Color.Transparent;
            this.Info.Image = global::WindowsFormsApp1.Properties.Resources.information_button_black_circle_outline_18682;
            this.Info.Location = new System.Drawing.Point(1113, 744);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(20, 20);
            this.Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Info.TabIndex = 7;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // ChoosePhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1428926_download_hd_wallpaper_black_and_white_1920x1080_for_ipad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 763);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Svernut);
            this.Controls.Add(this.InWindow);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SelectPhotoL);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChoosePhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Photo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChoosePhoto_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoosePhoto_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChoosePhoto_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Svernut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SelectPhotoL;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox InWindow;
        private System.Windows.Forms.PictureBox Svernut;
        private System.Windows.Forms.PictureBox Info;
    }
}

