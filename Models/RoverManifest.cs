using System.Text.Json.Serialization;

namespace MarsRover.Models
{
    public class RoverManifest
    {
        [JsonPropertyName("photo_manifest")]
        public PhotoManifest photoManifest { get; set; }
    }
}
