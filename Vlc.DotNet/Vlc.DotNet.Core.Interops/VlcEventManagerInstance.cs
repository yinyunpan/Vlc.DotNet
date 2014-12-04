using System;
using Vlc.DotNet.Core.Interops.Signatures;

namespace Vlc.DotNet.Core.Interops
{
    public abstract class VlcEventManagerInstance : InteropObjectInstance
    {
        private readonly VlcManager myManager;

        internal VlcEventManagerInstance(VlcManager manager, IntPtr pointer) : base(pointer)
        {
            myManager = manager;
        }

        public override void Dispose(bool disposing)
        {
            if (Pointer != IntPtr.Zero)
                myManager.Free(this);
            base.Dispose(disposing);
        }

        public static implicit operator IntPtr(VlcEventManagerInstance instance)
        {
            return instance.Pointer;
        }
    }
}