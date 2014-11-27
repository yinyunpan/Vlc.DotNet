using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoTrack(IntPtr mediaInstance, TrackDescriptionStructure trackDescription)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            SetVideoTrack(mediaInstance, trackDescription.Id);
        }

        public void SetVideoTrack(IntPtr mediaInstance, int id)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<SetVideoTrack>().Invoke(mediaInstance, id);
        }
    }
}
