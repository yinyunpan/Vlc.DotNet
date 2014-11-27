using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool GetVideoAdjustEnabled(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustInteger>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Enable) == 1;
        }

        public float GetVideoAdjustContrast(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Contrast);
        }

        public float GetVideoAdjustBrightness(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Brightness);
        }

        public float GetVideoAdjustHue(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Hue);
        }

        public float GetVideoAdjustSaturation(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Saturation);
        }

        public float GetVideoAdjustGamma(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Gamma);
        }
    }
}
