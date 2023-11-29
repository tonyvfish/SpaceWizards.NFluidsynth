namespace NFluidsynth
{
    public interface ISynthFactory
    {
        ISynth Create(ISettings settings);
    }
}