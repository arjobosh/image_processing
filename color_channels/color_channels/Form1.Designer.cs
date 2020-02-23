namespace homework1
{
    partial class Form1
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.RedScale = new System.Windows.Forms.Button();
            this.GreenScale = new System.Windows.Forms.Button();
            this.BlueScale = new System.Windows.Forms.Button();
            this.GrayScale = new System.Windows.Forms.Button();
            this.CyanScale = new System.Windows.Forms.Button();
            this.MagentaScale = new System.Windows.Forms.Button();
            this.YellowScale = new System.Windows.Forms.Button();
            this.IScale = new System.Windows.Forms.Button();
            this.QScale = new System.Windows.Forms.Button();
            this.UScale = new System.Windows.Forms.Button();
            this.VScale = new System.Windows.Forms.Button();
            this.CbScale = new System.Windows.Forms.Button();
            this.CrScale = new System.Windows.Forms.Button();
            this.YIQ = new System.Windows.Forms.Button();
            this.YUV = new System.Windows.Forms.Button();
            this.YCrCb = new System.Windows.Forms.Button();
            this.CMY = new System.Windows.Forms.Button();
            this.CMYK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(12, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(90, 23);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Image";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(224, 12);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(512, 512);
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // RedScale
            // 
            this.RedScale.Location = new System.Drawing.Point(108, 51);
            this.RedScale.Name = "RedScale";
            this.RedScale.Size = new System.Drawing.Size(90, 23);
            this.RedScale.TabIndex = 2;
            this.RedScale.Text = "Red Scale";
            this.RedScale.UseVisualStyleBackColor = true;
            this.RedScale.Click += new System.EventHandler(this.RedScale_Click);
            // 
            // GreenScale
            // 
            this.GreenScale.Location = new System.Drawing.Point(108, 80);
            this.GreenScale.Name = "GreenScale";
            this.GreenScale.Size = new System.Drawing.Size(90, 23);
            this.GreenScale.TabIndex = 3;
            this.GreenScale.Text = "Green Scale";
            this.GreenScale.UseVisualStyleBackColor = true;
            this.GreenScale.Click += new System.EventHandler(this.GreenScale_Click);
            // 
            // BlueScale
            // 
            this.BlueScale.Location = new System.Drawing.Point(108, 109);
            this.BlueScale.Name = "BlueScale";
            this.BlueScale.Size = new System.Drawing.Size(90, 23);
            this.BlueScale.TabIndex = 4;
            this.BlueScale.Text = "Blue Scale";
            this.BlueScale.UseVisualStyleBackColor = true;
            this.BlueScale.Click += new System.EventHandler(this.BlueScale_Click);
            // 
            // GrayScale
            // 
            this.GrayScale.Location = new System.Drawing.Point(12, 51);
            this.GrayScale.Name = "GrayScale";
            this.GrayScale.Size = new System.Drawing.Size(90, 23);
            this.GrayScale.TabIndex = 5;
            this.GrayScale.Text = "Gray Scale";
            this.GrayScale.UseVisualStyleBackColor = true;
            this.GrayScale.Click += new System.EventHandler(this.GrayScale_Click);
            // 
            // CyanScale
            // 
            this.CyanScale.Location = new System.Drawing.Point(108, 138);
            this.CyanScale.Name = "CyanScale";
            this.CyanScale.Size = new System.Drawing.Size(90, 23);
            this.CyanScale.TabIndex = 6;
            this.CyanScale.Text = "Cyan Scale";
            this.CyanScale.UseVisualStyleBackColor = true;
            this.CyanScale.Click += new System.EventHandler(this.CyanScale_Click);
            // 
            // MagentaScale
            // 
            this.MagentaScale.Location = new System.Drawing.Point(108, 167);
            this.MagentaScale.Name = "MagentaScale";
            this.MagentaScale.Size = new System.Drawing.Size(90, 23);
            this.MagentaScale.TabIndex = 7;
            this.MagentaScale.Text = "Magenta Scale";
            this.MagentaScale.UseVisualStyleBackColor = true;
            this.MagentaScale.Click += new System.EventHandler(this.MagentaScale_Click);
            // 
            // YellowScale
            // 
            this.YellowScale.Location = new System.Drawing.Point(108, 196);
            this.YellowScale.Name = "YellowScale";
            this.YellowScale.Size = new System.Drawing.Size(90, 23);
            this.YellowScale.TabIndex = 8;
            this.YellowScale.Text = "Yellow Scale";
            this.YellowScale.UseVisualStyleBackColor = true;
            this.YellowScale.Click += new System.EventHandler(this.YellowScale_Click);
            // 
            // IScale
            // 
            this.IScale.Location = new System.Drawing.Point(108, 225);
            this.IScale.Name = "IScale";
            this.IScale.Size = new System.Drawing.Size(90, 23);
            this.IScale.TabIndex = 9;
            this.IScale.Text = "I Scale";
            this.IScale.UseVisualStyleBackColor = true;
            this.IScale.Click += new System.EventHandler(this.IScale_Click);
            // 
            // QScale
            // 
            this.QScale.Location = new System.Drawing.Point(108, 254);
            this.QScale.Name = "QScale";
            this.QScale.Size = new System.Drawing.Size(90, 23);
            this.QScale.TabIndex = 10;
            this.QScale.Text = "Q Scale";
            this.QScale.UseVisualStyleBackColor = true;
            this.QScale.Click += new System.EventHandler(this.QScale_Click);
            // 
            // UScale
            // 
            this.UScale.Location = new System.Drawing.Point(108, 283);
            this.UScale.Name = "UScale";
            this.UScale.Size = new System.Drawing.Size(90, 23);
            this.UScale.TabIndex = 11;
            this.UScale.Text = "U Scale";
            this.UScale.UseVisualStyleBackColor = true;
            this.UScale.Click += new System.EventHandler(this.UScale_Click);
            // 
            // VScale
            // 
            this.VScale.Location = new System.Drawing.Point(108, 312);
            this.VScale.Name = "VScale";
            this.VScale.Size = new System.Drawing.Size(90, 23);
            this.VScale.TabIndex = 12;
            this.VScale.Text = "V Scale";
            this.VScale.UseVisualStyleBackColor = true;
            this.VScale.Click += new System.EventHandler(this.VScale_Click);
            // 
            // CbScale
            // 
            this.CbScale.Location = new System.Drawing.Point(108, 370);
            this.CbScale.Name = "CbScale";
            this.CbScale.Size = new System.Drawing.Size(90, 23);
            this.CbScale.TabIndex = 14;
            this.CbScale.Text = "Cb Scale";
            this.CbScale.UseVisualStyleBackColor = true;
            this.CbScale.Click += new System.EventHandler(this.CbScale_Click);
            // 
            // CrScale
            // 
            this.CrScale.Location = new System.Drawing.Point(108, 341);
            this.CrScale.Name = "CrScale";
            this.CrScale.Size = new System.Drawing.Size(90, 23);
            this.CrScale.TabIndex = 13;
            this.CrScale.Text = "Cr Scale";
            this.CrScale.UseVisualStyleBackColor = true;
            this.CrScale.Click += new System.EventHandler(this.CrScale_Click);
            // 
            // YIQ
            // 
            this.YIQ.Location = new System.Drawing.Point(12, 225);
            this.YIQ.Name = "YIQ";
            this.YIQ.Size = new System.Drawing.Size(90, 23);
            this.YIQ.TabIndex = 15;
            this.YIQ.Text = "YIQ";
            this.YIQ.UseVisualStyleBackColor = true;
            this.YIQ.Click += new System.EventHandler(this.YIQ_Click);
            // 
            // YUV
            // 
            this.YUV.Location = new System.Drawing.Point(12, 283);
            this.YUV.Name = "YUV";
            this.YUV.Size = new System.Drawing.Size(90, 23);
            this.YUV.TabIndex = 16;
            this.YUV.Text = "YUV";
            this.YUV.UseVisualStyleBackColor = true;
            this.YUV.Click += new System.EventHandler(this.YUV_Click);
            // 
            // YCrCb
            // 
            this.YCrCb.Location = new System.Drawing.Point(12, 341);
            this.YCrCb.Name = "YCrCb";
            this.YCrCb.Size = new System.Drawing.Size(90, 23);
            this.YCrCb.TabIndex = 17;
            this.YCrCb.Text = "YCrCb";
            this.YCrCb.UseVisualStyleBackColor = true;
            this.YCrCb.Click += new System.EventHandler(this.YCrCb_Click);
            // 
            // CMY
            // 
            this.CMY.Location = new System.Drawing.Point(12, 138);
            this.CMY.Name = "CMY";
            this.CMY.Size = new System.Drawing.Size(90, 23);
            this.CMY.TabIndex = 18;
            this.CMY.Text = "CMY";
            this.CMY.UseVisualStyleBackColor = true;
            this.CMY.Click += new System.EventHandler(this.CMY_Click);
            // 
            // CMYK
            // 
            this.CMYK.Location = new System.Drawing.Point(12, 167);
            this.CMYK.Name = "CMYK";
            this.CMYK.Size = new System.Drawing.Size(90, 23);
            this.CMYK.TabIndex = 19;
            this.CMYK.Text = "CMYK";
            this.CMYK.UseVisualStyleBackColor = true;
            this.CMYK.Click += new System.EventHandler(this.CMYK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 536);
            this.Controls.Add(this.CMYK);
            this.Controls.Add(this.CMY);
            this.Controls.Add(this.YCrCb);
            this.Controls.Add(this.YUV);
            this.Controls.Add(this.YIQ);
            this.Controls.Add(this.CbScale);
            this.Controls.Add(this.CrScale);
            this.Controls.Add(this.VScale);
            this.Controls.Add(this.UScale);
            this.Controls.Add(this.QScale);
            this.Controls.Add(this.IScale);
            this.Controls.Add(this.YellowScale);
            this.Controls.Add(this.MagentaScale);
            this.Controls.Add(this.CyanScale);
            this.Controls.Add(this.GrayScale);
            this.Controls.Add(this.BlueScale);
            this.Controls.Add(this.GreenScale);
            this.Controls.Add(this.RedScale);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Image Color Channel Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button RedScale;
        private System.Windows.Forms.Button GreenScale;
        private System.Windows.Forms.Button BlueScale;
        private System.Windows.Forms.Button GrayScale;
        private System.Windows.Forms.Button CyanScale;
        private System.Windows.Forms.Button MagentaScale;
        private System.Windows.Forms.Button YellowScale;
        private System.Windows.Forms.Button IScale;
        private System.Windows.Forms.Button QScale;
        private System.Windows.Forms.Button UScale;
        private System.Windows.Forms.Button VScale;
        private System.Windows.Forms.Button CbScale;
        private System.Windows.Forms.Button CrScale;
        private System.Windows.Forms.Button YIQ;
        private System.Windows.Forms.Button YUV;
        private System.Windows.Forms.Button YCrCb;
        private System.Windows.Forms.Button CMY;
        private System.Windows.Forms.Button CMYK;
    }
}

