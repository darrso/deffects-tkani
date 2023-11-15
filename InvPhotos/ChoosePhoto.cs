using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChoosePhoto : Form
    {
        // move window params
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // image params
        private Bitmap image;
        private string image_name;
        public ChoosePhoto()
        {
            InitializeComponent();
            Point location_middle = new Point(this.Width / 2, this.Height / 2);
            openFileDialog1.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            pictureBox1.AllowDrop = true;
        }
        #region Select photo by openFileDialog
        private void GetPhoto(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog1.FileName);
                image_name = openFileDialog1.FileName;
                pictureSelected();
            }
        }

        private void SelectPhotoL_MouseEnter(object sender, EventArgs e)
        {
            SelectPhotoL.ForeColor = Color.SkyBlue;
        }
        private void SelectPhotoL_MouseLeave(object sender, EventArgs e)
        {
            SelectPhotoL.ForeColor = Color.SteelBlue;
        }
        #endregion

        #region Select photo by Drag and Drop
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                string[] fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    image = (Bitmap)Image.FromFile(fileNames[0]);
                    image_name = fileNames[0];
                    pictureSelected();
                }
            }
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }
        #endregion

        private void pictureSelected()
        {
            pictureBox1.Image = image;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            setInfoToRichBox();
            GoButton.Visible = true;
        }
        private static (Color, int) GetMostUsedColor(Bitmap theBitMap)
        {
            List<Color> TenMostUsedColors = new List<Color>();
            List<int> TenMostUsedColorIncidences = new List<int>();

            Color MostUsedColor = Color.Empty;
            int MostUsedColorIncidence = 0;

            Dictionary<int, int> dctColorIncidence = new Dictionary<int, int>();

            // this is what you want to speed up with unmanaged code
            for (int row = 0; row < theBitMap.Size.Width; row++)
            {
                for (int col = 0; col < theBitMap.Size.Height; col++)
                {
                    int pixelColor = theBitMap.GetPixel(row, col).ToArgb();

                    if (dctColorIncidence.Keys.Contains(pixelColor))
                    {
                        dctColorIncidence[pixelColor]++;
                    }
                    else
                    {
                        dctColorIncidence.Add(pixelColor, 1);
                    }
                }
            }
            var dctSortedByValueHighToLow = dctColorIncidence.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (KeyValuePair<int, int> kvp in dctSortedByValueHighToLow.Take(10))
            {
                TenMostUsedColors.Add(Color.FromArgb(kvp.Key));
                TenMostUsedColorIncidences.Add(kvp.Value);
            }

            return (Color.FromArgb(dctSortedByValueHighToLow.First().Key), dctSortedByValueHighToLow.First().Value);
        }

        private void setInfoToRichBox()
        {
            int image_width = ((Image)image).Width;
            int image_height = ((Image)image).Height;
            Color c;
            int i;
            (c, i)= GetMostUsedColor(image);

            string text = $"Size: {image_width}x{image_height}\n" +
                $"Most used color: {c.ToString()}\n"+
                $"Image path: {image_name}";
            richTextBox1.Text = text;
            richTextBox1.Visible = true;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {

        }

        #region Window
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Закрытие", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void InWindow_Click(object sender, EventArgs e)
        {
            if(WindowState== FormWindowState.Maximized)
            {
                WindowState= FormWindowState.Normal;
            }
            else
            {
                WindowState= FormWindowState.Maximized;
            }
            
        }

        private void Svernut_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ChoosePhoto_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void ChoosePhoto_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void ChoosePhoto_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void Info_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
