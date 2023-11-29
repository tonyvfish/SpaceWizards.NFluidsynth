namespace NFluidsynth
{
    public class AudioDriverFactory : IAudioDriverFactory
    {
        public IAudioDriver Create(ISettings settings, ISynth synth)
        {
            return new AudioDriver(settings, synth);
        }
    }
}