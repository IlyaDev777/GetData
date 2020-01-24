using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCon
{
    class WeatherResponse
    {
        //comment
        public TemperatureInfo Main { get; set; }
        public TemperatureInfo[] Weather { get; set; }

        public string Base { get; set; }

    }
}
