using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace testCon
{

    class Program
    {
        
        static void Main()
        {
            string temp, feels, state;
            string str;
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Olmaliq&units=metric&appid=eb56dd43ccdd3b216d13940fa33e8616";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string responce;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responce);
            //Console.WriteLine("Temerature in {0}: {1} C", weatherResponse.Base, weatherResponse.Weather[0].Description);
            //temp = weatherResponse.Main.Temp.ToString();
            //feels = weatherResponse.Main.Feels_Like.ToString();
            //state = weatherResponse.Weather[0].Description;
            str = weatherResponse.Main.Temp.ToString() + ";" + weatherResponse.Main.Feels_Like.ToString() + ";" + weatherResponse.Weather[0].Main;
            File.WriteAllText(@"E:\CurrentWeather.txt", str);
            //Console.WriteLine(temp + " " + feels + " " + state);
            Console.ReadLine();

        }
    }
}
