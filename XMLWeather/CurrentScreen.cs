using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        int counter = 0;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location + ", " + Form1.days[0].country;
            tempLabel.Text = $"{Form1.days[0].currentTemp}° C";
            minOutput.Text = $"{Form1.days[0].tempLow}° C";
            maxOutput.Text = $"{Form1.days[0].tempHigh}° C";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;

            dateOutput.Text = DateTime.Now.ToString("hh:mm:ss");
            dateOutput.Text += "|" + DateTime.Now.ToString("dd-MM-yy");

            if (counter == 100)
            {
                DisplayCurrent();
                counter = 0;
            }
        }

    }
}
