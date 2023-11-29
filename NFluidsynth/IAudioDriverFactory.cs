namespace NFluidsynth
{
    public interface IAudioDriverFactory
    {
        IAudioDriver Create(ISettings settings, ISynth synth);
    }
}