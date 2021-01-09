using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Ceiling_App.OpenWeather
{
    class weather
    {
        public int id;
        
        public string main;
        
        public string description;

        public string icon;

        public Bitmap Icon
        {
            get 
            {
                return new Bitmap(Image.FromFile($"ICONS/{icon}.png"));
            }

        }
    }
}
