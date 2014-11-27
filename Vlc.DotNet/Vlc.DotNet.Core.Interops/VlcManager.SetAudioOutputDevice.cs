using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public void SetAudioOutputDevice(IntPtr mediaPlayerInstance, string audioOutputDescriptionName, string deviceName)
        {
            GetInteropDelegate<SetAudioOutputDevice>().Invoke(mediaPlayerInstance, StringExtensions.ToHGlobalAnsi(audioOutputDescriptionName), StringExtensions.ToHGlobalAnsi(deviceName));
        }
    }
}
