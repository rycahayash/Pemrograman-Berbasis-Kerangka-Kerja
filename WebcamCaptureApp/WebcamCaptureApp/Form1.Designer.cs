namespace WebcamCaptureApp
{
    partial class Form1
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            buttonStartCamera = new Button();
            buttonCapture = new Button();
            textBox1 = new TextBox();
            labelFileName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(405, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(383, 371);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 371);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonStartCamera
            // 
            buttonStartCamera.Location = new Point(136, 389);
            buttonStartCamera.Name = "buttonStartCamera";
            buttonStartCamera.Size = new Size(149, 29);
            buttonStartCamera.TabIndex = 3;
            buttonStartCamera.Text = "Start Camera";
            buttonStartCamera.UseVisualStyleBackColor = true;
            buttonStartCamera.Click += buttonStartCamera_Click;
            // 
            // buttonCapture
            // 
            buttonCapture.Location = new Point(536, 389);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(149, 29);
            buttonCapture.TabIndex = 4;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = true;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 436);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(671, 27);
            textBox1.TabIndex = 5;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Location = new Point(26, 439);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(70, 20);
            labelFileName.TabIndex = 6;
            labelFileName.Text = "fileName";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(labelFileName);
            Controls.Add(textBox1);
            Controls.Add(buttonCapture);
            Controls.Add(buttonStartCamera);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonStartCamera;
        private Button buttonCapture;
        private TextBox textBox1;
        private Label labelFileName;
    }
}