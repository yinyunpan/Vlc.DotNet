﻿using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public sealed partial class VlcManager
    {
        public IntPtr CreateMediaPlayer()
        {
            return GetInteropDelegate<CreateMediaPlayer>().Invoke(myVlcInstance);
        }
    }
}
