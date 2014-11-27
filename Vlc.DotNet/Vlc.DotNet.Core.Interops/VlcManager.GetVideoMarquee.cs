using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public bool GetVideoMarqueeEnabled(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Enable) == 1;
        }
        public string GetVideoMarqueeText(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
#if NET20
            return IntPtrExtensions.ToStringAnsi(GetInteropDelegate<GetVideoMarqueeString>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Text));
#else
            return GetInteropDelegate<GetVideoMarqueeString>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Text).ToStringAnsi();
#endif
        }
        public int GetVideoMarqueeColor(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Color);
        }
        public int GetVideoMarqueeOpacity(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Opacity);
        }
        public int GetVideoMarqueePosition(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Position);
        }
        public int GetVideoMarqueeRefresh(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Refresh);
        }
        public int GetVideoMarqueeSize(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Size);
        }
        public int GetVideoMarqueeTimeout(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Timeout);
        }
        public int GetVideoMarqueeX(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.X);
        }
        public int GetVideoMarqueeY(IntPtr mediaPlayerInstance)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            return GetInteropDelegate<GetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Y);
        }
    }
}
