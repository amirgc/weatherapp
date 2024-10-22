using WeatherApp.Manager.Models;

namespace WeatherApp.Manager
{
    public interface IForcastManager
    {
        Forcast GetForcast();
        Forcast GetForcastByCityName(string cityName);
        Forcast GetForcastByZipCode(string zipCode);
        Forcast GetForcastByLatLon(double latitude, double longitude);
        Forcast GetForcastByCityAndState(string cityName, string state);
        Forcast GetForcastByCityAndCountryCode(string cityName, string countryCode);
    }

    public class ForcastManager : IForcastManager
    {
        public Forcast GetForcast()
        {
            // Return mock data
            return new Forcast
            {
                City = "New York",
                State = "NY",
                Country = "USA",
                Temperature = 75.5,
                Humidity = 60.2,
                WindSpeed = 10.3,
                Description = "Sunny",
                Icon = "sun.png"
            };
        }

        public Forcast GetForcastByCityName(string cityName)
        {
            // Return mock data
            return new Forcast
            {
                City = cityName,
                State = "NY",
                Country = "USA",
                Temperature = 72.8,
                Humidity = 55.6,
                WindSpeed = 9.7,
                Description = "Partly cloudy",
                Icon = "cloud.png"
            };
        }

        public Forcast GetForcastByZipCode(string zipCode)
        {
            // Return mock data
            return new Forcast
            {
                City = "Los Angeles",
                State = "CA",
                Country = "USA",
                Temperature = 80.2,
                Humidity = 65.1,
                WindSpeed = 12.5,
                Description = "Clear sky",
                Icon = "sun.png"
            };
        }

        public Forcast GetForcastByLatLon(double latitude, double longitude)
        {
            // Return mock data
            return new Forcast
            {
                City = "San Francisco",
                State = "CA",
                Country = "USA",
                Temperature = 68.9,
                Humidity = 58.3,
                WindSpeed = 8.9,
                Description = "Foggy",
                Icon = "fog.png"
            };
        }

        public Forcast GetForcastByCityAndState(string cityName, string state)
        {
            // Return mock data
            return new Forcast
            {
                City = cityName,
                State = state,
                Country = "USA",
                Temperature = 70.1,
                Humidity = 62.7,
                WindSpeed = 11.2,
                Description = "Rainy",
                Icon = "rain.png"
            };
        }

        public Forcast GetForcastByCityAndCountryCode(string cityName, string countryCode)
        {
            // Return mock data
            return new Forcast
            {
                City = cityName,
                State = "NA",
                Country = countryCode,
                Temperature = 82.6,
                Humidity = 50.9,
                WindSpeed = 13.8,
                Description = "Cloudy",
                Icon = "cloud.png"
            };
        }
    }
}
