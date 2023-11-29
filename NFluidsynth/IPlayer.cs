using System;

namespace NFluidsynth
{
    public interface IPlayer
    {
        void Dispose();
        void Add(string midifile);

#if NETCOREAPP
        void AddMem(ReadOnlySpan<byte> buffer);
        void AddMem(byte [] buffer);
#endif
        void AddMem(byte [] buffer, int offset, int length);
        void AddMem(IntPtr buffer, int length);
        void Play();
        void Stop();
        void Join();
        void SetLoop(int loop);
        void Seek(int tick);
        void SetTempo(int tempo);
        void SetBpm(int bpm);
        int CurrentTick { get; }
        int GetTotalTicks { get; }
        int Bpm { get; set; }
        int MidiTempo { get; set; }
        FluidPlayerStatus Status { get; }
        bool Disposed { get; }

        /// <summary>
        ///     Handle to the native Fluidsynth C object.
        /// </summary>
        IntPtr Handle { get; }

        void SetPlaybackCallback(MidiEventHandler handler);
        void SetTicksCallback(MidiTickHandler handler);
        bool Equals(object obj);
        int GetHashCode();
    }
}