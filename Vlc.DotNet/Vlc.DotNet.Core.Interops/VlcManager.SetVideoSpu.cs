using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoSpu(IntPtr mediaInstance, TrackDescriptionStructure trackDescription)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            SetVideoSpu(mediaInstance, trackDescription.Id);
        }

        public void SetVideoSpu(IntPtr mediaInstance, int id)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<SetVideoSpu>().Invoke(mediaInstance, id);
        }
    }
}
