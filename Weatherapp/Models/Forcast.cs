namespace WeatherApp.Models
{
    public class ForcastInfo
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
