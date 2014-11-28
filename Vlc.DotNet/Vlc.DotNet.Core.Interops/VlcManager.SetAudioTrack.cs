using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetAudioTrack(IntPtr mediaInstance, TrackDescriptionStructure trackDescription)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            SetAudioTrack(mediaInstance, trackDescription.Id);
        }

        public void SetAudioTrack(IntPtr mediaInstance, int id)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            GetInteropDelegate<SetAudioTrack>().Invoke(mediaInstance, id);
        }
    }
}
