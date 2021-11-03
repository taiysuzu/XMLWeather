namespace XMLWeather
{
    partial class CurrentScreen
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
            this.components = new System.ComponentModel.Container();
            this.cityOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.designLabel1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.timeOutput = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.countryInput = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.mainWeatherIcon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Futurama Bold Font", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.cityOutput.Location = new System.Drawing.Point(5, 142);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(242, 40);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // minLabel
            // 
            this.minLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.minLabel.Location = new System.Drawing.Point(54, 255);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(82, 26);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Low of:";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.Font = new System.Drawing.Font("Futurama Bold Font", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.tempLabel.Location = new System.Drawing.Point(3, 63);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(157, 53);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Futurama Bold Font", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(14, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.AutoSize = true;
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Futurama Bold Font", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.forecastLabel.Location = new System.Drawing.Point(130, 350);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(104, 33);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(10, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // designLabel1
            // 
            this.designLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.designLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.designLabel1.Location = new System.Drawing.Point(0, 149);
            this.designLabel1.Name = "designLabel1";
            this.designLabel1.Size = new System.Drawing.Size(250, 45);
            this.designLabel1.TabIndex = 43;
            this.designLabel1.Text = "____________________________";
            this.designLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(57, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "____________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.maxLabel.Location = new System.Drawing.Point(58, 233);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(79, 20);
            this.maxLabel.TabIndex = 47;
            this.maxLabel.Text = "High of:";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxOutput
            // 
            this.maxOutput.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.maxOutput.Location = new System.Drawing.Point(130, 233);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(70, 18);
            this.maxOutput.TabIndex = 48;
            this.maxOutput.Text = "temp";
            // 
            // minOutput
            // 
            this.minOutput.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.minOutput.Location = new System.Drawing.Point(130, 255);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(70, 18);
            this.minOutput.TabIndex = 49;
            this.minOutput.Text = "temp";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(0, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 45);
            this.label2.TabIndex = 50;
            this.label2.Text = "____________________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Futurama Bold Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.dateOutput.Location = new System.Drawing.Point(136, 190);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(104, 27);
            this.dateOutput.TabIndex = 45;
            this.dateOutput.Text = "Date";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeOutput
            // 
            this.timeOutput.BackColor = System.Drawing.Color.Transparent;
            this.timeOutput.Font = new System.Drawing.Font("Futurama Bold Font", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.timeOutput.Location = new System.Drawing.Point(7, 190);
            this.timeOutput.Name = "timeOutput";
            this.timeOutput.Size = new System.Drawing.Size(153, 27);
            this.timeOutput.TabIndex = 51;
            this.timeOutput.Text = "Time";
            this.timeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(147, 3);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(100, 20);
            this.cityInput.TabIndex = 52;
            // 
            // countryInput
            // 
            this.countryInput.Location = new System.Drawing.Point(147, 29);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(100, 20);
            this.countryInput.TabIndex = 53;
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Futurama Title Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(99, 4);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(47, 20);
            this.cityLabel.TabIndex = 54;
            this.cityLabel.Text = "City";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // countryLabel
            // 
            this.countryLabel.Font = new System.Drawing.Font("Futurama Title Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(71, 29);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(75, 20);
            this.countryLabel.TabIndex = 55;
            this.countryLabel.Text = "Country:";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Futurama Title Font", 12F);
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(137)))), ((int)(((byte)(191)))));
            this.searchLabel.Location = new System.Drawing.Point(3, 4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(90, 37);
            this.searchLabel.TabIndex = 56;
            this.searchLabel.Text = "Click to Search";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // mainWeatherIcon
            // 
            this.mainWeatherIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainWeatherIcon.Location = new System.Drawing.Point(160, 59);
            this.mainWeatherIcon.Name = "mainWeatherIcon";
            this.mainWeatherIcon.Size = new System.Drawing.Size(80, 80);
            this.mainWeatherIcon.TabIndex = 44;
            this.mainWeatherIcon.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(27, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 57;
            this.label4.Text = "Humidity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // humidityOutput
            // 
            this.humidityOutput.Font = new System.Drawing.Font("Futurama Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(169)))), ((int)(((byte)(153)))));
            this.humidityOutput.Location = new System.Drawing.Point(131, 281);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(87, 18);
            this.humidityOutput.TabIndex = 58;
            this.humidityOutput.Text = "humidity";
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Futurama Bold Font", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(0, 299);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(250, 51);
            this.errorLabel.TabIndex = 59;
            this.errorLabel.Text = "CITY NOT FOUND";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(228)))), ((int)(((byte)(118)))));
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryInput);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.timeOutput);
            this.Controls.Add(this.mainWeatherIcon);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.designLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.mainWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label designLabel1;
        private System.Windows.Forms.PictureBox mainWeatherIcon;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label timeOutput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.TextBox countryInput;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label errorLabel;
    }
}
