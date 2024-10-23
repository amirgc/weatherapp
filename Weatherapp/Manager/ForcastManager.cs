using WeatherApp.Models;

namespace WeatherApp.Manager
{
    public interface IForcastManager
    {
        ForcastInfo GetForcast();
        ForcastInfo GetForcastByCityName(string cityName);
        ForcastInfo GetForcastByZipCode(string zipCode);
        ForcastInfo GetForcastByLatLon(double latitude, double longitude);
        ForcastInfo GetForcastByCityAndState(string cityName, string state);
        ForcastInfo GetForcastByCityAndCountryCode(string cityName, string countryCode);
    }

    public class ForcastManager : IForcastManager
    {
        public ForcastInfo GetForcast()
        {
            // Return mock data
            return new ForcastInfo
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

        public ForcastInfo GetForcastByCityName(string cityName)
        {
            // Return mock data
            return new ForcastInfo
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

        public ForcastInfo GetForcastByZipCode(string zipCode)
        {
            // Return mock data
            return new ForcastInfo
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

        public ForcastInfo GetForcastByLatLon(double latitude, double longitude)
        {
            // Return mock data
            return new ForcastInfo
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

        public ForcastInfo GetForcastByCityAndState(string cityName, string state)
        {
            // Return mock data
            return new ForcastInfo
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

        public ForcastInfo GetForcastByCityAndCountryCode(string cityName, string countryCode)
        {
            // Return mock data
            return new ForcastInfo
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
