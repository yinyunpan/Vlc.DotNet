using System;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public MediaTrackInfos[] GetMediaTracksInformations(IntPtr mediaInstance)
        {
            if (mediaInstance == IntPtr.Zero)
                throw new ArgumentException("Media instance is not initialized.");
            var fullBuffer = IntPtr.Zero;
            var cpt = GetInteropDelegate<GetMediaTracksInformations>().Invoke(mediaInstance, out fullBuffer);
            if (cpt <= 0)
                return new MediaTrackInfos[0];
            var result = new MediaTrackInfos[cpt];
            var buffer = fullBuffer;
            for (int index = 0; index < cpt; index++)
            {
                result[index] = (MediaTrackInfos)Marshal.PtrToStructure(buffer, typeof(MediaTrackInfos));
                buffer = new IntPtr(buffer.ToInt32() + Marshal.SizeOf(typeof(MediaTrackInfos)));
            }
            Free(fullBuffer);
            return result;
        }
    }
}
