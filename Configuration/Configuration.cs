namespace MarsRover.Configuration
{
    public class Rootobject
    {
        public Configuration Configuration { get; set; }
    }

    public class Configuration : IConfiguration
    {
        public string ApiKey { get; set; }
        public string ApiBaseUrl { get; set; }
    }
}
