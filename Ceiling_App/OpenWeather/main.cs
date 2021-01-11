using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Ceiling_App.OpenWeather
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature;

        [JsonProperty("pressure")]
        public double Pressure;

        [JsonProperty("humidity")]
        public double Humidity;

        [JsonProperty("temp_min")]
        public double TemperatureMin;

        [JsonProperty("temp_max")]
        public double TemperatureMax;

        [OnDeserialized]
        private void OnDeserializedMethod(StreamingContext context)
        {
            Temperature = ToCelsius(Temperature);
            TemperatureMin = ToCelsius(TemperatureMin);
            TemperatureMax = ToCelsius(TemperatureMax);
            Pressure = ConvertPressure(Pressure);
        }

        [OnSerializing]
        private void OnSerializingMethod(StreamingContext context)
        {
            throw new NotImplementedException();
        }


        private static double ToCelsius(double kelvin) => kelvin - 273.15;

        private static double ConvertPressure(double pressure) => pressure / 1.3332239;
    }
}
