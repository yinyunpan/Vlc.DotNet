using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoAdjustEnabled(IntPtr mediaPlayerInstance, bool value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustInteger>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Enable, value ? 1 : 0);
        }
        public void SetVideoAdjustContrast(IntPtr mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Contrast, value);
        }
        public void SetVideoAdjustBrightness(IntPtr mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Brightness, value);
        }
        public void SetVideoAdjustHue(IntPtr mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Hue, value);
        }
        public void SetVideoAdjustSaturation(IntPtr mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Saturation, value);
        }
        public void SetVideoAdjustGamma(IntPtr mediaPlayerInstance, float value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoAdjustFloat>().Invoke(mediaPlayerInstance, VideoAdjustOptions.Gamma, value);
        }
    }
}
