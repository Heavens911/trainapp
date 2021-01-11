using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ceiling_App.OpenWeather
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed;

        [JsonProperty("deg")]
        public double Degree;

        [JsonProperty("gust")]
        public double Gust;
    }
}
