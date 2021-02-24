namespace MarsRover.Configuration
{
    public interface IConfiguration
    {
        public string ApiKey { get; set; }
        public string ApiBaseUrl { get; set; }
    }
}
