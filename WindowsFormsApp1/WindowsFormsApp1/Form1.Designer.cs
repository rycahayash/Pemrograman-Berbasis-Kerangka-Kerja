namespace WindowsFormsApp1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKurang = new System.Windows.Forms.Button();
            this.buttonKali = new System.Windows.Forms.Button();
            this.buttonBagi = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelNilai1 = new System.Windows.Forms.Label();
            this.labelNilai2 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(64, 213);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(83, 64);
            this.buttonTambah.TabIndex = 29;
            this.buttonTambah.Text = "+";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKurang
            // 
            this.buttonKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKurang.Location = new System.Drawing.Point(64, 283);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new System.Drawing.Size(83, 64);
            this.buttonKurang.TabIndex = 30;
            this.buttonKurang.Text = "-";
            this.buttonKurang.UseVisualStyleBackColor = true;
            this.buttonKurang.Click += new System.EventHandler(this.buttonKurang_Click);
            // 
            // buttonKali
            // 
            this.buttonKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKali.Location = new System.Drawing.Point(153, 213);
            this.buttonKali.Name = "buttonKali";
            this.buttonKali.Size = new System.Drawing.Size(83, 64);
            this.buttonKali.TabIndex = 31;
            this.buttonKali.Text = "*";
            this.buttonKali.UseVisualStyleBackColor = true;
            this.buttonKali.Click += new System.EventHandler(this.buttonKali_Click);
            // 
            // buttonBagi
            // 
            this.buttonBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBagi.Location = new System.Drawing.Point(153, 283);
            this.buttonBagi.Name = "buttonBagi";
            this.buttonBagi.Size = new System.Drawing.Size(83, 64);
            this.buttonBagi.TabIndex = 32;
            this.buttonBagi.Text = "/";
            this.buttonBagi.UseVisualStyleBackColor = true;
            this.buttonBagi.Click += new System.EventHandler(this.buttonBagi_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(136, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 26);
            this.textBox2.TabIndex = 34;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(136, 165);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 26);
            this.textBox3.TabIndex = 35;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNilai1
            // 
            this.labelNilai1.AutoSize = true;
            this.labelNilai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNilai1.Location = new System.Drawing.Point(71, 59);
            this.labelNilai1.Name = "labelNilai1";
            this.labelNilai1.Size = new System.Drawing.Size(59, 20);
            this.labelNilai1.TabIndex = 36;
            this.labelNilai1.Text = "Nilai 1 :";
            this.labelNilai1.Click += new System.EventHandler(this.nilai1_Click);
            // 
            // labelNilai2
            // 
            this.labelNilai2.AutoSize = true;
            this.labelNilai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNilai2.Location = new System.Drawing.Point(71, 115);
            this.labelNilai2.Name = "labelNilai2";
            this.labelNilai2.Size = new System.Drawing.Size(59, 20);
            this.labelNilai2.TabIndex = 37;
            this.labelNilai2.Text = "Nilai 2 :";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(71, 168);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(52, 20);
            this.labelHasil.TabIndex = 38;
            this.labelHasil.Text = "Hasil :";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(242, 213);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 134);
            this.buttonClear.TabIndex = 39;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 413);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelNilai2);
            this.Controls.Add(this.labelNilai1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonBagi);
            this.Controls.Add(this.buttonKali);
            this.Controls.Add(this.buttonKurang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKurang;
        private System.Windows.Forms.Button buttonKali;
        private System.Windows.Forms.Button buttonBagi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelNilai1;
        private System.Windows.Forms.Label labelNilai2;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Button buttonClear;
    }
}

