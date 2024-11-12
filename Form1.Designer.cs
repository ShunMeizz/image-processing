namespace digital_image_processing
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
            ((System.ComponentModel.ISupportInitialize)(this.picOriginalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginalBox
            // 
            this.picOriginalBox.Location = new System.Drawing.Point(122, 91);
            this.picOriginalBox.Name = "picOriginalBox";
            this.picOriginalBox.Size = new System.Drawing.Size(240, 240);
            this.picOriginalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginalBox.TabIndex = 0;
            this.picOriginalBox.TabStop = false;
            // 
            // picResultBox
            // 
            this.picResultBox.Location = new System.Drawing.Point(428, 91);
            this.picResultBox.Name = "picResultBox";
            this.picResultBox.Size = new System.Drawing.Size(240, 240);
            this.picResultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResultBox.TabIndex = 1;
            this.picResultBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(126, 16);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Original Picture";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(496, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(112, 16);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Result Picture";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpen.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(172, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(130, 30);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "LOAD IMAGE";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.Control;
            this.btnCopy.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(400, 8);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(72, 30);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.SystemColors.Control;
            this.btnGray.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGray.Location = new System.Drawing.Point(476, 8);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(70, 30);
            this.btnGray.TabIndex = 6;
            this.btnGray.Text = "GRAY";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnColorInvention
            // 
            this.btnColorInvention.BackColor = System.Drawing.SystemColors.Control;
            this.btnColorInvention.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorInvention.Location = new System.Drawing.Point(550, 8);
            this.btnColorInvention.Name = "btnColorInvention";
            this.btnColorInvention.Size = new System.Drawing.Size(141, 30);
            this.btnColorInvention.TabIndex = 7;
            this.btnColorInvention.Text = "COLOR INVENTION";
            this.btnColorInvention.UseVisualStyleBackColor = false;
            this.btnColorInvention.Click += new System.EventHandler(this.btnColorInversion_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistogram.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistogram.Location = new System.Drawing.Point(410, 41);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(101, 30);
            this.btnHistogram.TabIndex = 8;
            this.btnHistogram.Text = "HISTOGRAM";
            this.btnHistogram.UseVisualStyleBackColor = false;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.BackColor = System.Drawing.SystemColors.Control;
            this.btnSepia.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSepia.Location = new System.Drawing.Point(515, 41);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(65, 30);
            this.btnSepia.TabIndex = 9;
            this.btnSepia.Text = "SEPIA";
            this.btnSepia.UseVisualStyleBackColor = false;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubtract.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(584, 41);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(99, 30);
            this.btnSubtract.TabIndex = 10;
            this.btnSubtract.Text = "SUBTRACT";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(697, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTurnOn
            // 
            this.btnTurnOn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTurnOn.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOn.Location = new System.Drawing.Point(12, 178);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Size = new System.Drawing.Size(81, 28);
            this.btnTurnOn.TabIndex = 12;
            this.btnTurnOn.Text = "TURN ON";
            this.btnTurnOn.UseVisualStyleBackColor = false;
            this.btnTurnOn.Click += new System.EventHandler(this.btnTurnOn_Click);
            // 
            // btnTurnOff
            // 
            this.btnTurnOff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTurnOff.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnOff.Location = new System.Drawing.Point(12, 212);
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.Size = new System.Drawing.Size(81, 28);
            this.btnTurnOff.TabIndex = 13;
            this.btnTurnOff.Text = "TURN OFF";
            this.btnTurnOff.UseVisualStyleBackColor = false;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(7, 142);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(93, 32);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "Try it with your WEBCAM";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::digital_image_processing.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnTurnOff);
            this.Controls.Add(this.btnTurnOn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnColorInvention);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picResultBox);
            this.Controls.Add(this.picOriginalBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEBIAL CS345F2 - Image Processing ";
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
    }
}

