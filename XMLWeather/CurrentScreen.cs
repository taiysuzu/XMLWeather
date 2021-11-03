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

        int weatherCode;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            //display current information
            cityOutput.Text = Form1.days[0].location + ", " + Form1.days[0].country;
            tempLabel.Text = $"{Form1.days[0].currentTemp}° C";
            minOutput.Text = $"{Form1.days[0].tempLow}° C";
            maxOutput.Text = $"{Form1.days[0].tempHigh}° C";
            humidityOutput.Text = $"{Form1.days[0].humidity} %";

            //grab current weather code
            weatherCode = Convert.ToInt32(Form1.days[0].weatherCode);

            //pick correct weather icon based on weather code
            if (weatherCode == 800)
            {
                mainWeatherIcon.BackgroundImage = Properties.Resources.sun;
            }
            else if (weatherCode >= 801 && weatherCode <= 804)
            {
                mainWeatherIcon.BackgroundImage = Properties.Resources.cloud;
            }
            else if (weatherCode >= 300 && weatherCode <= 531)
            {
                mainWeatherIcon.BackgroundImage = Properties.Resources.rain;
            }
            else if (weatherCode >= 200 && weatherCode <= 232)
            {
                mainWeatherIcon.BackgroundImage = Properties.Resources.storm;
            }
            else if (weatherCode >= 600 && weatherCode <= 622)
            {
                mainWeatherIcon.BackgroundImage = Properties.Resources.snow;
            }
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

            //update date and time
            dateOutput.Text = DateTime.Now.ToString("dd-MM-yy");
            timeOutput.Text = DateTime.Now.ToString("hh:mm:ss");

            //every 1000 ticks, update screen
            if (counter == 1000)
            {
                DisplayCurrent();
                counter = 0;
            }
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //search for a city - change form1 variables and call extract
            if (cityInput.Text == "" && countryInput.Text == "")
            {
                Form1.city = "Stratford";//if inputs are left blank, go back to Stratford, CA 
                Form1.country = "CA";
            }
            else
            {
                Form1.city = cityInput.Text;
                Form1.country = countryInput.Text;
            }

            try
            {   //if city is not found (error thrown), catch and return error message
                Form1.ExtractCurrent();
                errorLabel.Visible = false;
            }
            catch
            {
                errorLabel.Visible = true;
            }

            //update screen
            DisplayCurrent();
        }
    }
}
