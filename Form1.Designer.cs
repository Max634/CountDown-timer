namespace CountDown_Timer
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
            this.components = new System.ComponentModel.Container();
            this.days = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.BackColor = System.Drawing.Color.Navy;
            this.days.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.ForeColor = System.Drawing.Color.White;
            this.days.Location = new System.Drawing.Point(217, 237);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(102, 75);
            this.days.TabIndex = 1;
            this.days.Text = "00";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.BackColor = System.Drawing.Color.Navy;
            this.hours.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.ForeColor = System.Drawing.Color.White;
            this.hours.Location = new System.Drawing.Point(368, 237);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(102, 75);
            this.hours.TabIndex = 2;
            this.hours.Text = "00";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.BackColor = System.Drawing.Color.Navy;
            this.minutes.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.ForeColor = System.Drawing.Color.White;
            this.minutes.Location = new System.Drawing.Point(546, 237);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(102, 75);
            this.minutes.TabIndex = 3;
            this.minutes.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(313, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 75);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(491, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 75);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(224, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 43);
            this.label9.TabIndex = 8;
            this.label9.Text = "Days";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(370, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 43);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hours";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(540, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 43);
            this.label11.TabIndex = 10;
            this.label11.Text = "Minutes";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(672, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 75);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.BackColor = System.Drawing.Color.Navy;
            this.seconds.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.White;
            this.seconds.Location = new System.Drawing.Point(727, 237);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(102, 75);
            this.seconds.TabIndex = 13;
            this.seconds.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(732, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 57);
            this.label2.TabIndex = 15;
            this.label2.Text = "CountDown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CountDown_Timer.Properties.Resources._336_3364653_x_button_exit_icon_symbol_sign_cross_botao;
            this.pictureBox1.Location = new System.Drawing.Point(925, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.days);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

