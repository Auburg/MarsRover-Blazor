using MarsRover.Models;
using System.Threading.Tasks;

namespace MarsRover.Services
{
    public interface IMarsRoverApi
    {
        Task<RoverManifest> GetRoverManifestAsync(string roverName);
        Task<RootPhotoData> GetRoverPhotosAsync(string roverName, int sol, string camera);
    }
}
