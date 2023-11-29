using System;

namespace NFluidsynth
{
    public interface IAudioDriver
    {
        void Dispose();
        bool Equals(object obj);
        int GetHashCode();
        bool Disposed { get; }

        /// <summary>
        ///     Handle to the native Fluidsynth C object.
        /// </summary>
        IntPtr Handle { get; }
    }
}