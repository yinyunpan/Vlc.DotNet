using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool GetVideoLogoEnabled(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Enable) == 1;
        }

        public int GetVideoLogoX(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.X);
        }
        public int GetVideoLogoY(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Y);
        }
        public int GetVideoLogoDelay(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Delay);
        }
        public int GetVideoLogoRepeat(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Repeat);
        }
        public int GetVideoLogoOpacity(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Opacity);
        }
        public int GetVideoLogoPosition(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoLogoInteger>().Invoke(mediaPlayerInstance, VideoLogoOptions.Position);
        }
    }
}
