namespace homework2
{
    partial class PixelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.CoordLbl = new System.Windows.Forms.Label();
            this.TopLeftLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(12, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Image";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Location = new System.Drawing.Point(12, 41);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(512, 512);
            this.ImgBox.TabIndex = 1;
            this.ImgBox.TabStop = false;
            this.ImgBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImgBox_MouseClick);
            // 
            // CoordLbl
            // 
            this.CoordLbl.AutoSize = true;
            this.CoordLbl.Location = new System.Drawing.Point(93, 17);
            this.CoordLbl.Name = "CoordLbl";
            this.CoordLbl.Size = new System.Drawing.Size(99, 13);
            this.CoordLbl.TabIndex = 2;
            this.CoordLbl.Text = "Clicked Coordinate:";
            // 
            // TopLeftLbl
            // 
            this.TopLeftLbl.AutoSize = true;
            this.TopLeftLbl.Location = new System.Drawing.Point(254, 17);
            this.TopLeftLbl.Name = "TopLeftLbl";
            this.TopLeftLbl.Size = new System.Drawing.Size(168, 13);
            this.TopLeftLbl.TabIndex = 3;
            this.TopLeftLbl.Text = "Top Left Coordinate of Pixel Grids:";
            // 
            // PixelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 601);
            this.Controls.Add(this.TopLeftLbl);
            this.Controls.Add(this.CoordLbl);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.LoadBtn);
            this.Name = "PixelForm";
            this.Text = "Image Pixel Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Label CoordLbl;
        private System.Windows.Forms.Label TopLeftLbl;
    }
}

