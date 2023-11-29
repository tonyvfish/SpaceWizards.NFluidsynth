using System;

namespace NFluidsynth
{
    public interface ISettingEntry
    {
        string Name { get; }
        FluidTypes Type { get; }
        FluidHint Hints { get; }
        unsafe string StringDefault { get; }
        unsafe string StringValue { get; set; }
        int IntDefault { get; }
        (int min, int max) IntRange { get; }
        int IntValue { get; set; }
        double DoubleDefault { get; }
        (double min, double max) DoubleRange { get; }
        double DoubleValue { get; set; }
        void ForeachOption(Action<string, string> func);
        void ForeachOption(Func<IntPtr, string, string, IntPtr> func, IntPtr data = default(IntPtr));
        void Foreach(Action<string, FluidTypes> func);
        void Foreach(Func<IntPtr, string, FluidTypes, IntPtr> func, IntPtr data = default(IntPtr));
    }
}