using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Vlc.DotNet.Core.Interops;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core
{
    internal sealed class SubTitlesManagement : ISubTitlesManagement
    {
        private readonly VlcManager myManager;
        private readonly IntPtr myMediaPlayer;

        public SubTitlesManagement(VlcManager manager, IntPtr mediaPlayerInstance)
        {
            myManager = manager;
            myMediaPlayer = mediaPlayerInstance;
        }

        public int Count
        {
            get { return myManager.GetVideoSpuCount(myMediaPlayer); }
        }

        public IEnumerable<TrackDescription> AvailableSubTitles
        {
            get
            {
                var module = myManager.GetVideoSpuDescription(myMediaPlayer);
                var result = GetSubTrackDescription(module);
                myManager.ReleaseTrackDescription(module);
                return result;
            }
        }

        private List<TrackDescription> GetSubTrackDescription(TrackDescriptionStructure module)
        {
            var result = new List<TrackDescription>();
            result.Add(new TrackDescription(module.Id, module.Name));
            if (module.NextTrackDescription != IntPtr.Zero)
            {
                TrackDescriptionStructure nextModule = (TrackDescriptionStructure)Marshal.PtrToStructure(module.NextTrackDescription, typeof(TrackDescriptionStructure));
                var data = GetSubTrackDescription(nextModule);
                result.AddRange(data);
            }
            return result;
        }

        public TrackDescription Current
        {
            get
            {
                var currentId = myManager.GetVideoSpu(myMediaPlayer);
                foreach (var availableSubTitle in AvailableSubTitles)
                {
                    if (availableSubTitle.ID == currentId)
                        return availableSubTitle;
                }
                return null;
            }
            set { myManager.SetVideoSpu(myMediaPlayer, value.ID); }
        }

        public long Delay
        {
            get { return myManager.GetVideoSpuDelay(myMediaPlayer); }
            set { myManager.SetVideoSpuDelay(myMediaPlayer, value); }
        }
    }
}
