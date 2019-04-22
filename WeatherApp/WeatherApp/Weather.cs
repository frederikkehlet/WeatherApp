using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WeatherApp
{
    public static class Weather
    {
        public static string Description { get; set; }
        public static string Temperature { get; set; }
        public static string ImageID { get; set; }

        public static void GetWeather(string lat, string lon)
        {
            string uri = "http://api.openweathermap.org/data/2.5/weather";
            string key = "e1f9755fae1abe44751a478624f20cb4";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );

                HttpResponseMessage response = client.GetAsync("?lat=" + lat + "&lon=" + lon + "&APPID=" + key).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    dynamic json = JsonConvert.DeserializeObject(data);
                    Description = json.weather[0].description;
                    Temperature = Convert.ToString((double)json.main.temp - 273.15);
                    ImageID = json.weather[0].icon;
                }
                else
                {
                    throw new NoWeatherDataFoundException("No weather data was found");
                }
            }
        }
    }
}
