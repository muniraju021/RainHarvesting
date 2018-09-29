using LINQtoCSV;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation.UI.AppCode
{
    public class WeatherStationManagement
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(WeatherStationManagement));

        public WeatherDetails ProcessWeatherStationDetails(string filePath)
        {            
            try
            {
                CsvFileDescription inputFileDescription = new CsvFileDescription
                {
                    SeparatorChar = ',',
                    FirstLineHasColumnNames = true
                };
                CsvContext cc = new CsvContext();
                IEnumerable<WeatherDetails> lstWeatherDetails = cc.Read<WeatherDetails>(filePath, inputFileDescription).ToList();
                return lstWeatherDetails.FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.ErrorFormat($"Exeption in ProcessWeatherStationDetails {ex.Message} {ex.StackTrace}");                
                throw ex;
            }            
        }
    }

    public class WeatherDetails
    {
        [CsvColumn(Name = "Timestamp",OutputFormat = "dd/MM/yyyy HH:mm:ss tt", FieldIndex = 1)]
        public DateTime GenerationDate { get; set; }
        [CsvColumn(Name = "Outdoor Temperature",FieldIndex = 2)]
        public string OutDoorTemp { get; set; }
        [CsvColumn(Name = "Outdoor Humidity", FieldIndex = 3)]
        public string OutDoorHumidity { get; set; }
        [CsvColumn(Name = "Dew Point", FieldIndex = 4)]
        public string DewPoint { get; set; }
        [CsvColumn(Name = "Heat Index", FieldIndex = 5)]
        public string HeatIndex { get; set; }
        [CsvColumn(Name = "Wind Chill", FieldIndex = 6)]
        public string WindChill { get; set; }
        [CsvColumn(Name = "Barometric Pressure", FieldIndex = 7)]
        public string BarometricPressure { get; set; }
        [CsvColumn(Name = "Rain", FieldIndex = 8)]
        public string Rainfall { get; set; }
        [CsvColumn(Name = "Wind Speed", FieldIndex = 9)]
        public string WindSpeed { get; set; }
        [CsvColumn(Name = "Wind Average", FieldIndex = 10)]
        public string WindAverage { get; set; }
        [CsvColumn(Name = "Peak Wind", FieldIndex = 11)]
        public string PeakWind { get; set; }
        [CsvColumn(Name = "Wind Direction", FieldIndex = 12)]
        public string WindDirection { get; set; }

        [CsvColumn(Name = "Indoor Temperature", FieldIndex = 13)]
        public string IndoorTemperature { get; set; }

        [CsvColumn(Name = "Indoor Humidity", FieldIndex = 14)]
        public string IndoorHumidity { get; set; }
        
    }
}
