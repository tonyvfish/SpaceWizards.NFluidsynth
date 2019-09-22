﻿using static NFluidsynth.Native.LibFluidsynth;

namespace NFluidsynth
{
    public class MidiDriver : FluidsynthObject
    {
        // Keep these around to prevent the GC eating them.
        private readonly handle_midi_event_func_t _handler;
        private readonly Settings _settings;

        public unsafe MidiDriver(Settings settings, MidiEventHandler handler)
            : base(new_fluid_midi_driver(
                settings.Handle,
                Utility.PassDelegatePointer<handle_midi_event_func_t>(
                    (d, e) => handler(new MidiEvent(e)), out var b),
                null))
        {
            _handler = b;
            _settings = settings;
        }

        protected override void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                delete_fluid_midi_driver(Handle);
            }

            base.Dispose(disposing);
        }
    }
}