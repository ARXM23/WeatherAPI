using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace WeatherAPI
{
    public partial class weather : Form
    {
        public weather()
        {
            InitializeComponent();
        }

        String APIKey = "2e181335bb0621000eeaaa8b4d9cd6ce";

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", 
                    TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherMethods.report Report = JsonConvert.DeserializeObject<WeatherMethods.report>(json);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Report.weather[0].icon + ".png";
                labCondition.Text = Report.weather[0].main;
                labDetails.Text = Report.weather[0].description;
                labSunrise.Text = convertDateTime(Report.system.sunrise).ToShortTimeString();
                labSunset.Text = convertDateTime(Report.system.sunset).ToShortTimeString();

                labTemperature.Text = Report.main.temp.ToString();
                labWindSpeed.Text = Report.wind.speed.ToString();
                labPressure.Text = Report.main.pressure.ToString();
            }
            
        }
        DateTime convertDateTime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }
        private void weather_Load(object sender, EventArgs e)
        {

        }

        private void labSunrise_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            getWeather();
        }
    }
}
