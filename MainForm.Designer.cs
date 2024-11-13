namespace digital_image_processing
{
    partial class MainForm
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
            this.picOriginalBox = new System.Windows.Forms.PictureBox();
            this.picResultBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnColorInvention = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTurnOn = new System.Windows.Forms.Button();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnGaussian = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnMeanRemoval = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnEmbossing = new System.Windows.Forms.Button();
            this.btnSmoothing = new System.Windows.Forms.Button();
            this.btnCoinCounter = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginalBox
            // 
            this.picOriginalBox.BackColor = System.Drawing.Color.Gainsboro;
            this.picOriginalBox.Location = new System.Drawing.Point(122, 91);
            this.picOriginalBox.Name = "picOriginalBox";
            this.picOriginalBox.Size = new System.Drawing.Size(240, 240);
            this.picOriginalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginalBox.TabIndex = 0;
            this.picOriginalBox.TabStop = false;
            // 
            // picResultBox
            // 
            this.picResultBox.BackColor = System.Drawing.Color.Gainsboro;
            this.picResultBox.Location = new System.Drawing.Point(428, 91);
            this.picResultBox.Name = "picResultBox";
            this.picResultBox.Size = new System.Drawing.Size(240, 240);
            this.picResultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResultBox.TabIndex = 1;
            this.picResultBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 16);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Original Photo";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(476, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(112, 16);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Result Photo";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOpen.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(261, 364);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 30);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "LOAD IMG";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(254, 5);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(50, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGray.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.Location = new System.Drawing.Point(307, 5);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(50, 23);
            this.btnGray.TabIndex = 6;
            this.btnGray.Text = "GRAY";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnColorInvention
            // 
            this.btnColorInvention.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnColorInvention.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorInvention.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorInvention.Location = new System.Drawing.Point(413, 5);
            this.btnColorInvention.Name = "btnColorInvention";
            this.btnColorInvention.Size = new System.Drawing.Size(68, 23);
            this.btnColorInvention.TabIndex = 7;
            this.btnColorInvention.Text = "INVERSION";
            this.btnColorInvention.UseVisualStyleBackColor = false;
            this.btnColorInvention.Click += new System.EventHandler(this.btnColorInversion_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistogram.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistogram.Location = new System.Drawing.Point(484, 5);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(80, 23);
            this.btnHistogram.TabIndex = 8;
            this.btnHistogram.Text = "HISTOGRAM";
            this.btnHistogram.UseVisualStyleBackColor = false;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepia.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepia.Location = new System.Drawing.Point(360, 5);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(50, 23);
            this.btnSepia.TabIndex = 9;
            this.btnSepia.Text = "SEPIA";
            this.btnSepia.UseVisualStyleBackColor = false;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(698, 34);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(72, 23);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "SUBTRACT";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(564, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE IMG";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTurnOn
            // 
            this.btnTurnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTurnOn.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOn.Location = new System.Drawing.Point(16, 28);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Size = new System.Drawing.Size(84, 25);
            this.btnTurnOn.TabIndex = 12;
            this.btnTurnOn.Text = "TURN ON";
            this.btnTurnOn.UseVisualStyleBackColor = false;
            this.btnTurnOn.Click += new System.EventHandler(this.btnTurnOn_Click);
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTurnOff.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOff.Location = new System.Drawing.Point(105, 28);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(84, 25);
            this.btnTurnOff.TabIndex = 13;
            this.btnTurnOff.Text = "TURN OFF";
            this.btnTurnOff.UseVisualStyleBackColor = false;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(16, 8);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(176, 46);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Try it with your WEBCAM";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGaussian
            // 
            this.btnGaussian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGaussian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaussian.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaussian.Location = new System.Drawing.Point(323, 33);
            this.btnGaussian.Name = "btnGaussian";
            this.btnGaussian.Size = new System.Drawing.Size(68, 25);
            this.btnGaussian.TabIndex = 15;
            this.btnGaussian.Text = "GAUSSIAN";
            this.btnGaussian.UseVisualStyleBackColor = false;
            this.btnGaussian.Click += new System.EventHandler(this.btnGaussian_Click);
            // 
            // btnSharpen
            // 
            this.btnSharpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSharpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSharpen.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSharpen.Location = new System.Drawing.Point(393, 33);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(68, 25);
            this.btnSharpen.TabIndex = 16;
            this.btnSharpen.Text = "SHARPEN";
            this.btnSharpen.UseVisualStyleBackColor = false;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // btnMeanRemoval
            // 
            this.btnMeanRemoval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMeanRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeanRemoval.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeanRemoval.Location = new System.Drawing.Point(463, 33);
            this.btnMeanRemoval.Name = "btnMeanRemoval";
            this.btnMeanRemoval.Size = new System.Drawing.Size(105, 25);
            this.btnMeanRemoval.TabIndex = 17;
            this.btnMeanRemoval.Text = "MEAN REMOVAL";
            this.btnMeanRemoval.UseVisualStyleBackColor = false;
            this.btnMeanRemoval.Click += new System.EventHandler(this.btnMeanRemoval_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(1, 0);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(785, 64);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(199, 9);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(61, 19);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "Part 1:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(648, 38);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(51, 19);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "Part 2:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(198, 37);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(64, 19);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "Part 3:";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEmbossing
            // 
            this.btnEmbossing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEmbossing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmbossing.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbossing.Location = new System.Drawing.Point(569, 33);
            this.btnEmbossing.Name = "btnEmbossing";
            this.btnEmbossing.Size = new System.Drawing.Size(78, 25);
            this.btnEmbossing.TabIndex = 23;
            this.btnEmbossing.Text = "EMBOSSING";
            this.btnEmbossing.UseVisualStyleBackColor = false;
            this.btnEmbossing.Click += new System.EventHandler(this.btnEmbossing_Click);
            // 
            // btnSmoothing
            // 
            this.btnSmoothing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSmoothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmoothing.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmoothing.Location = new System.Drawing.Point(253, 33);
            this.btnSmoothing.Name = "btnSmoothing";
            this.btnSmoothing.Size = new System.Drawing.Size(68, 25);
            this.btnSmoothing.TabIndex = 24;
            this.btnSmoothing.Text = "SMOOTH";
            this.btnSmoothing.UseVisualStyleBackColor = false;
            this.btnSmoothing.Click += new System.EventHandler(this.btnSmoothing_Click);
            // 
            // btnCoinCounter
            // 
            this.btnCoinCounter.BackColor = System.Drawing.Color.Salmon;
            this.btnCoinCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoinCounter.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinCounter.Location = new System.Drawing.Point(668, 5);
            this.btnCoinCounter.Name = "btnCoinCounter";
            this.btnCoinCounter.Size = new System.Drawing.Size(102, 23);
            this.btnCoinCounter.TabIndex = 25;
            this.btnCoinCounter.Text = "COIN COUNTER";
            this.btnCoinCounter.UseVisualStyleBackColor = false;
            this.btnCoinCounter.Click += new System.EventHandler(this.btnCoinCounter_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(575, 9);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(97, 19);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "New Feature!";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::digital_image_processing.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnCoinCounter);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnSmoothing);
            this.Controls.Add(this.btnEmbossing);
            this.Controls.Add(this.btnGaussian);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnMeanRemoval);
            this.Controls.Add(this.btnSharpen);
            this.Controls.Add(this.btnTurnOff);
            this.Controls.Add(this.btnTurnOn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnColorInvention);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picResultBox);
            this.Controls.Add(this.picOriginalBox);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doraemon\'s Image Editor!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginalBox;
        private System.Windows.Forms.PictureBox picResultBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnColorInvention;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTurnOn;
        private System.Windows.Forms.Button btnTurnOff;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnGaussian;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button btnMeanRemoval;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnEmbossing;
        private System.Windows.Forms.Button btnSmoothing;
        private System.Windows.Forms.Button btnCoinCounter;
        private System.Windows.Forms.TextBox textBox8;
    }
}

