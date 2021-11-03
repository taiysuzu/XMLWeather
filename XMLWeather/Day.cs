﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, unit,
            windSpeed, windDirection, precipitation, visibility, weatherCode, lastUpdate, country, humidity;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = unit = windSpeed = windDirection = precipitation = visibility = weatherCode 
                = lastUpdate = country = humidity = "";
        }
    }
}
