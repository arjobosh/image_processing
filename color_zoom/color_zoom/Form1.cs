// Joshua Arber

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace homework2
{
    public partial class PixelForm : Form
    {
        struct Pixel
        {
            public Point coord;
            public Color color;
        }

        public PixelForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // prompt to open image file
            OpenFileDialog image_open = new OpenFileDialog();

            image_open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (image_open.ShowDialog() == DialogResult.OK)
            {
                ImgBox.Image = new Bitmap(image_open.FileName);
                ImgBox.Size = ImgBox.Image.Size;
            }
        }

        private void ImgBox_MouseClick(object sender, MouseEventArgs e)
        {
            // get the coordinates of the clicked position
            // find the pixels surrounding it in 8x8
            // clicked location = location.x, location.y
            // top left of square = location.x - 3, location.y - 3        
            Point top_left;
            top_left = new Point(e.Location.X - 3, e.Location.Y - 3);
            CoordLbl.Text = "Clicked Coordinate: (" + e.Location.X.ToString() + 
                ", " + e.Location.Y.ToString() + ")";

            int x_bound = (ImgBox.Width - 1) - 7;
            int y_bound = (ImgBox.Height - 1) - 7;

            // coordinate out of bounds?            
            if (top_left.X < 0 && top_left.Y < 0)
            {
                top_left.X = 0;
                top_left.Y = 0;
            }
            else if (top_left.X >= x_bound && top_left.Y >= y_bound)
            {
                top_left.X = x_bound;
                top_left.Y = y_bound;
            }
            else if (top_left.X < 0 && top_left.Y >= y_bound)
            {
                top_left.X += 3;
                top_left.Y -= 4;
            }
            else if (top_left.X >= x_bound && top_left.Y < 0)
            {
                top_left.X -= 4;
                top_left.Y += 3;
            }
            else if (top_left.X < 0 && top_left.Y >= 0)
            {
                top_left.X += 3;
            }
            else if (top_left.X >= 0 && top_left.Y < 0)
            {
                top_left.Y += 3;
            }
            else if (top_left.X > x_bound && top_left.Y >= 0)
            {
                top_left.X -= 4;
            }
            else if (top_left.X >= 0 && top_left.Y > y_bound)
            {
                top_left.Y -= 4;
            }

            int og_top_left_x = top_left.X;
            TopLeftLbl.Text = "Top Left Coordinate of Pixel Grids: (" + top_left.X.ToString() + 
                ", " + top_left.Y.ToString() + ")";

            Pixel[,] pixel_square = new Pixel[8, 8];
            int size = pixel_square.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    pixel_square[i, j].coord = top_left;
                    top_left.X++;
                }
                top_left.X = og_top_left_x;
                top_left.Y++;
            }

            Bitmap bm = (Bitmap)ImgBox.Image;

            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Point a = pixel_square[i, j].coord;
                    Color z = Color.Black;

                    pixel_square[i, j].color = bm.GetPixel(a.X, a.Y);                    
                    
                    /*Console.Write(i.ToString() + "," + j.ToString() + ": ");
                    Console.Write(a);
                    Console.Write(" ; ");
                    Console.Write(pixel_square[i, j].color);
                    Console.Write('\n');*/
                }
            }
       
            // create new forms
            char[] order = { 'R', 'G', 'B', 'Z' };
            for (int i = 0; i < 4; i++)
            {
                CreateForm(bm, pixel_square, order[i]);
            }                                            
        }

        private void CreateForm(Bitmap map, Pixel[,] px, char channel)
        {
            // create squares to represent each pixel
            // retain image size => find appropriate size of each square based on image width/height
            int s = px.GetLength(0);
            int cell_width = map.Width / 8;
            int cell_height = map.Height / 8;
            string title = "";
            Size cell_size = new Size(cell_width - 10, cell_height - 10);
            Point start = new Point(10, 10);
            Form f = new Form();
            Bitmap channel_map = new Bitmap(map.Width, map.Height);
            PictureBox p = new PictureBox();
            p.Size = channel_map.Size;

            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    using (Graphics g = Graphics.FromImage(channel_map))
                    {
                        Color c = px[i, j].color;
                        Color d;
                        
                        Rectangle r = new Rectangle(start, cell_size);

                        if (channel == 'R')
                        {
                            d = Color.FromArgb(c.R, c.R, c.R);
                        }
                        else if (channel == 'G')
                        {
                            d = Color.FromArgb(c.G, c.G, c.G);
                        }
                        else if (channel == 'B')
                        {
                            d = Color.FromArgb(c.B, c.B, c.B);
                        }
                        else
                        {
                            d = Color.FromArgb(c.R, c.G, c.B);
                        }

                        g.DrawRectangle(new Pen(d), r);
                        g.FillRectangle(new SolidBrush(d), r);

                        using (Font font = new Font("Century Gothic", 10, FontStyle.Bold, GraphicsUnit.Point))
                        {
                            Brush b;
                            if (c.R < 128 || c.G < 128 || c.B < 128)
                                b = Brushes.White;
                            else
                                b = Brushes.Black;

                            if (channel == 'R')
                            {
                                g.DrawString("R: " + c.R.ToString(), font, b, r);
                                title = "Red";
                            }
                            else if (channel == 'G')
                            {
                                g.DrawString("G: " + c.G.ToString(), font, b, r);
                                title = "Green";
                            }
                            else if (channel == 'B')
                            {
                                g.DrawString("B: " + c.B.ToString(), font, b, r);
                                title = "Blue";
                            }
                            else
                            {
                                //g.DrawString("R: " + c.R.ToString() + "\n" + "G: " + c.G.ToString() + "\n"
                                //    + "B: " + c.B.ToString(), font, b, r);
                                title = "RGB";
                            }
                        }
                        p.Image = channel_map;
                        start.X += cell_size.Width + 10;
                    }
                }
                start.X = 10;
                start.Y += cell_size.Height + 10;
            }

            f.Controls.Add(p);
            f.Text = title + " Values";
            f.Width = channel_map.Width + 25;
            f.Height = channel_map.Height + 50;
            f.Show();
        }
    }
}
