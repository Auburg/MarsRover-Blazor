using MarsRover.Models;
using System;

namespace MarsRover.Services
{
    public class PhotoEventArgs : EventArgs
    {
        public Photo[] Photos { get; set; }
    }
}