using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Ceiling_App.OpenWeather
{
    public class OpenWeather
    {
        public Coord Coord;

        public Weather[] Weather;

        [JsonProperty("Base")]

        public string Base;

        public Main Main;

        public double Visibility;

        public Wind Wind;
        // public Clouds clouds; // удалил за ненужностью

        public double Dt;

        public int Id;
        public string Name;
        public double Cod;
       

    }
}
