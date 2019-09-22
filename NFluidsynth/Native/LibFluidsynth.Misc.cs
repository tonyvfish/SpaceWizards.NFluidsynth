﻿using System;
using System.Runtime.InteropServices;

namespace NFluidsynth.Native
{
    internal static partial class LibFluidsynth
    {
        [DllImport(LibraryName)]
        [return: MarshalAs(UnmanagedType.I4)]
        internal static extern bool fluid_is_soundfont(string filename);

        [DllImport(LibraryName)]
        [return: MarshalAs(UnmanagedType.I4)]
        internal static extern bool fluid_is_midifile(string filename);

        [DllImport(LibraryName)]
        internal static extern IntPtr fluid_set_log_function(int severity, Logger.LoggerDelegate func, IntPtr data);
    }
}