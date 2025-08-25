namespace BlazorApp_Copilot.Models;

public class WeatherResponse
{
    public string Name { get; set; } = string.Empty;
    public MainWeatherData Main { get; set; } = new();
    public WeatherInfo[] Weather { get; set; } = Array.Empty<WeatherInfo>();
    public WindData Wind { get; set; } = new();
    public CloudData Clouds { get; set; } = new();
    public int Visibility { get; set; }
    public SystemData Sys { get; set; } = new();
}