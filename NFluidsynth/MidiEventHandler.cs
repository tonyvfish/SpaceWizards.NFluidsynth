namespace NFluidsynth
{
    public delegate int MidiEventHandler(IMidiEvent evt);
    public delegate int MidiTickHandler(int ticks);
}