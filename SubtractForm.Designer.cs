namespace digital_image_processing
{
    partial class SubtractForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.imageBBox = new System.Windows.Forms.PictureBox();
            this.imageABox = new System.Windows.Forms.PictureBox();
            this.imageResultBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnLoadImageB = new System.Windows.Forms.Button();
            this.btnLoadImageA = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageABox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageResultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 25);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imageBBox
            // 
            this.imageBBox.Location = new System.Drawing.Point(69, 132);
            this.imageBBox.Name = "imageBBox";
            this.imageBBox.Size = new System.Drawing.Size(165, 165);
            this.imageBBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBBox.TabIndex = 13;
            this.imageBBox.TabStop = false;
            // 
            // imageABox
            // 
            this.imageABox.Location = new System.Drawing.Point(277, 132);
            this.imageABox.Name = "imageABox";
            this.imageABox.Size = new System.Drawing.Size(165, 165);
            this.imageABox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageABox.TabIndex = 14;
            this.imageABox.TabStop = false;
            // 
            // imageResultBox
            // 
            this.imageResultBox.Location = new System.Drawing.Point(517, 114);
            this.imageResultBox.Name = "imageResultBox";
            this.imageResultBox.Size = new System.Drawing.Size(215, 215);
            this.imageResultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageResultBox.TabIndex = 15;
            this.imageResultBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Moonbeam", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(566, 366);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 16);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "RESULT PHOTO";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox2.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(318, 325);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(89, 14);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "BACKGROUND";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox3.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(107, 325);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 14);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "IMAGE";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(517, 68);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(106, 25);
            this.btnSubtract.TabIndex = 19;
            this.btnSubtract.Text = "DO SUBTRACTION";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnLoadImageB
            // 
            this.btnLoadImageB.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLoadImageB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadImageB.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImageB.Location = new System.Drawing.Point(106, 89);
            this.btnLoadImageB.Name = "btnLoadImageB";
            this.btnLoadImageB.Size = new System.Drawing.Size(91, 25);
            this.btnLoadImageB.TabIndex = 20;
            this.btnLoadImageB.Text = "LOAD IMAGE";
            this.btnLoadImageB.UseVisualStyleBackColor = false;
            this.btnLoadImageB.Click += new System.EventHandler(this.btnLoadImageB_Click);
            // 
            // btnLoadImageA
            // 
            this.btnLoadImageA.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLoadImageA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadImageA.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImageA.Location = new System.Drawing.Point(294, 89);
            this.btnLoadImageA.Name = "btnLoadImageA";
            this.btnLoadImageA.Size = new System.Drawing.Size(135, 25);
            this.btnLoadImageA.TabIndex = 21;
            this.btnLoadImageA.Text = "LOAD BACKGROUND";
            this.btnLoadImageA.UseVisualStyleBackColor = false;
            this.btnLoadImageA.Click += new System.EventHandler(this.btnLoadImageA_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(628, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 25);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Moonbeam", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(-1, 2);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(86, 40);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::digital_image_processing.Properties.Resources.background_2;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoadImageA);
            this.Controls.Add(this.btnLoadImageB);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.imageResultBox);
            this.Controls.Add(this.imageABox);
            this.Controls.Add(this.imageBBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SubtractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doraemon\'s Image Editor!";
            ((System.ComponentModel.ISupportInitialize)(this.imageBBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageABox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageResultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imageBBox;
        private System.Windows.Forms.PictureBox imageABox;
        private System.Windows.Forms.PictureBox imageResultBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnLoadImageB;
        private System.Windows.Forms.Button btnLoadImageA;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox4;
    }
}