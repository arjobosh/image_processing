using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog image_open = new OpenFileDialog();

            image_open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if(image_open.ShowDialog() == DialogResult.OK)
            {
                ImageBox.Image = new Bitmap(image_open.FileName);
                ImageBox.Size = ImageBox.Image.Size;
            }
        }

        private void GrayScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "grayonly", "Gray Scale");
        }

        private void RedScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "redonly", "Red Scale");
        }

        private void GreenScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "greenonly", "Green Scale");
        }

        private void BlueScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "blueonly", "Blue Scale");
        }

        private void CyanScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "cyanonly", "Cyan Scale");
        }

        private void MagentaScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "magentaonly", "Mangenta Scale");
        }

        private void YellowScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "yellowonly", "Yellow Scale");
        }

        private void IScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "ionly", "I Scale");
        }

        private void QScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "qonly", "Q Scale");
        }

        private void UScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "uonly", "U Scale");
        }

        private void VScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "vonly", "V Scale");
        }

        private void CrScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "cronly", "Cr Scale");
        }

        private void CbScale_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "cbonly", "Cb Scale");            
        }

        private void YIQ_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "yiq", "YIQ Scale");
        }

        private void YUV_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "yuv", "YUV Scale");
        }

        private void YCrCb_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "ycc", "YCrCb Scale");
        }

        private void CMY_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "cmy", "CMY Scale");
        }

        private void CMYK_Click(object sender, EventArgs e)
        {
            CreateForm((Bitmap)ImageBox.Image, "cmyk", "CMYK Scale");
        }

        private void CreateForm(Bitmap image, string color_key, string form_text)
        {
            Form f = new Form();
            Bitmap img = image;
            Bitmap instance = new Bitmap(img.Width, img.Height);

            if(image != null)
            {
                instance = ScaleColor(img, color_key);
                PictureBox pb = new PictureBox();
                pb.Size = instance.Size;
                f.Controls.Add(pb);
                pb.Image = instance;
                f.Width = instance.Width + 25;
                f.Height = instance.Height + 50;
                f.Text = form_text;
                f.Show();
            }
        }

        private Bitmap ScaleColor(Bitmap original, string key)
        {
            try
            {
                Bitmap bm = new Bitmap(original.Width, original.Height);
                for (int i = 0; i < original.Width; i++)
                {
                    for (int j = 0; j < original.Height; j++)
                    {
                        Color og_color = original.GetPixel(i, j);

                        int val1 = 0, val2 = 0, val3 = 0;

                        // determine which color space to convert from RGB to
                        switch (key)
                        {
                            case "grayonly":
                                int g = CalculateYSpace(og_color);
                                val1 = val2 = val3 = g;
                                break;
                            case "redonly":
                                val1 = val2 = val3 = og_color.R;
                                break;
                            case "greenonly":
                                val1 = val2 = val3 = og_color.G;
                                break;
                            case "blueonly":
                                val1 = val2 = val3 = og_color.B;
                                break;
                            case "cyanonly":
                                int c = CalculateCyan(og_color, false);
                                val1 = val2 = val3 = c;
                                break;
                            case "magentaonly":
                                int m = CalculateMagenta(og_color, false);
                                val1 = val2 = val3 = m;
                                break;
                            case "yellowonly":
                                int y = CalculateYellow(og_color, false);
                                val1 = val2 = val3 = y;
                                break;
                            case "ionly":
                                int i_val = CalculateISpace(og_color);
                                val1 = val2 = val3 = i_val;
                                break;
                            case "qonly":
                                int q_val = CalculateQSpace(og_color);
                                val1 = val2 = val3 = q_val;
                                break;
                            case "uonly":
                                int u = CalculateUSpace(og_color);
                                val1 = val2 = val3 = u;
                                break;
                            case "vonly":
                                int v = CalculateVSpace(og_color);
                                val1 = val2 = val3 = v;
                                break;
                            case "cronly":
                                int cr = CalculateCrSpace(og_color);
                                val1 = val2 = val3 = cr;
                                break;
                            case "cbonly":
                                int cb = CalculateCbSpace(og_color);
                                val1 = val2 = val3 = cb;
                                break;
                            case "cmy":
                                val1 = CalculateCyan(og_color, false);
                                val2 = CalculateMagenta(og_color, false);
                                val3 = CalculateYellow(og_color, false);                                
                                break;
                            case "cmyk":
                                val1 = CalculateCyan(og_color, true);
                                val2 = CalculateMagenta(og_color, true);
                                val3 = CalculateYellow(og_color, true);
                                break;
                            case "yiq":
                                val1 = CalculateYSpace(og_color);
                                val2 = CalculateISpace(og_color);
                                val3 = CalculateQSpace(og_color);
                                break;
                            case "yuv":
                                val1 = CalculateYSpace(og_color);
                                val2 = CalculateUSpace(og_color);
                                val3 = CalculateVSpace(og_color);
                                break;
                            case "ycc":
                                val1 = CalculateYSpace(og_color);
                                val2 = CalculateCrSpace(og_color);
                                val3 = CalculateCbSpace(og_color);
                                break;
                        }

                        Color new_color = Color.FromArgb(val1, val2, val3);

                        bm.SetPixel(i, j, new_color);
                    }
                }
                return bm;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        private int CalculateYSpace(Color pixel_color)
        {
            return (int)((pixel_color.R * 0.3) + (pixel_color.G * 0.59) + (pixel_color.B * 0.11));
        }

        private float CalculateKSpace(Color pixel_color)
        {
            float temp = Math.Max(pixel_color.R / 255.0f, pixel_color.G / 255.0f);
            float b = pixel_color.B / 255.0f;
            if (temp > b)
            {
                return 1 - temp;
            }
            else
            {
                return 1 - b;
            }
        }

        private int CalculateISpace(Color pixel_color)
        {
            float max_val = 0;

            int i_scale = (int)((pixel_color.R * 0.596) + (pixel_color.G * -0.275) + (pixel_color.B * -0.321));
            if (i_scale < 0)
            {
                max_val = -0.596f;
            }
            else
            {
                max_val = 0.596f;
            }
            i_scale = (int)(i_scale / max_val);
            return i_scale;
        }

        private int CalculateQSpace(Color pixel_color)
        {
            float offset = 0.523f * 255;

            return (int)((pixel_color.R * 0.21) + (pixel_color.G * -0.52) + (pixel_color.B * 0.31)) + (int)offset;
        }

        private int CalculateUSpace(Color pixel_color)
        {
            float offset = 0.437f * 255;

            return (int)((pixel_color.R * -0.147) + (pixel_color.G * -0.289) + (pixel_color.B * 0.437)) + (int)offset;

        }

        private int CalculateVSpace(Color pixel_color)
        {
            float max_val = 0;

            int v_scale = (int)((pixel_color.R * 0.615) + (pixel_color.G * -0.515) + (pixel_color.B * -0.100));
            if (v_scale < 0)
            {
                max_val = -0.615f;
            }
            else
            {
                max_val = 0.615f;
            }
            return (int)(v_scale / max_val);            
        }

        private int CalculateCrSpace(Color pixel_color)
        {
            float max_val = 0;

            int cr_scale = (int)((pixel_color.R * 0.5) + (pixel_color.G * -0.419) + (pixel_color.B * -0.081));
            if (cr_scale < 0)
            {
                max_val = -0.5f;
            }
            else
            {
                max_val = 0.5f;
            }
            return (int)(cr_scale / max_val);
        }

        private int CalculateCbSpace(Color pixel_color)
        {
            float max_val = 0;
            int cb_scale = (int)((pixel_color.R * -0.169) + (pixel_color.G * -0.331) + (pixel_color.B * 0.5));
            if (cb_scale < 0)
            {
                max_val = -0.5f;
            }
            else
            {
                max_val = 0.5f;
            }
            return (int)(cb_scale / max_val);
        }
        
        private int CalculateCyan(Color pixel_color, bool is_k)
        {
            if (!is_k)
            {
                return 255 - pixel_color.R;
            }
            else
            {
                float k = CalculateKSpace(pixel_color);
                if (k == 1)
                {
                    k = 0;
                }
                float c = (1 - (pixel_color.R / 255.0f) - k) / (1 - k);
                return (int)(c * 255);
            }
        }

        private int CalculateMagenta(Color pixel_color, bool is_k)
        {
            if (!is_k)
            {
                return 255 - pixel_color.G;
            }
            else
            {
                float k = CalculateKSpace(pixel_color);
                if (k == 1)
                {
                    k = 0;
                }
                float m = (1 - (pixel_color.G / 255.0f) - k) / (1 - k);
                return (int)(m * 255);
            }
        }

        private int CalculateYellow(Color pixel_color, bool is_k)
        {
            if (!is_k)
            {
                return 255 - pixel_color.B;
            }
            else
            {
                float k = CalculateKSpace(pixel_color);
                if (k == 1)
                {
                    k = 0;
                }
                float y = (1 - (pixel_color.B / 255.0f) - k) / (1 - k);
                return (int)(y * 255);
            }
        }

    }
}
