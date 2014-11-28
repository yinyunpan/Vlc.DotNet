using System;
using Vlc.DotNet.Core.Interops;

namespace Vlc.DotNet.Core
{
    internal class AudioManagement : IAudioManagement
    {
        private readonly VlcManager myManager;
        private readonly IntPtr myMediaPlayer;

        internal AudioManagement(VlcManager manager, IntPtr mediaPlayerInstance)
        {
            myManager = manager;
            myMediaPlayer = mediaPlayerInstance;
            Outputs = new AudioOutputsManagement(manager, mediaPlayerInstance);
        }

        public IAudioOutputsManagement Outputs { get; private set; }

        public bool IsMute
        {
            get { return myManager.IsMute(myMediaPlayer); }
            set { myManager.SetMute(myMediaPlayer, value); }
        }

        public void ToggleMute()
        {
            myManager.ToggleMute(myMediaPlayer);
        }
    }
}
