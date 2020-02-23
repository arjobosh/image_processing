namespace homework3
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
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.LaplacianBtn = new System.Windows.Forms.Button();
            this.PrewittBtn = new System.Windows.Forms.Button();
            this.SobelBtn = new System.Windows.Forms.Button();
            this.RobertBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(22, 12);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load Image";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Location = new System.Drawing.Point(122, 12);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(512, 512);
            this.ImgBox.TabIndex = 1;
            this.ImgBox.TabStop = false;
            // 
            // LaplacianBtn
            // 
            this.LaplacianBtn.Location = new System.Drawing.Point(22, 74);
            this.LaplacianBtn.Name = "LaplacianBtn";
            this.LaplacianBtn.Size = new System.Drawing.Size(75, 23);
            this.LaplacianBtn.TabIndex = 2;
            this.LaplacianBtn.Text = "Laplacian";
            this.LaplacianBtn.UseVisualStyleBackColor = true;
            this.LaplacianBtn.Click += new System.EventHandler(this.LaplacianBtn_Click);
            // 
            // PrewittBtn
            // 
            this.PrewittBtn.Location = new System.Drawing.Point(22, 103);
            this.PrewittBtn.Name = "PrewittBtn";
            this.PrewittBtn.Size = new System.Drawing.Size(75, 23);
            this.PrewittBtn.TabIndex = 3;
            this.PrewittBtn.Text = "Prewitt";
            this.PrewittBtn.UseVisualStyleBackColor = true;
            this.PrewittBtn.Click += new System.EventHandler(this.PrewittBtn_Click);
            // 
            // SobelBtn
            // 
            this.SobelBtn.Location = new System.Drawing.Point(22, 132);
            this.SobelBtn.Name = "SobelBtn";
            this.SobelBtn.Size = new System.Drawing.Size(75, 23);
            this.SobelBtn.TabIndex = 4;
            this.SobelBtn.Text = "Sobel";
            this.SobelBtn.UseVisualStyleBackColor = true;
            this.SobelBtn.Click += new System.EventHandler(this.SobelBtn_Click);
            // 
            // RobertBtn
            // 
            this.RobertBtn.Location = new System.Drawing.Point(22, 161);
            this.RobertBtn.Name = "RobertBtn";
            this.RobertBtn.Size = new System.Drawing.Size(75, 23);
            this.RobertBtn.TabIndex = 5;
            this.RobertBtn.Text = "Robert";
            this.RobertBtn.UseVisualStyleBackColor = true;
            this.RobertBtn.Click += new System.EventHandler(this.RobertBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(646, 540);
            this.Controls.Add(this.RobertBtn);
            this.Controls.Add(this.SobelBtn);
            this.Controls.Add(this.PrewittBtn);
            this.Controls.Add(this.LaplacianBtn);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.LoadBtn);
            this.Name = "Form1";
            this.Text = "Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Button LaplacianBtn;
        private System.Windows.Forms.Button PrewittBtn;
        private System.Windows.Forms.Button SobelBtn;
        private System.Windows.Forms.Button RobertBtn;
    }
}

