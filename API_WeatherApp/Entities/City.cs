namespace API_WeatherApp.Entities
{
    public class City
    {

        public int CityId { get; set; }
        public string CityName { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public decimal Temp { get; set; }
        public string Detail { get; set; } = string.Empty;

    }
}
