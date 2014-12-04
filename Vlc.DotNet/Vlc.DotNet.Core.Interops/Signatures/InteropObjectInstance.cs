using System;

namespace Vlc.DotNet.Core.Interops.Signatures
{
    public abstract class InteropObjectInstance : IDisposable
    {
        internal IntPtr Pointer { get; private set; }

        protected InteropObjectInstance(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            Pointer = IntPtr.Zero;
        }

        ~InteropObjectInstance()
        {
            Dispose(false);
        }
    }
}