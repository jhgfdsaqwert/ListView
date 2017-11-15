using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App11
{
    class CityClass
    {
        private string cityName;
        private int cityImage;
        public CityClass(string cityName, int cityImage)
        {
            this.cityName = cityName;
            this.cityImage = cityImage;
        }
        public string GetCityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        public int GetGityImage
        {
            get { return cityImage; }
            set { cityImage = value; }
        }
    }
}