using MarsRover.Models;
using System;

namespace MarsRover.Services
{
    public class RoverEventService : IRoverEventService
    {
        public event EventHandler<PhotoEventArgs> NewPhotosEvent;

        public void RaisePhotosEvent(Photo[] photos)
        {
            if(NewPhotosEvent != null)
            {
                NewPhotosEvent(null, new PhotoEventArgs { Photos = photos });
            }
        }
    }
}
