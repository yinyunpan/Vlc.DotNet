using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetVideoMarqueeEnabled(IntPtr mediaPlayerInstance, bool value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Enable, value ? 1 : 0);
        }
        public void SetVideoMarqueeText(IntPtr mediaPlayerInstance, string value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
#if NET20
            GetInteropDelegate<SetVideoMarqueeString>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Text, StringExtensions.ToHGlobalAnsi(value));
#else
            GetInteropDelegate<SetVideoMarqueeString>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Text, value.ToHGlobalAnsi());
#endif
        }
        public void SetVideoMarqueeColor(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Color, value);
        }
        public void SetVideoMarqueeOpacity(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Opacity, value);
        }
        public void SetVideoMarqueePosition(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Position, value);
        }
        public void SetVideoMarqueeRefresh(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Refresh, value);
        }
        public void SetVideoMarqueeSize(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Size, value);
        }
        public void SetVideoMarqueeTimeout(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Timeout, value);
        }
        public void SetVideoMarqueeX(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.X, value);
        }
        public void SetVideoMarqueeY(IntPtr mediaPlayerInstance, int value)
        {
            if (mediaPlayerInstance == IntPtr.Zero)
                throw new ArgumentException("Media player instance is not initialized.");
            GetInteropDelegate<SetVideoMarqueeInteger>().Invoke(mediaPlayerInstance, VideoMarqueeOptions.Y, value);
        }
    }
}
