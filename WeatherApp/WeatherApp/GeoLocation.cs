using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace WeatherApp
{
    public class GeoLocation
    {
        public string City { get; }
        public string Country { get; }
        public string CountryCode { get; }
        public string Latitude { get; }
        public string Longitude { get; }

        public GeoLocation()
        {
            WebClient client = new WebClient();
            string data = client.DownloadString("http://www.ip-api.com/json/" + GetPublicIP());

            dynamic json = JsonConvert.DeserializeObject(data);
            City = json.city;
            Country = json.country;
            CountryCode = json.countryCode;
            Latitude = json.lat.ToString();
            Longitude = json.lon.ToString();
        }

        private string GetPublicIP()
        {
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org");
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());

            string address = stream.ReadToEnd();

            int first = address.IndexOf("Address: ") + 9;
            int last = address.IndexOf("</body>");

            return address.Substring(first, last - first);
        }
    }
}
