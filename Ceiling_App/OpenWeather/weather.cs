using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;

namespace Ceiling_App.OpenWeather
{
    public class Weather
    {
        [JsonProperty("id")]
        public int Id;

        [JsonProperty("main")]
        public string Main;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("icon")]
        public string Icon;

        public Bitmap _Icon
        {
            get 
            {
                return new Bitmap(Image.FromFile($"ICONS/{Icon}.png"));
            }

        }
    }
}
