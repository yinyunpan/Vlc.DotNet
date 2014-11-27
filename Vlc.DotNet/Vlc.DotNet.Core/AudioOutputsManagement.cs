using System;
using System.Collections.Generic;
using Vlc.DotNet.Core.Interops;

namespace Vlc.DotNet.Core
{
    internal class AudioOutputsManagement : IAudioOutputsManagement
    {
        private readonly VlcManager myManager;
        private readonly IntPtr myMediaPlayerInstance;

        internal AudioOutputsManagement(VlcManager manager, IntPtr mediaPlayerInstance)
        {
            myManager = manager;
            myMediaPlayerInstance = mediaPlayerInstance;
        }

        public IEnumerable<AudioOutputDescription> All
        {
            get
            {
                var module = myManager.GetAudioOutputsDescriptions();
                var result = AudioOutputDescription.GetSubOutputDescription(module, myManager, myMediaPlayerInstance);
                myManager.ReleaseAudioOutputDescription(module);
                return result;
            }
        }

        public int Count
        {
            get { return new List<AudioOutputDescription>(All).Count; }
        }

        public AudioOutputDescription Current
        {
            get
            {
                throw new NotImplementedException("Not implemented in LibVlc.");
            }
            set { myManager.SetAudioOutput(value.Name); }
        }
    }
}
