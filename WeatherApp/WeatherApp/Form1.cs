using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            locationLabel.Text = "";
            temperatureLabel.Text = "";
            descriptionLabel.Text = "";
            statusLabel.Text = "";
        }

        private void GetWeatherButton_Click(object sender, EventArgs e)
        {
            try
            {
                statusLabel.Text = "Fetching weather data...";

                var location = new GeoLocation();
                Weather.GetWeather(location.Latitude, location.Longitude);

                statusLabel.Text = "";
                locationLabel.Text += "Today's weather in " + location.City + ":";
                temperatureLabel.Text += Weather.Temperature + " °C";
                descriptionLabel.Text += CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Weather.Description);
                weatherImage.Load("https://openweathermap.org/img/w/" + Weather.ImageID + ".png");
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
            
        }
    }
}
