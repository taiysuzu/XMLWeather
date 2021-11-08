using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        //textinfo for foramtting strings
        TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

        List<PictureBox> weatherIcons = new List<PictureBox>(6);
        List<Label> dateOutputs = new List<Label>(6);
        List<Label> maxOutputs = new List<Label>(6);
        List<Label> minOutputs = new List<Label>(6);
        List<Label> conditionOutputs = new List<Label>(6);

        public ForecastScreen()
        {
            InitializeComponent();
            fillLists();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
            displayForecast();
        }

        public void displayForecast()
        {   //display 5 day forecast
            for (int i = 1; i < 6; i++)
            {
                dateOutputs[i].Text = $"{DateTime.Now.AddDays(i).DayOfWeek.ToString()}, {DateTime.Now.ToString("dd-MM-yy")}";
                maxOutputs[i].Text = $"{Form1.days[i].tempHigh}° C";
                minOutputs[i].Text = $"{Form1.days[i].tempLow}° C";
                conditionOutputs[i].Text = $"{myTI.ToTitleCase(Form1.days[i].condition)}";
                //grab current weather code
                int weatherCode = Convert.ToInt32(Form1.days[i].weatherCode);

                //pick correct weather icon based on weather code
                if (weatherCode == 800)
                {
                    weatherIcons[i].BackgroundImage = Properties.Resources.sun;
                }
                else if (weatherCode >= 801 && weatherCode <= 804)
                {
                    weatherIcons[i].BackgroundImage = Properties.Resources.cloud;
                }
                else if (weatherCode >= 300 && weatherCode <= 531)
                {
                    weatherIcons[i].BackgroundImage = Properties.Resources.rain;
                }
                else if (weatherCode >= 200 && weatherCode <= 232)
                {
                    weatherIcons[i].BackgroundImage = Properties.Resources.storm;
                }
                else if (weatherCode >= 600 && weatherCode <= 622)
                {
                    weatherIcons[i].BackgroundImage = Properties.Resources.snow;
                }
            }
        }

        private void currentLabel_Click(object sender, EventArgs e)
        {//change screens
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
        private void fillLists()
        {//i know this is inefficient but on time constraints
            weatherIcons.Add(weatherIcon1); //added twice to fill first slot because numbers must be 1-5 
            weatherIcons.Add(weatherIcon1);
            weatherIcons.Add(weatherIcon2);
            weatherIcons.Add(weatherIcon3);
            weatherIcons.Add(weatherIcon4);
            weatherIcons.Add(weatherIcon5);

            dateOutputs.Add(dateOutput1);
            dateOutputs.Add(dateOutput1);
            dateOutputs.Add(dateOutput2);
            dateOutputs.Add(dateOutput3);
            dateOutputs.Add(dateOutput4);
            dateOutputs.Add(dateOutput5);

            maxOutputs.Add(maxOutput1);
            maxOutputs.Add(maxOutput1);
            maxOutputs.Add(maxOutput2);
            maxOutputs.Add(maxOutput3);
            maxOutputs.Add(maxOutput4);
            maxOutputs.Add(maxOutput5);

            minOutputs.Add(minOutput1);
            minOutputs.Add(minOutput1);
            minOutputs.Add(minOutput2);
            minOutputs.Add(minOutput3);
            minOutputs.Add(minOutput4);
            minOutputs.Add(minOutput5);

            conditionOutputs.Add(conditionOutput1);
            conditionOutputs.Add(conditionOutput1);
            conditionOutputs.Add(conditionOutput2);
            conditionOutputs.Add(conditionOutput3);
            conditionOutputs.Add(conditionOutput4);
            conditionOutputs.Add(conditionOutput5);
        }
    }
}
