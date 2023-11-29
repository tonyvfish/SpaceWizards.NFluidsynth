using System;

namespace NFluidsynth
{
    public interface IMidiEvent
    {
        void Dispose();
        int Type { get; set; }
        int Channel { get; set; }
        int Key { get; set; }
        int Velocity { get; set; }
        int Control { get; set; }
        int Value { get; set; }
        int Program { get; set; }
        int Pitch { get; set; }
        bool Disposed { get; }

        /// <summary>
        ///     Handle to the native Fluidsynth C object.
        /// </summary>
        IntPtr Handle { get; }

        unsafe void SetSysex(void* data, int size, bool isDynamic);
        bool Equals(object obj);
        int GetHashCode();
    }
}