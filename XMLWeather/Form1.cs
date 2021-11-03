using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();

        string url;
        string city = "Stratford";
        string country = "CA";

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            //open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + "," + country + "&mode=xml&units=metric&cnt=7&appid=f27cf44af098706a7dfe0801cf6a87ec");

            while (reader.Read())
            {
                //create a day object
                Day day = new Day();
                //fill day object with required data
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                reader.ReadToFollowing("temperature");
                day.tempLow = reader.GetAttribute("min");
                day.tempHigh = reader.GetAttribute("max");
                day.unit = reader.GetAttribute("unit");


                //TODO: if day object not null add to the days list
                days.Add(day);
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + city + "," + country + "&mode=xml&units=metric&appid=f27cf44af098706a7dfe0801cf6a87ec");

            //find the city and country and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("country");
            days[0].country = reader.ReadString();

            //find the current temperatures and add to appropriate item in days list
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Math.Round(Convert.ToDouble(reader.GetAttribute("value"))).ToString();
            days[0].tempLow = Math.Round(Convert.ToDouble(reader.GetAttribute("min"))).ToString();
            days[0].tempHigh = Math.Round(Convert.ToDouble(reader.GetAttribute("max"))).ToString();

            //find weather code and condition
            reader.ReadToFollowing("weather");
            days[0].weatherCode = reader.GetAttribute("number");
            days[0].condition = reader.GetAttribute("value");

            //get last update time
            reader.ReadToFollowing("lastupdate");
            days[0].lastUpdate = reader.GetAttribute("value");
        }


    }
}
