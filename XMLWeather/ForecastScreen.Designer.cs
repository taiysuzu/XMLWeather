namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.minOutput1 = new System.Windows.Forms.Label();
            this.conditionOutput1 = new System.Windows.Forms.Label();
            this.maxOutput1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateOutput1 = new System.Windows.Forms.Label();
            this.weatherIcon1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.weatherIcon2 = new System.Windows.Forms.PictureBox();
            this.dateOutput2 = new System.Windows.Forms.Label();
            this.minOutput2 = new System.Windows.Forms.Label();
            this.conditionOutput2 = new System.Windows.Forms.Label();
            this.maxOutput2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.weatherIcon3 = new System.Windows.Forms.PictureBox();
            this.dateOutput3 = new System.Windows.Forms.Label();
            this.minOutput3 = new System.Windows.Forms.Label();
            this.conditionOutput3 = new System.Windows.Forms.Label();
            this.maxOutput3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.weatherIcon4 = new System.Windows.Forms.PictureBox();
            this.dateOutput4 = new System.Windows.Forms.Label();
            this.minOutput4 = new System.Windows.Forms.Label();
            this.conditionOutput4 = new System.Windows.Forms.Label();
            this.maxOutput4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.weatherIcon5 = new System.Windows.Forms.PictureBox();
            this.dateOutput5 = new System.Windows.Forms.Label();
            this.minOutput5 = new System.Windows.Forms.Label();
            this.conditionOutput5 = new System.Windows.Forms.Label();
            this.maxOutput5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon5)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.AutoSize = true;
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Futurama Bold Font", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.forecastLabel.Location = new System.Drawing.Point(130, 350);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(103, 33);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "5 Day";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Futurama Bold Font", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.currentLabel.Location = new System.Drawing.Point(14, 350);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(111, 33);
            this.currentLabel.TabIndex = 61;
            this.currentLabel.Text = "Today";
            this.currentLabel.Click += new System.EventHandler(this.currentLabel_Click);
            // 
            // minOutput1
            // 
            this.minOutput1.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.minOutput1.Location = new System.Drawing.Point(189, 37);
            this.minOutput1.Name = "minOutput1";
            this.minOutput1.Size = new System.Drawing.Size(57, 14);
            this.minOutput1.TabIndex = 46;
            this.minOutput1.Text = "Min Temperature";
            // 
            // conditionOutput1
            // 
            this.conditionOutput1.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput1.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.conditionOutput1.Location = new System.Drawing.Point(5, 54);
            this.conditionOutput1.Name = "conditionOutput1";
            this.conditionOutput1.Size = new System.Drawing.Size(139, 23);
            this.conditionOutput1.TabIndex = 45;
            this.conditionOutput1.Text = "condition";
            this.conditionOutput1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // maxOutput1
            // 
            this.maxOutput1.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.maxOutput1.Location = new System.Drawing.Point(138, 37);
            this.maxOutput1.Name = "maxOutput1";
            this.maxOutput1.Size = new System.Drawing.Size(58, 14);
            this.maxOutput1.TabIndex = 44;
            this.maxOutput1.Text = "Max Temperature";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(120, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutput1
            // 
            this.dateOutput1.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.dateOutput1.Location = new System.Drawing.Point(5, 37);
            this.dateOutput1.Name = "dateOutput1";
            this.dateOutput1.Size = new System.Drawing.Size(122, 27);
            this.dateOutput1.TabIndex = 64;
            this.dateOutput1.Text = "Date";
            // 
            // weatherIcon1
            // 
            this.weatherIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weatherIcon1.Location = new System.Drawing.Point(165, 54);
            this.weatherIcon1.Name = "weatherIcon1";
            this.weatherIcon1.Size = new System.Drawing.Size(31, 30);
            this.weatherIcon1.TabIndex = 0;
            this.weatherIcon1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.label7.Location = new System.Drawing.Point(3, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 27);
            this.label7.TabIndex = 70;
            this.label7.Text = "____________________________";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIcon2
            // 
            this.weatherIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weatherIcon2.Location = new System.Drawing.Point(165, 113);
            this.weatherIcon2.Name = "weatherIcon2";
            this.weatherIcon2.Size = new System.Drawing.Size(31, 30);
            this.weatherIcon2.TabIndex = 71;
            this.weatherIcon2.TabStop = false;
            // 
            // dateOutput2
            // 
            this.dateOutput2.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.dateOutput2.Location = new System.Drawing.Point(5, 96);
            this.dateOutput2.Name = "dateOutput2";
            this.dateOutput2.Size = new System.Drawing.Size(122, 27);
            this.dateOutput2.TabIndex = 75;
            this.dateOutput2.Text = "Date";
            // 
            // minOutput2
            // 
            this.minOutput2.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.minOutput2.Location = new System.Drawing.Point(189, 96);
            this.minOutput2.Name = "minOutput2";
            this.minOutput2.Size = new System.Drawing.Size(57, 14);
            this.minOutput2.TabIndex = 74;
            this.minOutput2.Text = "Min Temperature";
            // 
            // conditionOutput2
            // 
            this.conditionOutput2.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput2.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.conditionOutput2.Location = new System.Drawing.Point(5, 113);
            this.conditionOutput2.Name = "conditionOutput2";
            this.conditionOutput2.Size = new System.Drawing.Size(139, 23);
            this.conditionOutput2.TabIndex = 73;
            this.conditionOutput2.Text = "condition";
            this.conditionOutput2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // maxOutput2
            // 
            this.maxOutput2.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.maxOutput2.Location = new System.Drawing.Point(138, 96);
            this.maxOutput2.Name = "maxOutput2";
            this.maxOutput2.Size = new System.Drawing.Size(55, 14);
            this.maxOutput2.TabIndex = 72;
            this.maxOutput2.Text = "Max Temperature";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.label12.Location = new System.Drawing.Point(3, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 27);
            this.label12.TabIndex = 76;
            this.label12.Text = "____________________________";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIcon3
            // 
            this.weatherIcon3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weatherIcon3.Location = new System.Drawing.Point(165, 172);
            this.weatherIcon3.Name = "weatherIcon3";
            this.weatherIcon3.Size = new System.Drawing.Size(31, 30);
            this.weatherIcon3.TabIndex = 77;
            this.weatherIcon3.TabStop = false;
            // 
            // dateOutput3
            // 
            this.dateOutput3.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.dateOutput3.Location = new System.Drawing.Point(8, 155);
            this.dateOutput3.Name = "dateOutput3";
            this.dateOutput3.Size = new System.Drawing.Size(119, 27);
            this.dateOutput3.TabIndex = 81;
            this.dateOutput3.Text = "Date";
            // 
            // minOutput3
            // 
            this.minOutput3.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.minOutput3.Location = new System.Drawing.Point(186, 155);
            this.minOutput3.Name = "minOutput3";
            this.minOutput3.Size = new System.Drawing.Size(60, 14);
            this.minOutput3.TabIndex = 80;
            this.minOutput3.Text = "Min Temperature";
            // 
            // conditionOutput3
            // 
            this.conditionOutput3.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput3.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.conditionOutput3.Location = new System.Drawing.Point(5, 172);
            this.conditionOutput3.Name = "conditionOutput3";
            this.conditionOutput3.Size = new System.Drawing.Size(139, 23);
            this.conditionOutput3.TabIndex = 79;
            this.conditionOutput3.Text = "condition";
            this.conditionOutput3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // maxOutput3
            // 
            this.maxOutput3.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.maxOutput3.Location = new System.Drawing.Point(138, 155);
            this.maxOutput3.Name = "maxOutput3";
            this.maxOutput3.Size = new System.Drawing.Size(52, 14);
            this.maxOutput3.TabIndex = 78;
            this.maxOutput3.Text = "Max Temperature";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.label13.Location = new System.Drawing.Point(3, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(247, 27);
            this.label13.TabIndex = 82;
            this.label13.Text = "____________________________";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIcon4
            // 
            this.weatherIcon4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weatherIcon4.Location = new System.Drawing.Point(165, 231);
            this.weatherIcon4.Name = "weatherIcon4";
            this.weatherIcon4.Size = new System.Drawing.Size(31, 30);
            this.weatherIcon4.TabIndex = 83;
            this.weatherIcon4.TabStop = false;
            // 
            // dateOutput4
            // 
            this.dateOutput4.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.dateOutput4.Location = new System.Drawing.Point(5, 214);
            this.dateOutput4.Name = "dateOutput4";
            this.dateOutput4.Size = new System.Drawing.Size(122, 27);
            this.dateOutput4.TabIndex = 87;
            this.dateOutput4.Text = "Date";
            // 
            // minOutput4
            // 
            this.minOutput4.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.minOutput4.Location = new System.Drawing.Point(186, 214);
            this.minOutput4.Name = "minOutput4";
            this.minOutput4.Size = new System.Drawing.Size(60, 14);
            this.minOutput4.TabIndex = 86;
            this.minOutput4.Text = "Min Temperature";
            // 
            // conditionOutput4
            // 
            this.conditionOutput4.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput4.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.conditionOutput4.Location = new System.Drawing.Point(5, 231);
            this.conditionOutput4.Name = "conditionOutput4";
            this.conditionOutput4.Size = new System.Drawing.Size(139, 23);
            this.conditionOutput4.TabIndex = 85;
            this.conditionOutput4.Text = "condition";
            this.conditionOutput4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // maxOutput4
            // 
            this.maxOutput4.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.maxOutput4.Location = new System.Drawing.Point(138, 214);
            this.maxOutput4.Name = "maxOutput4";
            this.maxOutput4.Size = new System.Drawing.Size(55, 14);
            this.maxOutput4.TabIndex = 84;
            this.maxOutput4.Text = "Max Temperature";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.label18.Location = new System.Drawing.Point(3, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(247, 27);
            this.label18.TabIndex = 88;
            this.label18.Text = "____________________________";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherIcon5
            // 
            this.weatherIcon5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.weatherIcon5.Location = new System.Drawing.Point(165, 290);
            this.weatherIcon5.Name = "weatherIcon5";
            this.weatherIcon5.Size = new System.Drawing.Size(31, 30);
            this.weatherIcon5.TabIndex = 89;
            this.weatherIcon5.TabStop = false;
            // 
            // dateOutput5
            // 
            this.dateOutput5.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.dateOutput5.Location = new System.Drawing.Point(5, 273);
            this.dateOutput5.Name = "dateOutput5";
            this.dateOutput5.Size = new System.Drawing.Size(122, 28);
            this.dateOutput5.TabIndex = 93;
            this.dateOutput5.Text = "Date";
            // 
            // minOutput5
            // 
            this.minOutput5.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.minOutput5.Location = new System.Drawing.Point(186, 273);
            this.minOutput5.Name = "minOutput5";
            this.minOutput5.Size = new System.Drawing.Size(60, 14);
            this.minOutput5.TabIndex = 92;
            this.minOutput5.Text = "Min Temperature";
            // 
            // conditionOutput5
            // 
            this.conditionOutput5.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput5.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionOutput5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.conditionOutput5.Location = new System.Drawing.Point(5, 290);
            this.conditionOutput5.Name = "conditionOutput5";
            this.conditionOutput5.Size = new System.Drawing.Size(139, 23);
            this.conditionOutput5.TabIndex = 91;
            this.conditionOutput5.Text = "condition";
            this.conditionOutput5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // maxOutput5
            // 
            this.maxOutput5.Font = new System.Drawing.Font("Futurama Bold Font", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.maxOutput5.Location = new System.Drawing.Point(138, 276);
            this.maxOutput5.Name = "maxOutput5";
            this.maxOutput5.Size = new System.Drawing.Size(52, 14);
            this.maxOutput5.TabIndex = 90;
            this.maxOutput5.Text = "Max Temperature";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.Controls.Add(this.minOutput1);
            this.Controls.Add(this.maxOutput1);
            this.Controls.Add(this.weatherIcon5);
            this.Controls.Add(this.dateOutput5);
            this.Controls.Add(this.minOutput5);
            this.Controls.Add(this.conditionOutput5);
            this.Controls.Add(this.maxOutput5);
            this.Controls.Add(this.weatherIcon4);
            this.Controls.Add(this.dateOutput4);
            this.Controls.Add(this.minOutput4);
            this.Controls.Add(this.conditionOutput4);
            this.Controls.Add(this.maxOutput4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.weatherIcon3);
            this.Controls.Add(this.dateOutput3);
            this.Controls.Add(this.minOutput3);
            this.Controls.Add(this.conditionOutput3);
            this.Controls.Add(this.maxOutput3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.weatherIcon2);
            this.Controls.Add(this.dateOutput2);
            this.Controls.Add(this.minOutput2);
            this.Controls.Add(this.conditionOutput2);
            this.Controls.Add(this.maxOutput2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.weatherIcon1);
            this.Controls.Add(this.dateOutput1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.conditionOutput1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label minOutput1;
        private System.Windows.Forms.Label conditionOutput1;
        private System.Windows.Forms.Label maxOutput1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dateOutput1;
        private System.Windows.Forms.PictureBox weatherIcon1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox weatherIcon2;
        private System.Windows.Forms.Label dateOutput2;
        private System.Windows.Forms.Label minOutput2;
        private System.Windows.Forms.Label conditionOutput2;
        private System.Windows.Forms.Label maxOutput2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox weatherIcon3;
        private System.Windows.Forms.Label dateOutput3;
        private System.Windows.Forms.Label minOutput3;
        private System.Windows.Forms.Label conditionOutput3;
        private System.Windows.Forms.Label maxOutput3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox weatherIcon4;
        private System.Windows.Forms.Label dateOutput4;
        private System.Windows.Forms.Label minOutput4;
        private System.Windows.Forms.Label conditionOutput4;
        private System.Windows.Forms.Label maxOutput4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox weatherIcon5;
        private System.Windows.Forms.Label dateOutput5;
        private System.Windows.Forms.Label minOutput5;
        private System.Windows.Forms.Label conditionOutput5;
        private System.Windows.Forms.Label maxOutput5;
    }
}
