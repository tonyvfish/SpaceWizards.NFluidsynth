using System;

namespace NFluidsynth
{
    public interface ISettings
    {
        void Dispose();
        ISettingEntry this[string name] { get; }
        bool Equals(object obj);
        int GetHashCode();
        bool Disposed { get; }

        /// <summary>
        ///     Handle to the native Fluidsynth C object.
        /// </summary>
        IntPtr Handle { get; }
    }
}