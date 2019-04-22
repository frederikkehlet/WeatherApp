using System;
using System.Runtime.Serialization;

namespace WeatherApp
{
    [Serializable]
    internal class NoWeatherDataFoundException : Exception
    {
        public NoWeatherDataFoundException()
        {
        }

        public NoWeatherDataFoundException(string message) : base(message)
        {
        }

        public NoWeatherDataFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoWeatherDataFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}