using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Ceiling_App.OpenWeather
{
    class OpenWeather
    {
        public Coord coord;

        public weather[] weather;

       // [JsonProperty("base")]

        public string Base;

        public main main;

        public double visibility;

        public wind wind;
        public Clouds clouds;

        public double dt;

        public sys sys;

        public int id;
        public string name;
        public double cod;
       

    }
}
