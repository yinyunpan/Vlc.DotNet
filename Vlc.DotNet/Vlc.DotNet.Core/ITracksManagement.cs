using System.Collections.Generic;

namespace Vlc.DotNet.Core
{
    public interface ITracksManagement
    {
        int Count { get; }
        TrackDescription Current { get; set; }
        IEnumerable<TrackDescription> All { get; }
    }
}
