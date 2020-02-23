// Joshua Arber

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework3
{
    public partial class Form1 : Form
    {
        const int THRESHOLD1 = 25;
        const int THRESHOLD2 = 50;
        const int THRESHOLD3 = 100;
        const int THRESHOLD4 = 150;

        public Form1()
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

        private void LaplacianBtn_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImgBox.Image, "Laplacian");
        }

        private void PrewittBtn_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImgBox.Image, "Prewitt");
        }

        private void SobelBtn_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImgBox.Image, "Sobel");
        }

        private void RobertBtn_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImgBox.Image, "Robert");
        }

        private void CreateForm(Bitmap image, string form_title)
        {
            Form f = new Form();
            Bitmap img = image;
            Bitmap gray_instance = new Bitmap(img.Width, img.Height);
            Bitmap edge_instance = new Bitmap(img.Width, img.Height);

            if (image != null)
            {
                gray_instance = ScaleGray(img);

                switch (form_title)
                {
                    case "Laplacian":
                        edge_instance = DetectEdgeLaplacian(gray_instance);
                        break;
                    case "Prewitt":
                        edge_instance = DetectEdgePrewittOrSobel(gray_instance, true);
                        break;
                    case "Sobel":
                        edge_instance = DetectEdgePrewittOrSobel(gray_instance, false);
                        break;
                    case "Robert":
                        edge_instance = DetectEdgeRobert(gray_instance);
                        break;
                    default:
                        break;
                }
                
                PictureBox pb = new PictureBox();
                pb.Size = edge_instance.Size;
                f.Controls.Add(pb);
                pb.Image = edge_instance;
                f.Width = edge_instance.Width + 25;
                f.Height = edge_instance.Height + 50;
                f.Text = form_title;
                f.Show();
            }
        }


        private Bitmap DetectEdgeLaplacian(Bitmap bm)
        {
            Bitmap t = new Bitmap(bm.Width, bm.Height);

            for (int i = 0; i < t.Width; i++)
            {
                if (!(i - 1 < 0) && !(i + 1 > bm.Width - 1))
                {
                    for (int j = 0; j < t.Height; j++)
                    {
                        if (!(j - 1 < 0) && !(j + 1 > bm.Height - 1))
                        {
                            int left, right, up, down, center;
                            int v1, v2, v3, v4;

                            left = bm.GetPixel(i, j - 1).R;
                            right = bm.GetPixel(i, j + 1).R;
                            up = bm.GetPixel(i - 1, j).R;
                            down = bm.GetPixel(i + 1, j).R;
                            v1 = bm.GetPixel(i - 1, j - 1).R;
                            v2 = bm.GetPixel(i - 1, j + 1).R;
                            v3 = bm.GetPixel(i + 1, j - 1).R;
                            v4 = bm.GetPixel(i + 1, j + 1).R;
                            center = bm.GetPixel(i, j).R;

                            int l = (left + right + up + down + v1 + v2 + v3 + v4) - 8 * center;

                            if (l > THRESHOLD2)
                            {
                                t.SetPixel(i, j, Color.White);
                            }
                            else
                            {
                                t.SetPixel(i, j, Color.Black);
                            }
                        }
                    }
                }               
            }
            return t;
        }

        private Bitmap DetectEdgePrewittOrSobel(Bitmap bm, bool is_prewitt)
        {
            Bitmap t = new Bitmap(bm.Width, bm.Height);

            for (int i = 0; i < t.Width; i++)
            {
                if (!(i - 1 < 0) && !(i + 1 > bm.Width - 1))
                {
                    for (int j = 0; j < t.Height; j++)
                    {
                        if (!(j - 1 < 0) && !(j + 1 > bm.Height - 1))
                        {
                            int nw, n, ne, w, e, sw, s, se, nw2, sw2, ne2, se2;
                            int vert, horz, diag1, diag2;
                            double q;

                            if (is_prewitt)
                            {
                                n = bm.GetPixel(i - 1, j).R;
                                s = bm.GetPixel(i + 1, j).R;
                                e = bm.GetPixel(i, j + 1).R;
                                w = bm.GetPixel(i, j - 1).R;
                                nw = bm.GetPixel(i - 1, j - 1).R;
                                sw = bm.GetPixel(i + 1, j - 1).R;
                                ne = bm.GetPixel(i - 1, j + 1).R;
                                se = bm.GetPixel(i + 1, j + 1).R;
                                vert = (ne + e + se) - (nw + w + sw);
                                horz = (sw + s + se) - (nw + n + ne);
                                diag1 = (s + se + e) - (w + nw + n);
                                diag2 = (s + sw + w) - (e + ne + n);
                            }
                            else
                            {
                                n = 2 * bm.GetPixel(i - 1, j).R;
                                s = 2 * bm.GetPixel(i + 1, j).R;
                                e = 2 * bm.GetPixel(i, j + 1).R;
                                w = 2 * bm.GetPixel(i, j - 1).R;
                                nw = bm.GetPixel(i - 1, j - 1).R;
                                sw = bm.GetPixel(i + 1, j - 1).R;
                                ne = bm.GetPixel(i - 1, j + 1).R;
                                se = bm.GetPixel(i + 1, j + 1).R;
                                nw2 = 2 * bm.GetPixel(i - 1, j - 1).R;
                                sw2 = 2 * bm.GetPixel(i + 1, j - 1).R;
                                ne2 = 2 * bm.GetPixel(i - 1, j + 1).R;
                                se2 = 2 * bm.GetPixel(i + 1, j + 1).R;
                                vert = (ne + e + se) - (nw + w + sw);
                                horz = (sw + s + se) - (nw + n + ne);
                                diag1 = (s + se2 + e) - (w + nw2 + n);
                                diag2 = (s + sw2 + w) - (e + ne2 + n);
                            }

                            q = Math.Sqrt(vert * vert + horz * horz + diag1 * diag1 + diag2 * diag2);

                            if (q > THRESHOLD4)
                            {
                                t.SetPixel(i, j, Color.White);
                            }
                            else
                            {
                                t.SetPixel(i, j, Color.Black);
                            }
                        }
                    }
                }
            }
            return t;
        }

        private Bitmap DetectEdgeRobert(Bitmap bm)
        {
            Bitmap t = new Bitmap(bm.Width, bm.Height);

            for (int i = 0; i < bm.Width; i++)
            {
                if (!(i - 1 < 0) && !(i + 1 > bm.Width - 1))
                {
                    for (int j = 0; j < bm.Height; j++)
                    {
                        if (!(j - 1 < 0) && !(j + 1 > bm.Height - 1))
                        {
                            int p1, p2, p3, p4;

                            p1 = bm.GetPixel(i, j).R;
                            p2 = bm.GetPixel(i, j + 1).R;
                            p3 = bm.GetPixel(i + 1, j).R;
                            p4 = bm.GetPixel(i + 1, j + 1).R;

                            double q = Math.Sqrt(Math.Pow(p1 - p4, 2.0) + Math.Pow(p2 - p3, 2.0));

                            if (q > THRESHOLD1) 
                            {
                                t.SetPixel(i, j, Color.White);
                            }
                            else
                            {
                                t.SetPixel(i, j, Color.Black);
                            }
                        }
                    }
                }
            }
            return t;
        }

        private Bitmap ScaleGray(Bitmap original)
        {
            Bitmap bm = (Bitmap)ImgBox.Image;
            Bitmap gray_bm = new Bitmap(bm.Width, bm.Height);

            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    Color og_color = bm.GetPixel(i, j);

                    int g = CalculateYSpace(og_color);

                    Color new_color = Color.FromArgb(g, g, g);

                    gray_bm.SetPixel(i, j, new_color);
                }
            }
            return gray_bm;
        }

        private int CalculateYSpace(Color pixel_color)
        {
            return (int)((pixel_color.R * 0.3) + (pixel_color.G * 0.59) + (pixel_color.B * 0.11));
        }


    }
}
