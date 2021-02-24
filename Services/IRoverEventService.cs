using MarsRover.Models;
using System;

namespace MarsRover.Services
{
    public interface IRoverEventService
    {
        event EventHandler<PhotoEventArgs> NewPhotosEvent;

        void RaisePhotosEvent(Photo[] photos);
    }
}
